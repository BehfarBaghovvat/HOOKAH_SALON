using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HOOKAH_SALON.Store
{
	public partial class DrinkStoreForm :Infrastructure.BaseForm
	{
		#region Properties
		public string Search { get; private set; }
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

		public DrinkStoreForm()
		{
			InitializeComponent();
		}

		//-----The beginning of the coding line.

		#region DrinkStoreForm_Load
		private void DrinkStoreForm_Load(object sender, System.EventArgs e)
		{
			DrinkLoader();
		}
		#endregion /DrinkStoreForm_Load

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

		#region DrinkSearchTextBox_Enter
		private void DrinkSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			drinkSearchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			drinkSearchPanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			if (string.Compare(drinkSearchTextBox.Text, "جستجوی کالا...") == 0)
			{
				drinkSearchTextBox.Select(drinkSearchTextBox.Text.Length, 0);
			}
			else
			{
				drinkSearchTextBox.Select(0, drinkSearchTextBox.Text.Length);
			}
		}
		#endregion /DrinkSearchTextBox_Enter

		#region DrinkSearchTextBox_KeyPress
		private void DrinkSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(drinkSearchTextBox.Text, "جستجوی کالا...") == 0)
			{
				drinkSearchTextBox.Clear();
			}
			else
			{
				drinkSearchTextBox.Clear();
			}
		}
		#endregion /DrinkSearchTextBox_KeyPress

		#region DrinkSearchTextBox_Leave
		private void DrinkSearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(drinkSearchTextBox.Text, "جستجوی کالا...") == 0 || string.IsNullOrWhiteSpace(drinkSearchTextBox.Text))
			{
				drinkSearchTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				drinkSearchPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				Search = null;
				drinkSearchTextBox.Text = "جستجوی کالا...";
				return;
			}
			else
			{
				drinkSearchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkSearchPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /DrinkSearchTextBox_Leave

		#region DrinkSearchTextBox_TextChanged
		private void DrinkSearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Search = drinkSearchTextBox.Text;
			DrinkFounded(Search);
		}
		#endregion /DrinkSearchTextBox_TextChanged

		#region DeleteRecordButton_Click
		private void DeleteRecordButton_Click(object sender, System.EventArgs e)
		{
			if (drinkStoreDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"{drinkStoreDataGridView.CurrentRow.Cells[0].Value} حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف مشترک
				{
					string drinkName = drinkStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						Models.Drink drink =
							dataBaseContext.Drinks
							.Where(current => string.Compare(current.DrinkName, drinkName) == 0)
							.FirstOrDefault();
						if (drink != null)
						{
							var entry = dataBaseContext.Entry(drink);

							if (entry.State == EntityState.Detached)
							{
								dataBaseContext.Drinks.Attach(drink);
							}
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"{drinkName} حذف گردید.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						dataBaseContext.Drinks.Remove(drink);
						dataBaseContext.SaveChanges();
						DrinkLoader();
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
			if (drinkStoreDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه اطلاعات حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به نوشیدنی
				{
					List<Models.Drink> drinks = new List<Models.Drink>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						 drinks =
							dataBaseContext.Drinks
							.OrderBy(current => current.DrinkName)
							.ToList();

						if (drinks != null)
						{
							foreach (var item in drinks) //---توسط این کد با پیمایش در لیست نوشیدنی یکی یکی ایتمهای موجود در لیست نوشیدنی را حذف میکند.
							{
								dataBaseContext.Drinks.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (drinks == null)
						{
							return;
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"حذف کامل اطلاعات.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						DrinkLoader();
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه اطلاعات نوشیدنی حذف گردید!",
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

		#region DrinkStoreDataGridView_CellDoubleClick
		private void DrinkStoreDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			}

			string selectedDrinkName =
				drinkStoreDataGridView.CurrentRow.Cells[0].Value.ToString();
			string drinkImage =
				drinkStoreDataGridView.CurrentRow.Cells[3].Value.ToString();

			Store.DrinkEditeForm drinkEditFrom = new DrinkEditeForm
			{
				MyDrinkStoreForm = this,
				DrinkName_FirstLoad = selectedDrinkName,
			};

			drinkEditFrom.ShowDialog();
		}
		#endregion /DrinkStoreDataGridView_CellDoubleClick

		//-----End of coding line

		#region Founctions
		//-----
		#region DrinkFounded
		private void DrinkFounded(string searchDrink)
		{
			if (searchDrink.Contains("جستجو کالا ..."))
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

					System.Collections.Generic.List<Models.Drink> drinks = null;

					if (string.IsNullOrEmpty(searchDrink))
					{
						drinks =
							dataBaseContext.Drinks
							.OrderBy(current => current.DrinkName)
							.ToList();
					}
					else
					{
						drinks =
							dataBaseContext.Drinks
							.Where(current => current.DrinkName.Contains(searchDrink))
							.OrderBy(current => current.DrinkName)
							.ToList();
					}

					drinkStoreDataGridView.DataSource = drinks;
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
		#endregion /DrinkFounded

		#region DrinkLoader
		public void DrinkLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Drink> drinks = null;

				drinks =
					dataBaseContext.Drinks
					.OrderBy(current => current.DrinkName)
					.ToList();

				drinkStoreDataGridView.DataSource = drinks;

				if (drinkStoreDataGridView.Rows.Count > 0)
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

		#endregion /DrinkLoader
		//-----
		#endregion /Founctions
	}
}
