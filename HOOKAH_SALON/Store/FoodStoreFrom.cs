using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HOOKAH_SALON.Store
{
	public partial class FoodStoreFrom : Infrastructure.BaseForm
	{
		public FoodStoreFrom()
		{
			InitializeComponent();
		}

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

		//-----The beginning of the coding line.

		#region FoodStoreFrom_Load
		private void FoodStoreFrom_Load(object sender, System.EventArgs e)
		{
			FoodLoader();
		}
		#endregion /FoodStoreFrom_Load

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

		#region FoodSearchTextBox_Enter
		private void FoodSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			foodSearchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			foodSearchPanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			if (string.Compare(foodSearchTextBox.Text, "جستجوی کالا...") == 0)
			{
				foodSearchTextBox.Select(foodSearchTextBox.Text.Length, 0);
			}
			else
			{
				foodSearchTextBox.Select(0, foodSearchTextBox.Text.Length);
			}
		}
		#endregion /FoodSearchTextBox_Enter

		#region FoodSearchTextBox_KeyPress
		private void FoodSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(foodSearchTextBox.Text, "جستجوی کالا...") == 0)
			{
				foodSearchTextBox.Clear();
			}
			else
			{
				foodSearchTextBox.Clear();
			}
		}
		#endregion /FoodSearchTextBox_KeyPress

		#region FoodSearchTextBox_Leave
		private void FoodSearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(foodSearchTextBox.Text, "جستجوی کالا...") == 0 || string.IsNullOrWhiteSpace(foodSearchTextBox.Text))
			{
				foodSearchTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodSearchPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				Search = null;
				foodSearchTextBox.Text = "جستجوی کالا...";
				return;
			}
			else
			{
				foodSearchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodSearchPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /FoodSearchTextBox_Leave

		#region FoodSearchTextBox_TextChanged
		private void FoodSearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Search = foodSearchTextBox.Text;
			FoodFounded(Search);
		}
		#endregion /FoodSearchTextBox_TextChanged

		#region DeleteRecordButton_Click
		private void DeleteRecordButton_Click(object sender, System.EventArgs e)
		{
			if (foodStoreDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"{foodStoreDataGridView.CurrentRow.Cells[0].Value} حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف مشترک
				{
					string foodName = foodStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						Models.Food	food  =
							dataBaseContext.Foods
							.Where(current => string.Compare(current.FoodName, foodName) == 0)
							.FirstOrDefault();
						if (food != null)
						{
							var entry = dataBaseContext.Entry(food);

							if (entry.State == EntityState.Detached)
							{
								dataBaseContext.Foods.Attach(food);
							}
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"{foodName} حذف گردید.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						dataBaseContext.Foods.Remove(food);
						dataBaseContext.SaveChanges();
						FoodLoader();
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
			if (foodStoreDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه اطلاعات حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به نوشیدنی
				{
					List<Models.Food> foods = new List<Models.Food>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						foods =
						   dataBaseContext.Foods
						   .OrderBy(current => current.FoodName)
						   .ToList();

						if (foods != null)
						{
							foreach (var item in foods) //---توسط این کد با پیمایش در لیست نوشیدنی یکی یکی ایتمهای موجود در لیست نوشیدنی را حذف میکند.
							{
								dataBaseContext.Foods.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (foods == null)
						{
							return;
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"حذف کامل اطلاعات غذا.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						FoodLoader();
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه اطلاعات غذا حذف گردید!",
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

		#region FoodStoreDataGridView_CellDoubleClick
		private void FoodStoreDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			}

			string selectedFoodName =
				foodStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

			Store.FoodEditeForm foodEditFrom = new FoodEditeForm
			{
				MyFoodStoreForm = this,
				FoodName_FirstLoad = selectedFoodName,
			};

			foodEditFrom.ShowDialog();
		}
		#endregion /FoodStoreDataGridView_CellDoubleClick

		//-----End of coding line

		#region Founctions
		//-----
		#region FoodFounded
		private void FoodFounded(string searchDrink)
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

					System.Collections.Generic.List<Models.Food> foods = null;

					if (string.IsNullOrEmpty(searchDrink))
					{
						foods =
							dataBaseContext.Foods
							.OrderBy(current => current.FoodName)
							.ToList();
					}
					else
					{
						foods =
							dataBaseContext.Foods
							.Where(current => current.FoodName.Contains(searchDrink))
							.OrderBy(current => current.FoodName)
							.ToList();
					}

					foodStoreDataGridView.DataSource = foods;
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
		#endregion /FoodFounded

		#region FoodLoader
		public void FoodLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Food> foods = null;

				foods =
					dataBaseContext.Foods
					.OrderBy(current => current.FoodName)
					.ToList();

				foodStoreDataGridView.DataSource = foods;

				if (foodStoreDataGridView.Rows.Count > 0)
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




		#endregion /FoodLoader
		//-----
		#endregion /Founctions
	}
}
