using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HOOKAH_SALON.Store
{
	public partial class HookahStoreForm : Infrastructure.BaseForm
	{
		public HookahStoreForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Search { get; set; }
		public string EventRegisterDate { get; private set; }
		public string EventTitle { get; private set; }
		public string EventLog_Username { get; private set; }
		public string EventLog_FullName { get; private set; }
		public string EventLog_EventDate { get; private set; }
		public string EventLog_EventTitle { get; private set; }
		public string Username { get; private set; }
		public string FullName { get; private set; }
		public string EventDate { get; private set; }
		public string EventTime { get; private set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region HookahStoreForm_Load
		private void HookahStoreForm_Load(object sender, System.EventArgs e)
		{
			HookahLoader();
		}
		#endregion /HookahStoreForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion /CloseButton_Click

		#region MinimizButton_Click
		private void MinimizButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizButton_Click

		#region HookahSearchTextBox_Enter
		private void HookahSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			hookahSearchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahSearchPanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			hookahSearchTextBox.Select(0, 0);
		}
		#endregion /HookahSearchTextBox_Enter

		#region HookahSearchTextBox_KeyPress
		private void HookahSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(hookahSearchTextBox.Text, "جستجوی کالا...") == 0)
			{
				hookahSearchTextBox.Clear();
			}
		}
		#endregion /HookahSearchTextBox_KeyPress

		#region HookahSearchTextBox_Leave
		private void HookahSearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(hookahSearchTextBox.Text, "جستجوی کالا...") == 0 || string.IsNullOrWhiteSpace(hookahSearchTextBox.Text))
			{
				hookahSearchTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				hookahSearchPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				Search = null;
				hookahSearchTextBox.Text = "جستجو...";
				return;
			}
			else
			{
				hookahSearchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahSearchPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /HookahSearchTextBox_Leave

		#region HookahSearchTextBox_TextChanged
		private void HookahSearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Search = hookahSearchTextBox.Text;
			HookahFounded(Search);
		}
		#endregion /HookahSearchTextBox_TextChanged

		#region DeleteRecordButton_Click
		private void DeleteRecordButton_Click(object sender, System.EventArgs e)
		{
			if (hookahStoreDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"{hookahStoreDataGridView.CurrentRow.Cells[0].Value} حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف مشترک
				{
					string hookahName = hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						Models.Hookah hookah =
							dataBaseContext.Hookahs
							.Where(current => string.Compare(current.HookahName, hookahName) == 0)
							.FirstOrDefault();
						if (hookah != null)
						{
							var entry = dataBaseContext.Entry(hookah);

							if (entry.State == EntityState.Detached)
							{
								dataBaseContext.Hookahs.Attach(hookah);
							}
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate =$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"{hookahName} حذف گردید.";

						Infrastructure.Utility.EventLog(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						dataBaseContext.Hookahs.Remove(hookah);
						dataBaseContext.SaveChanges();
						HookahLoader();
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کد مورد نظر حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: $"موردی برای حذف وجود ندارد!",
					caption: "اطلاع",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return;
			}
		}
		#endregion /DeleteRecordButton_Click

		#region AllClearButton_Click
		private void AllClearButton_Click(object sender, System.EventArgs e)
		{
			if (hookahStoreDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه اطلاعات قلیان حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) ;

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به نوشیدنی
				{
					List<Models.Hookah> hookahs = new List<Models.Hookah>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						hookahs =
						   dataBaseContext.Hookahs
						   .OrderBy(current => current.HookahName)
						   .ToList();

						if (hookahs != null)
						{
							foreach (var item in hookahs) //---توسط این کد با پیمایش در لیست نوشیدنی یکی یکی ایتمهای موجود در لیست نوشیدنی را حذف میکند.
							{
								dataBaseContext.Hookahs.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (hookahs == null)
						{
							return;
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"حذف کامل اطلاعات قلیان.";

						Infrastructure.Utility.EventLog(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						HookahLoader();
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه اطلاعات قلیان حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: $"موردی برای حذف وجود ندارد!",
					caption: "اطلاع",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return;
			}
		}
		#endregion /AllClearButton_Click

		#region HookahStoreDataGridView_CellDoubleClick
		private void HookahStoreDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			}

			string selectedHookahName =
				hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString();
			string hookahImage  =
				hookahStoreDataGridView.CurrentRow.Cells[3].Value.ToString();

			Store.HookahEditFrom hookahEditFrom = new HookahEditFrom
			{
				MyHookahStoreForm = this,
				HookahName_FirstLoad = selectedHookahName,
			};

			hookahEditFrom.ShowDialog();
		}
		#endregion /HookahStoreDataGridView_CellDoubleClick

		//-----End of coding line

		#region Founctions
		//-----
		#region HookahFounded
		private void HookahFounded(string searchHooka)
		{
			if (searchHooka.Contains("جستجو کالا ..."))
			{
				return;
			}
			else
			{
				Models.DataBaseContext dataBaseContext = null;

				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					System.Collections.Generic.List<Models.Hookah> hookah = null;

					if (string.IsNullOrEmpty(searchHooka))
					{
						hookah =
							dataBaseContext.Hookahs
							.OrderBy(current => current.HookahName)
							.ToList();
					}
					else
					{
						hookah =
							dataBaseContext.Hookahs
							.Where(current => current.HookahName.Contains(searchHooka))
							.OrderBy(current => current.HookahName)
							.ToList();
					}

					hookahStoreDataGridView.DataSource = hookah;
				}
				catch (System.Exception ex)
				{
					Infrastructure.Utility.ExceptionShow(ex);
				}
				finally
				{
					if (dataBaseContext != null)
					{
						dataBaseContext.Dispose();
						dataBaseContext = null;
					}
				}
			}
			return;
		}
		#endregion /HookahFounded

		#region HookahLoader
		public void HookahLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Hookah> hookahs = null;

				hookahs =
					dataBaseContext.Hookahs
					.OrderBy(current => current.HookahName)
					.ToList();

				hookahStoreDataGridView.DataSource = hookahs;

				if (hookahStoreDataGridView.Rows.Count > 0)
				{
					deleteRecordButton.Enabled = true;
					allClearButton.Enabled = true;
				}
				else
				{
					deleteRecordButton.Enabled = false;
					allClearButton.Enabled = false;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}

		#endregion /HookahLoader
		//-----
		#endregion /Founctions
	}
}
