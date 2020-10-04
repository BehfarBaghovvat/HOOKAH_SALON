using HOOKAH_SALON.Setting;
using LiveCharts;
using LiveCharts.Wpf;
using Models;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HOOKAH_SALON
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

		#region HookahStoreForm
		private static Store.HookahStoreForm hookahStoreForm = null;

		public static Store.HookahStoreForm HookahStoreForm
		{
			get
			{
				if (hookahStoreForm == null || hookahStoreForm.IsDisposed == true)
				{
					hookahStoreForm =
						new Store.HookahStoreForm();
				}
				return hookahStoreForm;
			}
		}
		#endregion /HookahStoreForm

		#region DrinkStoreForm
		private static Store.DrinkStoreForm drinkStoreForm = null;

		public static Store.DrinkStoreForm DrinkStoreForm
		{
			get
			{
				if (drinkStoreForm == null || drinkStoreForm.IsDisposed == true)
				{
					drinkStoreForm =
						new Store.DrinkStoreForm();
				}
				return drinkStoreForm;
			}
		}
		#endregion /DrinkStoreForm

		#region FoodStoreFrom
		private static Store.FoodStoreFrom foodStoreFrom = null;

		public static Store.FoodStoreFrom FoodStoreFrom
		{
			get
			{
				if (foodStoreFrom == null || foodStoreFrom.IsDisposed == true)
				{
					foodStoreFrom =
						new Store.FoodStoreFrom();
				}
				return foodStoreFrom;
			}
		}
		#endregion /FoodStoreFrom

		#region PermanentClientListForm
		private static Setting.Client.PermanentClientListForm permanentClientListForm = null;

		public static Setting.Client.PermanentClientListForm PermanentClientListForm
		{
			get
			{
				if (permanentClientListForm == null || permanentClientListForm.IsDisposed == true)
				{
					permanentClientListForm =
						new Setting.Client.PermanentClientListForm();
				}
				return permanentClientListForm;
			}
		}
		#endregion /PermanentClientListForm

		#region AdministratorSettingForm
		private Setting.AdministratorSettingForm administratorSettingForm = null;

		public Setting.AdministratorSettingForm AdministratorSettingForm
		{
			get
			{
				if (administratorSettingForm == null || administratorSettingForm.IsDisposed == true)
				{
					administratorSettingForm =
						new Setting.AdministratorSettingForm();
				}
				return administratorSettingForm;
			}
		}
		#endregion /AdministratorSettingForm

		#region BackupAndRestorForm
		private BackupAndRestorForm backupAndRestorForm = null;
		public BackupAndRestorForm BackupAndRestorForm
		{
			get
			{
				if (backupAndRestorForm == null || backupAndRestorForm.IsDisposed)
				{
					backupAndRestorForm =
						new BackupAndRestorForm();
				}
				return backupAndRestorForm;
			}
		}
		#endregion /BackupAndRestorForm

		#region ClientManegmentForm
		private Setting.ClientManegmentForm clientManegmentForm = null;

		public Setting.ClientManegmentForm ClientManegmentForm
		{
			get
			{
				if (clientManegmentForm == null || clientManegmentForm.IsDisposed == true)
				{
					clientManegmentForm =
						new Setting.ClientManegmentForm();
				}
				return clientManegmentForm;
			}
		}
		#endregion /ClientManegmentForm

		#region ClientOrderList
		private class ClientOrderList
		{
			public string OrderName { get; set; }
			public string Price { get; set; }
			public int Number { get; set; }
			public string SumPrice { get; set; }
		}
		#endregion /ClientOrderList

		#region EditUsernameForm
		private EditUsernameForm editUsernameForm = null;

		public EditUsernameForm EditUsernameForm
		{
			get
			{
				if (editUsernameForm == null || editUsernameForm.IsDisposed == true)
				{
					editUsernameForm =
						new EditUsernameForm();
				}
				return editUsernameForm;
			}
		}
		#endregion /EditUsernameForm

		#region Properties
		public string AccountStatus { get; set; }
		public string ClientID { get; private set; }
		public string ClientName { get; private set; }
		public bool ClientType { get; set; }
		public bool DrinkSearch { get; set; }
		public string EventLog_Username { get; private set; }
		public string EventLog_FullName { get; private set; }
		public string EventLog_EventDate { get; private set; }
		public string EventLog_EventTime { get; private set; }
		public string EventLog_EventTitle { get; private set; }
		public string Entry_Payment { get; set; }
		public bool FoodSearch { get; set; }
		public bool HookahSearch { get; set; }
		public string LogOutTime { get; private set; }
		public int Month_Int { get; private set; }
		public string Month_String { get; private set; }
		public int NumberVisit { get; set; }
		public string NameItem { get; set; }
		public int Number { get; set; }
		public string OrderDate { get; private set; }
		public bool Order { get; set; }
		public int ObjectPrice { get; set; }
		public int Payment { get; set; }
		public string Payment_Type { get; set; }
		public string Permanent { get; private set; }
		public bool Report { get; set; }
		public int Remaining { get; private set; }
		public string Remaining_string { get; private set; }
		public bool Store { get; set; }
		public bool Setting { get; set; }
		public string Search { get; set; }
		public int SumPriceItem { get; set; }
		public string Total_Price_String { get; private set; }
		public int Total_Price_Int { get; private set; }
		public string Temporary { get; private set; }
		public string WarePrice { get; set; }

		#region Hookah
		public string HookahName { get; private set; }
		public int HookahPrice { get; set; }
		public string HookahPrice_String { get; private set; }
		public string HookahDescription { get; set; }
		public string HookahImage { get; set; }
		public string HookahRegisterDate { get; set; }
		public string HookahRegisterTime { get; set; }
		public string HookahUpdateTime { get; set; }
		public int HookahNumberUpdate { get; private set; }
		public string ExtraHead_String { get; set; }
		public int ExtraHead { get; private set; }
		#endregion /Hookah

		#region Drink
		public string DrinkName { get; set; }
		public string DrinkPrice_String { get; private set; }
		public int DrinkPrice { get; set; }
		public string DrinkDescription { get; set; }
		public string DrinkImage { get; set; }
		public string DrinkRegisterDate { get; set; }
		public string DrinkRegisterTime { get; set; }
		public string DrinkUpdateTime { get; set; }
		public int DrinkNumberUpdate { get; private set; }
		#endregion /Drink

		#region Food
		public string FoodName { get; set; }
		public string FoodPrice_String { get; private set; }
		public int FoodPrice { get; set; }
		public string FoodDescription { get; set; }
		public string FoodImage { get; set; }
		public string FoodRegisterDate { get; private set; }
		public string FoodRegisterTime { get; private set; }
		public string FoodUpdateTime { get; private set; }
		public int FoodNumberUpdate { get; private set; }
		#endregion /Food

		#endregion /Properties

		//-----The beginning of the coding line.

		#region MainForm
		//-----
		#region MainForm_FormClosed
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			SaveLogOutTime(Program.AutenticatLogHistory);
		}
		#endregion /MainForm_FormClosed 

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			clockTimer.Start();
			Month_Int = 0;
			Month_String = null;
			FormLoad();
			this.Opacity = 0.0;
			fadeFormTimer.Start();
		}
		#endregion /MainForm_Load 
		//-----
		#endregion /MainForm

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "قصد خروج دارید؟", caption: "خروج از برنامه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				Infrastructure.Utility.SaveLogOutTime(Program.AutenticatLogHistory);


				//SaveLogOutTime(Program.AutenticatLogHistory);
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /CloseButton_Click

		#region MinimizButton_Click
		private void MinimizButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizButton_Click

		#region ClockTimer_Tick
		private void ClockTimer_Tick(object sender, EventArgs e)
		{
			string second, minute, hour;
			string finalSecond, finalMinute, finalHour;
			int month, day;

			second = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			secondLabel.Text = second;

			if (string.Compare(secondLabel.Text, "00") == 0)
			{
				minute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
				minuteLabel.Text = minute;
			}
			if (string.Compare(minuteLabel.Text, "00") == 0)
			{
				hour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
				hourLabel.Text = hour;
			}

			finalSecond = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			finalMinute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			finalHour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');

			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			month = persianCalendar.GetMonth(System.DateTime.Now);
			day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			#region DailyFinancialCalculation
			if (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0)
			{
				CalculateDayFinancial();

				return;
			}
			#endregion /DailyFinancialCalculation

			#region MonthlyFinancialCalculation
			if (((month >= 1 || month <= 6) && day == 31) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			{
				CalculatMonthFinancial();
			}
			else if (((month >= 7 || month <= 11) && day == 30) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			{
				CalculatMonthFinancial();
			}
			else if ((month == 12 && day == 29) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			{
				CalculatMonthFinancial();
			}
			#endregion /MonthlyFinancialCalculation
		}
		#endregion /ClockTimer_Tick

		#region MoreLessButton_Click
		private void MoreLessButton_Click(object sender, System.EventArgs e)
		{
			if (rightSidePanel.Width == 250)
			{
				menuPanel.Visible = false;
				logOutButton.Location = new System.Drawing.Point(x: 191, y: 593);
				shutdownButton.Location = new System.Drawing.Point(x: 191, y: 624);
				menuPanel.Width = 50;
				rightSidePanel.Width = 80;
				//menuTransition1.Show(menuPanel);
				sideMenuTransition2.Show(menuPanel);
			}
			else
			{
				menuPanel.Visible = false;
				rightSidePanel.Width = 250;
				menuPanel.Width = 230;
				shutdownButton.Location = new System.Drawing.Point(x: 191, y: 624);
				logOutButton.Location = new System.Drawing.Point(x: 162, y: 624);
				//menuTransition2.Show(menuPanel);
				sideMenuTransition1.Show(menuPanel);
			}
		}
		#endregion /MoreLessButton_Click

		#region UserImagePicturBox_MouseDoubleClick
		private void UserImagePicturBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ShowUserImageForm showUserImageForm = new ShowUserImageForm();
			showUserImageForm.Show();
		}
		#endregion /UserImagePicturBox_MouseDoubleClick

		#region UsernameLoginLinkLabel_LinkClicked
		private void UsernameLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (string.Compare(Program.AuthenticatedUser.Username, "administrator") == 0)
			{
				return;
			}
			else
			{
				EditUsernameForm.MainForm = this;

				EditUsernameForm.ShowDialog();
			}
		}
		#endregion /UsernameLoginLinkLabel_LinkClicked

		#region HomeButton_Click
		private void HomeButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Height = homeButton.Height;
			focusPanel.Top = homeButton.Top;
			mainPanel.Controls.Clear();

			Order = false;
			Store = false;
			Report = false;
			Setting = false;

			currentPageLabel.Text = homeButton.Text;
			iconPagePicturBox.Image = Properties.Resources.windows_client_512px;
		}
		#endregion /HomeButton_Click

		#region ORDER
		//-----
		#region OrderButton_Click
		private void OrderButton_Click(object sender, System.EventArgs e)
		{
			if (Order == true)
			{
				return;//---برای اینکه کامپوننت menuTransation مجدد کار نکند.
			}
			else
			{
				HookahLoader();
				DrinkLoader();
				FoodLoader();

				Order = true;
				Store = false;
				Report = false;
				Setting = false;

				orderPanel.Visible = false;
				storePanel.Visible = false;
				reportPanel.Visible = false;
				settingPanel.Visible = false;

				this.mainPanel.Controls.Clear();
				this.mainPanel.Controls.Add(orderPanel);
				showPageTransition1.Show(orderPanel);

				focusPanel.Height = orderButton.Height;
				focusPanel.Top = orderButton.Top;

				currentPageLabel.Text = orderButton.Text;
				iconPagePicturBox.Image = Properties.Resources.hookah_512px;
			}
		}
		#endregion /OrderButton_Click

		#region FoodSearchRadioButton_CheckedChanged
		private void FoodSearchRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			FoodSearch = true;
			DrinkSearch = false;
			HookahSearch = false;
		}
		#endregion /FoodSearchRadioButton_CheckedChanged

		#region DrinkSearchRadioButton_CheckedChanged
		private void DrinkSearchRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			FoodSearch = false;
			DrinkSearch = true;
			HookahSearch = false;
		}
		#endregion /DrinkSearchRadioButton_CheckedChanged

		#region HookahSearchRadioButton_CheckedChanged
		private void HookahSearchRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			FoodSearch = false;
			DrinkSearch = false;
			HookahSearch = true;
		}
		#endregion /HookahSearchRadioButton_CheckedChanged

		#region SearchTextBox
		//-----
		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			searchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			searchPanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			searchTextBox.Select(0, 0);
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(searchTextBox.Text, "جستجو...") == 0)
			{
				searchTextBox.Clear();
			}
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_Leave
		private void SearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(searchTextBox.Text, "جستجو...") == 0 || string.IsNullOrWhiteSpace(searchTextBox.Text))
			{
				searchTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				searchPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				Search = null;
				searchTextBox.Text = "جستجو...";
				return;
			}
			else
			{
				searchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				searchPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /SearchTextBox_Leave 

		#region SearchTextBox_TextChanged
		private void SearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text) || string.Compare(searchTextBox.Text, "جستجو...") == 0)
			{
				Search = null;
				return;
			}
			else
			{
				Search = searchTextBox.Text;
				if (HookahSearch == true)
				{
					HookahListSearch(Search);
					return;
				}
				if (DrinkSearch == true)
				{
					DrinkListSearch(Search);
					return;
				}
				if (FoodSearch == true)
				{
					FoodListSearch(text: Search);
					return;
				}
			}
		}
		#endregion /SearchTextBox_TextChanged
		//-----
		#endregion /SearchTextBox

		#region HookahStoreDataGridView_CellDoubleClick
		private void HookahStoreDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DataBaseContext dataBaseContext =
				new Models.DataBaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			NameItem =
				hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (orderDataGridView.Rows.Count > 0)
			{
				for (int i = 0; i < orderDataGridView.Rows.Count; i++)
				{
					if (orderDataGridView.Rows[i].Cells[0].Value.ToString() == NameItem)
					{
						System.Windows.Forms.DialogResult dialogResult =
							Mbb.Windows.Forms.MessageBox.Show
							(text: "آیا سری اضافه می باشد؟",
							caption: "سوال فنی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
							button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.Yes)
						{
							if (string.IsNullOrWhiteSpace(extraHeadTextBox.Text) || string.Compare(extraHeadTextBox.Text, "مبلغ سری اضافه") == 0)
							{
								Mbb.Windows.Forms.MessageBox.Show
									(text: "لطفا مبلغ سری اضافه را وارد نمایید!",
									caption: "درج مبلغ",
									icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
									button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
								return;
							}
							else
							{
								NameItem =
									hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString() + "(سری اضافه)";

								for (int j = 0; j < orderDataGridView.Rows.Count; j++)
								{
									if (orderDataGridView.Rows[j].Cells[0].Value.ToString() == NameItem)
									{
										WarePrice =
											ExtraHead.ToString();

										ObjectPrice =
											int.Parse(WarePrice.Replace(",", string.Empty).Trim());

										orderDataGridView.Rows[j].Cells[1].Value = $"{ExtraHead:#,0} تومان";

										orderDataGridView.Rows[j].Cells[2].Value =
											int.Parse(orderDataGridView.Rows[j].Cells[2].Value.ToString()) + 1;

										SumPriceItem =
											ObjectPrice * int.Parse(orderDataGridView.Rows[j].Cells[2].Value.ToString());

										WarePrice =
											$"{SumPriceItem:#,0} تومان";

										orderDataGridView.Rows[j].Cells[3].Value = WarePrice;

										Number = 1;
										WarePrice =
											ExtraHead.ToString().Replace("تومان", string.Empty).Trim();
										return;
									}
								}
								Number = 1;
								WarePrice =
									$"{ExtraHead:#,0} تومان";

								orderDataGridView.Rows.Add
									(hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString() + "(سری اضافه)",
									$"{ExtraHead:#,0} تومان",
									Number++,
									WarePrice);

								#region EventLog
								EventLog_Username = Program.AuthenticatedUser.Username;
								EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
								EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
								EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
								EventLog_EventTitle = $"تعویض سری برای {NameItem}";

								Infrastructure.Utility.EventLog
									(username: EventLog_Username,
									fullName: EventLog_FullName,
									eventDate: EventLog_EventDate,
									eventTime: EventLog_EventTime,
									eventTitle: EventLog_EventTitle);
								#endregion /EventLog

								return;
							}
						}
						else
						{
							WarePrice =
								hookahStoreDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

							ObjectPrice =
								int.Parse(WarePrice.Replace(",", string.Empty).Trim());

							orderDataGridView.Rows[i].Cells[1].Value =
								hookahStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

							orderDataGridView.Rows[i].Cells[2].Value =
								int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString()) + 1;

							SumPriceItem =
								ObjectPrice * int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());

							WarePrice =
								$"{SumPriceItem:#,0} تومان";

							orderDataGridView.Rows[i].Cells[3].Value = WarePrice;

							#region EventLog
							EventLog_Username = Program.AuthenticatedUser.Username;
							EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
							EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
							EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
							EventLog_EventTitle = $"ثبت قلیان اضافه {NameItem}";

							Infrastructure.Utility.EventLog
								(username: EventLog_Username,
								fullName: EventLog_FullName,
								eventDate: EventLog_EventDate,
								eventTime: EventLog_EventTime,
								eventTitle: EventLog_EventTitle);
							#endregion /EventLog

							return;
						}
					}
				}
				Number = 1;
				WarePrice =
					hookahStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString(),
					hookahStoreDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"انتخاب قلیان {NameItem}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				return;
			}
			else
			{
				Number = 1;
				WarePrice =
					hookahStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(hookahStoreDataGridView.CurrentRow.Cells[0].Value.ToString(),
					hookahStoreDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"انتخاب قلیان {NameItem}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				return;
			}
		}
		#endregion /HookahStoreDataGridView_CellDoubleClick

		#region DrinkStoreDataGridView_CellDoubleClick
		private void DrinkStoreDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DataBaseContext dataBaseContext =
				new Models.DataBaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			NameItem =
				drinkStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (orderDataGridView.Rows.Count > 0)
			{
				for (int i = 0; i < orderDataGridView.Rows.Count; i++)
				{
					if (orderDataGridView.Rows[i].Cells[0].Value.ToString() == NameItem)
					{
						WarePrice =
							drinkStoreDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

						ObjectPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

						orderDataGridView.Rows[i].Cells[1].Value =
							drinkStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

						orderDataGridView.Rows[i].Cells[2].Value =
							int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString()) + 1;

						SumPriceItem =
							ObjectPrice * int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());

						WarePrice =
							$"{SumPriceItem:#,0} تومان";

						orderDataGridView.Rows[i].Cells[3].Value = WarePrice;

						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"انتخاب  مجدد {NameItem}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog

						return;
					}
				}
				Number = 1;
				WarePrice =
					drinkStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(drinkStoreDataGridView.CurrentRow.Cells[0].Value.ToString(),
					drinkStoreDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"انتخاب {NameItem}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				return;
			}
			else
			{
				Number = 1;
				WarePrice =
					drinkStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(drinkStoreDataGridView.CurrentRow.Cells[0].Value.ToString(),
					drinkStoreDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				reduceRequestButton.Enabled = true;

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"انتخاب {NameItem}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				return;
			}
		}
		#endregion /DrinkStoreDataGridView_CellDoubleClick

		#region FoodStoreDataGridView_CellDoubleClick
		private void FoodStoreDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DataBaseContext dataBaseContext =
				new Models.DataBaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			NameItem =
				foodStoreDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (orderDataGridView.Rows.Count > 0)
			{
				for (int i = 0; i < orderDataGridView.Rows.Count; i++)
				{
					if (orderDataGridView.Rows[i].Cells[0].Value.ToString() == NameItem)
					{
						WarePrice =
							foodStoreDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

						ObjectPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

						orderDataGridView.Rows[i].Cells[1].Value =
							foodStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

						orderDataGridView.Rows[i].Cells[2].Value =
							int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString()) + 1;

						SumPriceItem =
							ObjectPrice * int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());

						WarePrice =
							$"{SumPriceItem:#,0} تومان";

						orderDataGridView.Rows[i].Cells[3].Value = WarePrice;

						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"انتخاب مجدد {NameItem}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog

						return;
					}
				}
				Number = 1;
				WarePrice =
					foodStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(foodStoreDataGridView.CurrentRow.Cells[0].Value.ToString(),
					foodStoreDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"انتخاب {NameItem}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				return;
			}
			else
			{
				Number = 1;
				WarePrice =
					foodStoreDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(foodStoreDataGridView.CurrentRow.Cells[0].Value.ToString(),
					foodStoreDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				reduceRequestButton.Enabled = true;

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"انتخاب {NameItem}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				return;
			}
		}
		#endregion /FoodStoreDataGridView_CellDoubleClick

		#region ClientNameTextBox
		//-----ClientNameTextBox
		#region ClientNameTextBox_Enter
		private void ClientNameTextBox_Enter(object sender, EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			clientNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			if (string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
			{
				clientNameTextBox.Clear();
			}
		}
		#endregion /ClientNameTextBox_Enter

		#region ClientNameTextBox_KeyPress
		private void ClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text) || string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
			{
				temporaryRadioButton.Checked = false;
			}
			else
			{
				temporaryRadioButton.Checked = true;
			}

		}
		#endregion /ClientNameTextBox_KeyPress

		#region ClientNameTextBox_Leave
		private void ClientNameTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text) || string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
			{
				temporaryRadioButton.Checked = false;
				clientNameTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				clientNamePanel.BackColor =
					Infrastructure.Utility.BlackColor();

				clientNameTextBox.Text = "نام مشتری";
				ClientName = null;
			}
			else
			{
				clientNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				clientNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				ClientName = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_Leave

		#region ClientNameTextBox_TextChanged
		private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text) || string.Compare(clientNameTextBox.Text, "نام مشتری") == 0)
			{
				temporaryRadioButton.Checked = false;
				return;
			}
			else
			{
				clientNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				clientNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				ClientName = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_TextChanged 
		//-----ClientNameTextBox
		#endregion /ClientNameTextBox

		#region ClientIDTextBox
		//-----
		#region ClientIDTextBox_Enter
		private void ClientIDTextBox_Enter(object sender, EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			clientIDTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientIDPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(clientIDTextBox.Text, "کد مشتری") == 0)
			{
				clientIDTextBox.Clear();
				clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (string.IsNullOrEmpty(ClientID))
			{
				return;
			}
			else if (clientIDTextBox.Text.Contains("-"))
			{
				clientIDTextBox.Text = clientIDTextBox.Text.Replace("-", string.Empty);
			}
		}
		#endregion /ClientIDTextBox_Enter

		#region ClientIDTextBox_KeyPress
		private void ClientIDTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);

			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد مشتری") == 0)
			{
				permanentRadioButton.Checked = false;
			}
			else
			{
				permanentRadioButton.Checked = true;
			}
		}
		#endregion /ClientIDTextBox_KeyPress

		#region ClientIDTextBox_Leave
		private void ClientIDTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد مشتری") == 0)
			{
				permanentRadioButton.Checked = false;
				clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				clientIDTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				clientIDPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				clientIDTextBox.Text = "کد مشتری";
				ClientID = null;
			}
			else
			{
				if (clientIDTextBox.Text.Length < 11)
				{
					return;
				}
				else if (clientIDTextBox.Text.StartsWith("09"))
				{
					clientIDTextBox.ForeColor =
						Infrastructure.Utility.WhiteColor();
					clientIDPanel.BackColor =
						Infrastructure.Utility.WhiteColor();
					clientIDTextBox.Text = clientIDTextBox.Text.Insert(4, "-");

					ClientID = ClientID.Replace("-", string.Empty).Trim();
				}
			}
		}
		#endregion /ClientIDTextBox_Leave

		#region ClientIDTextBox_TextChanged
		private void ClientIDTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد مشتری") == 0)
			{
				permanentRadioButton.Checked = false;
				clientNameTextBox.Text = "نام مشتری";
				clientNameTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				clientNamePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				ClientName = null;
				ClientID = null;
				return;
			}
			else
			{
				clientIDTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				clientIDPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				ClientID = clientIDTextBox.Text;
				FoundedClientID(ClientID);
			}
		}
		#endregion ClientIDTextBox_TextChanged
		//-----
		#endregion /ClientIDTextBox

		#region ExtraHeadTextBox
		//-----
		#region ExtraHeadTextBox_Enter
		private void ExtraHeadTextBox_Enter(object sender, EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			extraHeadTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			extraHeadPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(extraHeadTextBox.Text, "مبلغ سری اضافه") == 0)
			{
				ExtraHead = 0;
				extraHeadTextBox.Text = "0 تومان";
				extraHeadTextBox.Select(0, 1);
				extraHeadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (extraHeadTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /ExtraHeadTextBox_Enter

		#region ExtraHeadTextBox_KeyPress
		private void ExtraHeadTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ExtraHeadTextBox_KeyPress

		#region ExtraHeadTextBox_Leave
		private void ExtraHeadTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(extraHeadTextBox.Text) || string.Compare(extraHeadTextBox.Text, "مبلغ سری اضافه") == 0 || string.Compare(extraHeadTextBox.Text, "0 تومان") == 0 || string.Compare(extraHeadTextBox.Text, " تومان") == 0 || string.Compare(extraHeadTextBox.Text, "تومان") == 0 || string.Compare(extraHeadTextBox.Text, "توما") == 0 || string.Compare(extraHeadTextBox.Text, "توم") == 0 || string.Compare(extraHeadTextBox.Text, "تو") == 0 || string.Compare(extraHeadTextBox.Text, "ت") == 0)
			{
				extraHeadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				extraHeadTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				extraHeadPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				extraHeadTextBox.Text = "مبلغ سری اضافه";
				ExtraHead_String = null;
				ExtraHead = 0;
			}
			else
			{
				extraHeadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				extraHeadTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();

				ExtraHead_String = extraHeadTextBox.Text.Replace("تومان", string.Empty).Trim();
				ExtraHead = int.Parse(ExtraHead_String.Replace(",", string.Empty).Trim());
				extraHeadTextBox.Text = $"{ExtraHead:#,0} تومان";
			}
		}
		#endregion /ExtraHeadTextBox_Leave 
		//-----
		#endregion /ExtraHeadTextBox

		#region OrderDataGridView_CellValueChanged
		private void OrderDataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			string value;
			int newPrice;
			int totalSumPrice = 0;
			if (e.RowIndex >= -1)
			{
				if (orderDataGridView.RowCount >= 1)
				{
					for (int i = 0; i < orderDataGridView.Rows.Count; i++)
					{
						value = orderDataGridView.Rows[i].Cells[3].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					value =
						$"{totalSumPrice:#,0} تومان";
					totalPriceTextBox.Text = value;
				}
				else
				{
					return;
				}
			}
			else
			{
				return;
			}
		}
		#endregion /OrderDataGridView_CellValueChanged

		#region OrderDataGridView_RowsAdded
		private void OrderDataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			string value;
			int newPrice;
			int totalSumPrice = 0;
			if (e.RowIndex != -1)
			{
				if (orderDataGridView.RowCount >= 1)
				{
					for (int i = 0; i < orderDataGridView.Rows.Count; i++)
					{
						value = orderDataGridView.Rows[i].Cells[3].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					value =
						$"{totalSumPrice:#,0} تومان";
					totalPriceTextBox.Text = value;
				}
				else
				{
					return;
				}
			}
			else
			{
				return;
			}
		}
		#endregion /OrderDataGridView_RowsAdded

		#region TotalPrice_TextChanged
		private void TotalPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(totalPriceTextBox.Text) || string.Compare(totalPriceTextBox.Text, "0 تومان") == 0)
			{
				Total_Price_Int = 0;
				saveAndPrintButton.Enabled = false;
				paymentTextBox.Enabled = false;
				newOrderButton.Enabled = false;
				paymentTextBox.Enabled = false;
				reduceRequestButton.Enabled = false;
				Remaining = 0;
				remainingTextBox.Text = $"{Remaining:#,0} تومان";
				debtorRadioButton.Checked = false;
				clearingRadioButton.Checked = false;
				creditorRadioButton.Checked = false;
				return;
			}
			else
			{
				Total_Price_String = totalPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				Total_Price_Int = int.Parse(Total_Price_String.Replace(",", string.Empty).Trim());
				Remaining = Payment - Total_Price_Int;
				remainingTextBox.Text = $"{Remaining:#,0} تومان";
				saveAndPrintButton.Enabled = true;
				paymentTextBox.Enabled = true;
				newOrderButton.Enabled = true;
				paymentTextBox.Enabled = true;
				reduceRequestButton.Enabled = true;
			}
		}
		#endregion /TotalPrice_TextChanged
		//-----دکمه کاهش سفارش
		#region ReduceRequestButton_Click 
		private void ReduceRequestButton_Click(object sender, System.EventArgs e)
		{
			if (orderDataGridView.Rows.Count >= 1)
			{
				int value = int.Parse(orderDataGridView.CurrentRow.Cells[2].Value.ToString());

				if (value <= 1)
				{
					#region Validate
					string totalPrice =
									this.totalPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						orderDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

					int itemTotalPrice =
						int.Parse(totalPrice.Replace(",", string.Empty).Trim());
					int itemPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					orderDataGridView.CurrentRow.Cells[2].Value = value;

					#region EventLog
					EventLog_Username = Program.AuthenticatedUser.Username;
					EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
					EventLog_EventTitle = $"سفارش {orderDataGridView.CurrentRow.Cells[0].Value} حذف گردید!";

					Infrastructure.Utility.EventLog
						(username: EventLog_Username,
						fullName: EventLog_FullName,
						eventDate: EventLog_EventDate,
						eventTime: EventLog_EventTime,
						eventTitle: EventLog_EventTitle);
					#endregion /EventLog

					int SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem:#,0} تومان";

					orderDataGridView.CurrentRow.Cells[3].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.totalPriceTextBox.Text =
							"0 تومان";
					}
					else
					{
						totalPrice =
							$"{itemTotalPrice:#,0} تومان";
						this.totalPriceTextBox.Text = totalPrice;
					}
					#endregion /Validate

					foreach (System.Windows.Forms.DataGridViewRow row in this.orderDataGridView.SelectedRows)
					{
						orderDataGridView.Rows.RemoveAt(row.Index);

						if (orderDataGridView.Rows.Count == 0)
						{
							reduceRequestButton.Enabled = false;
							return;
						}
					}
					return;
				}
				else
				{
					string totalPrice =
						this.totalPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						orderDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

					int itemTotalPrice =
						int.Parse(totalPrice.Replace(",", string.Empty).Trim());
					int itemPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					orderDataGridView.CurrentRow.Cells[2].Value = value;

					#region EventLog
					EventLog_Username = Program.AuthenticatedUser.Username;
					EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
					EventLog_EventTitle = $"کاهش سفارش {orderDataGridView.CurrentRow.Cells[0].Value}";

					Infrastructure.Utility.EventLog
						(username: EventLog_Username,
						fullName: EventLog_FullName,
						eventDate: EventLog_EventDate,
						eventTime: EventLog_EventTime,
						eventTitle: EventLog_EventTitle);
					#endregion /EventLog

					int SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem:#,0} تومان";

					orderDataGridView.CurrentRow.Cells[3].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.totalPriceTextBox.Text =
							"0 تومان";
					}
					else
					{
						totalPrice =
							$"{itemTotalPrice:#,0} تومان";
						this.totalPriceTextBox.Text = totalPrice;
					}
					return;
				}
			}
		}
		#endregion /ReduceRequestButton_Click
		//-----دکمه طلبکار
		#region CreditorRadioButton_CheckedChanged
		private void CreditorRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (creditorRadioButton.Checked == true)
			{
				AccountStatus = null;
				AccountStatus = "طلبکار";
			}
			else
			{
				return;
			}
		}
		#endregion /CreditorRadioButton_CheckedChanged
		//-----دکمه تسویه حساب
		#region ClearingRadioButton_CheckedChanged
		private void ClearingRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (clearingRadioButton.Checked == true)
			{
				AccountStatus = null;
				AccountStatus = "تسویه";
			}
			else
			{
				return;
			}
		}
		#endregion ClearingRadioButton_CheckedChanged
		//----- دکمه بدهکار
		#region DebtorRadioButton_CheckedChanged
		private void DebtorRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (debtorRadioButton.Checked == true)
			{
				AccountStatus = null;
				AccountStatus = "بدهکار";
			}
			else
			{
				return;
			}
		}
		#endregion /DebtorRadioButton_CheckedChanged

		#region PaymentTextBox
		//-----
		#region PaymentTextBox_Enter
		private void PaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			paymentTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(paymentTextBox.Text, "مبلغ پرداختی...") == 0)
			{
				Payment = 0;
				paymentTextBox.Text = "0 تومان";
				paymentTextBox.Select(0, 1);
				paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (paymentTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /PaymentTextBox_Enter

		#region PaymentTextBox_KeyPress
		private void PaymentTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PaymentTextBox_KeyPress

		#region PaymentTextBox_Leave
		private void PaymentTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(paymentTextBox.Text) || string.Compare(paymentTextBox.Text, "مبلغ پرداختی...") == 0 || string.Compare(paymentTextBox.Text, "0 تومان") == 0)
			{
				paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				paymentTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				paymentTextBox.Text = "مبلغ پرداختی...";
				Entry_Payment = null;
				Payment = 0;
			}
			else
			{
				paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				paymentTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();

				Entry_Payment = paymentTextBox.Text.Replace("تومان", string.Empty).Trim();
				Payment = int.Parse(Entry_Payment.Replace(",", string.Empty).Trim());
				paymentTextBox.Text = $"{Payment:#,0} تومان";
			}
		}
		#endregion /PaymentTextBox_Leave

		#region PaymentTextBox_TextChanged
		private void PaymentTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(paymentTextBox.Text) || string.Compare(paymentTextBox.Text, "مبلغ پرداختی...") == 0)
			{
				noPaidRadioButton.Checked = true;
				return;
			}
			else if (string.Compare(paymentTextBox.Text, "تومان") == 0 || string.Compare(paymentTextBox.Text, " تومان") == 0 || string.Compare(paymentTextBox.Text, "توما") == 0 || string.Compare(paymentTextBox.Text, "توم") == 0 || string.Compare(paymentTextBox.Text, "تو") == 0 || string.Compare(paymentTextBox.Text, "ت") == 0)
			{
				noPaidRadioButton.Checked = false;
				Payment = 0;
				Remaining = Payment - Total_Price_Int;
				if (Total_Price_Int == 0)
				{
					remainingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingTextBox.Text = $"0 تومان";
					return;
				}
				else
				{
					remainingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingTextBox.Text = $"{Remaining:#,0} تومان";
				}
				return;
			}
			else if (paymentTextBox.Text.Contains("تومان"))
			{
				noPaidRadioButton.Checked = false;
				Entry_Payment = paymentTextBox.Text.Replace("تومان", string.Empty).Trim();
				Payment = int.Parse(Entry_Payment.Replace(",", string.Empty).Trim());
				Remaining = Payment - Total_Price_Int;

				if (Total_Price_Int == 0)
				{
					remainingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingTextBox.Text = $"0 تومان";
					return;
				}
				else
				{
					remainingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingTextBox.Text = $"{Remaining:#,0} تومان";
				}
				return;
			}
			else
			{
				noPaidRadioButton.Checked = false;
				Entry_Payment = paymentTextBox.Text.Replace("تومان", string.Empty).Trim();
				Payment = int.Parse(Entry_Payment.Replace(",", string.Empty).Trim());
				Remaining = Payment - Total_Price_Int;
				if (Total_Price_Int == 0)
				{
					remainingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingTextBox.Text = $"0 تومان";
					return;
				}
				else
				{
					remainingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingTextBox.Text = $"{Remaining:#,0} تومان";
				}
			}
		}
		#endregion /PaymentTextBox_TextChanged
		//-----
		#endregion /PaymentTextBox
		//-----دکمه مشتری دائم
		#region PermanentRadioButton_CheckedChanged
		private void PermanentRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Temporary = null;
			ClientType = true;
			Permanent = "مشتری دائمی";
		}
		#endregion /PermanentRadioButton_CheckedChanged
		//-----دکمه مشتری موقت
		#region TemporaryRadioButton_CheckedChanged
		private void TemporaryRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Permanent = null;
			ClientType = false;
			Temporary = "مشتری موقت";
		}
		#endregion /TemporaryRadioButton_CheckedChanged

		#region RemainingTextBox_TextChanged
		private void RemainingTextBox_TextChanged(object sender, EventArgs e)
		{
			Remaining_string = remainingTextBox.Text.Replace("تومان", string.Empty).Trim();

			Remaining = int.Parse(Remaining_string.Replace(",", string.Empty).Trim());

			if (Remaining > 0)
			{
				creditorRadioButton.Checked = true;
				clearingRadioButton.Checked = false;
				debtorRadioButton.Checked = false;
			}
			else if (Remaining == 0)
			{
				creditorRadioButton.Checked = false;
				clearingRadioButton.Checked = true;
				debtorRadioButton.Checked = false;
			}
			else if (Remaining < 0)
			{
				creditorRadioButton.Checked = false;
				clearingRadioButton.Checked = false;
				debtorRadioButton.Checked = true;
			}
		}
		#endregion /RemainingTextBox_TextChanged

		#region CashRadioButton_CheckedChanged
		private void CashRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = cashRadioButton.Text;
		}
		#endregion /CashRadioButton_CheckedChanged

		#region CardRadioButton_CheckedChanged
		private void CardRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = cardRadioButton.Text;
		}
		#endregion /CardRadioButton_CheckedChanged

		#region CashAndCardRadioButton_CheckedChanged
		private void CashAndCardRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = cashAndCardRadioButton.Text;
		}
		#endregion /CashAndCardRadioButton_CheckedChanged

		#region NoPaidRadioButton_CheckedChanged
		private void NoPaidRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = noPaidRadioButton.Text;
		}
		#endregion /NoPaidRadioButton_CheckedChanged

		#region SaveAndPrintButton_Click
		private void SaveAndPrintButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ClientID))
			{
				DialogResult dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: "لطفا کد مشتری را وارد کنید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok
					);
				if (dialogResult == DialogResult.OK)
				{
					clientIDTextBox.Focus();
					return;
				}
			}

			if (ClientType == false)//-----اگر نوع مشتری غلط باشد یعنی مشتری موقت میباشد
			{

			}
			else if (ClientType == true)//-----در غیر اگر نوع مشتری غلط باشد یعنی مشتری دائمی میباشد.در غیر این صورت مشتری دائمی است.
			{

				if (ApprovalClientID(ClientID) == false)//-----اگر کد شناسه وارد شده در بانک موجود نباشد هیچ عملی انجام نمیگیرد. در غیر این صورت عملیات ثبت انجام میشود.
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: "کد شناسه مورد نظر در سیستم موجود نمی باشد.\n لطفا مجددا تلاش نمایید!",
						caption: "خطای شناسایی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok
						);
					return;
				}
				else
				{
					if (orderDataGridView.Rows.Count == 0)
					{
						string message = "سفارشی دریافت نگردیده!";
						Mbb.Windows.Forms.MessageBox.Show
							(text: message, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						return;
					}

					if (string.IsNullOrEmpty(ClientID))
					{
						string message = "کد مشتری را وارد نمایید!";
						Mbb.Windows.Forms.MessageBox.Show
							(text: message, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						clientIDTextBox.Focus();
						return;
					}

					if (string.IsNullOrEmpty(Entry_Payment))
					{
						Entry_Payment = "0";
					}

					System.Windows.Forms.DialogResult dialogResult =
							Mbb.Windows.Forms.MessageBox.Show
							(text: "آیا سفارش ثبت گردد؟",
							caption: "ثبت سفارش",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
							button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						OrderDate =
							$"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(dateTime: DateTime.Now)}";

						Models.DataBaseContext dataBaseContext = null;

						try
						{
							int totalPrice, paymentAmount, remainigAmount;
							dataBaseContext =
								new Models.DataBaseContext();

							Models.PermanentClientStatus permanentClientStatus =
								dataBaseContext.PermanentClientStatuses
								.Where(current => string.Compare(current.Client_ID, ClientID) == 0)
								.FirstOrDefault();

							if (permanentClientStatus != null)//---یعنی مشتری موجود است
							{
								totalPrice = int.Parse(permanentClientStatus.Total_Price.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim());
								paymentAmount = int.Parse(permanentClientStatus.Payment_Amount.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim());
								remainigAmount = int.Parse(permanentClientStatus.Remaining_Amount.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim());

								totalPrice += Total_Price_Int;
								paymentAmount += Payment;
								remainigAmount += Remaining;

								if (remainigAmount < 0)
								{
									AccountStatus = "بدهکار";
								}
								else if (remainigAmount == 0)
								{
									AccountStatus = "تسویه";
								}
								else if (remainigAmount > 0)
								{
									AccountStatus = "طلبکار";
								}
								permanentClientStatus.Client_ID = ClientID;
								permanentClientStatus.Client_Name = ClientName;
								permanentClientStatus.Order_Date = OrderDate;
								permanentClientStatus.Total_Price = $"{totalPrice:#,0} تومان";
								permanentClientStatus.Payment_Amount = $"{paymentAmount:#,0} تومان";
								permanentClientStatus.Remaining_Amount = $"{remainigAmount:#,0} تومان";
								permanentClientStatus.Payment_Type = Payment_Type;
								permanentClientStatus.AccountStatus = AccountStatus;
								permanentClientStatus.Date_Settlement = "00:00:00 - 0000/00/00";

								dataBaseContext.SaveChanges();
							}

							else if (permanentClientStatus == null)//---بعنی مشتری موجود نیست
							{
								if (Remaining < 0)
								{
									AccountStatus = "بدهکار";
								}
								else if (Remaining == 0)
								{
									AccountStatus = "تسویه";
								}
								else if (Remaining > 0)
								{
									AccountStatus = "طلبکار";
								}
								permanentClientStatus =
									new PermanentClientStatus
									{
										Client_ID = ClientID,
										Client_Name = ClientName,
										Order_Date = OrderDate,
										Total_Price = $"{Total_Price_String} تومان",
										Payment_Amount = $"{Entry_Payment} تومان",
										Remaining_Amount = $"{Remaining_string} تومان",
										Payment_Type = Payment_Type,
										AccountStatus = AccountStatus,
										Date_Settlement = "00:00:00 - 0000/00/00",
									};
								dataBaseContext.PermanentClientStatuses.Add(permanentClientStatus);
								dataBaseContext.SaveChanges();
							}
						}
						catch (Exception ex1)
						{
							Infrastructure.Utility.ExceptionShow(ex1);
							return;
						}
						finally
						{
							if (dataBaseContext != null)
							{
								dataBaseContext.Dispose();
								dataBaseContext = null;
							}
						}//-----مربوط به ثبت وضعیت حساب مشتری دائم

						//----------------------------------------------------------------------------------------------------

						try
						{
							dataBaseContext =
									new Models.DataBaseContext();

							//NumberVisits(ClientID);
							dataBaseContext =
								new Models.DataBaseContext();

							Models.PermanentClient permanentClient =
								dataBaseContext.PermanentClients
								.Where(current => string.Compare(current.Client_ID, ClientID) == 0)
								.FirstOrDefault();

							NumberVisit = permanentClient.Number_Order;
							NumberVisit++;

							if (permanentClient != null)
							{
								permanentClient.Client_ID = ClientID;
								permanentClient.Full_Name = ClientName;
								permanentClient.Number_Order = NumberVisit;
								permanentClient.Last_Order = OrderDate; // $"{Infrastructure.Utility.ShowTime()} - { Infrastructure.Utility.PersianCalendar(dateTime: DateTime.Now)}";
							}
							dataBaseContext.SaveChanges();
						}
						catch (Exception ex2)
						{
							Infrastructure.Utility.ExceptionShow(ex2);
							return;
						}
						finally
						{
							if (dataBaseContext != null)
							{
								dataBaseContext.Dispose();
								dataBaseContext = null;
							}
						}//-----مربوط به تعداد دفعات رجوع و اخرین رجوع مشتری می باشد.

						//----------------------------------------------------------------------------------------------------

						try
						{
							dataBaseContext =
								new Models.DataBaseContext();

							foreach (DataGridViewRow rows in orderDataGridView.Rows)
							{
								Models.ClientOrder clientOrder =
								new Models.ClientOrder()
								{
									Full_Name = ClientName,
									OrderName = rows.Cells[0].Value.ToString(),
									Price = rows.Cells[1].Value.ToString(),
									Number = int.Parse(rows.Cells[2].Value.ToString()),
									SumPrice = rows.Cells[3].Value.ToString(),
									OderDate = OrderDate,
									Register_Date = $"{Infrastructure.Utility.PersianCalendar(dateTime: DateTime.Now)}",
									Register_Time = $"{Infrastructure.Utility.ShowTime()}",
								};
								dataBaseContext.ClientOrders.Add(clientOrder);
								dataBaseContext.SaveChanges();
							}
						}
						catch (Exception ex3)
						{
							Infrastructure.Utility.ExceptionShow(ex3);
							return;
						}
						finally
						{
							if (dataBaseContext != null)
							{
								dataBaseContext.Dispose();
								dataBaseContext = null;
							}
						}//-----مربوط به ثبت سفارشات

						//----------------------------------------------------------------------------------------------------

						try
						{
							System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

							int year = persianCalendar.GetYear(DateTime.Now);
							int month = persianCalendar.GetMonth(DateTime.Now);
							int day = persianCalendar.GetDayOfMonth(DateTime.Now);

							int hour = persianCalendar.GetHour(DateTime.Now);
							int minute = persianCalendar.GetMinute(DateTime.Now);
							int second = persianCalendar.GetSecond(DateTime.Now);

							string date = Infrastructure.Utility.PersianCalendar(dateTime: DateTime.Now);
							string time = Infrastructure.Utility.ShowTime();

							dataBaseContext =
								new Models.DataBaseContext();

							Models.Financial financial =
									dataBaseContext.Financials
									.OrderBy(current => current.Order_Date)
									.FirstOrDefault();

							financial =
							   new Models.Financial()
							   {
								   Client_ID = ClientID,
								   Total_Price = $"{Total_Price_String.Replace(",", string.Empty).Trim()}",
								   Payment_Amount = $"{Entry_Payment.Replace(",", string.Empty).Trim()}",
								   Remaining_Amount = $"{Remaining_string.Replace(",", string.Empty).Trim()}",
								   Payment_Type = Payment_Type,
								   Order_Date = OrderDate,
								   Register_Date = date,
								   Date_Settlement = "00:00:00 - 0000/00/00",
							   };
							dataBaseContext.Financials.Add(financial);
							dataBaseContext.SaveChanges();

							//CalculateDayFinancial();//-----جمع حساب ها در پایان هر روز
						}
						catch (Exception ex4)
						{
							Infrastructure.Utility.ExceptionShow(ex4);
						}
						finally
						{
							if (dataBaseContext != null)
							{
								dataBaseContext.Dispose();
								dataBaseContext = null;
							}
						}//-----مربوط به وضعیت مالی

						//----------------------------------------------------------------------------------------------------

						Mbb.Windows.Forms.MessageBox.Show
							(text: "سفارش با موفقیت ثبت گردید.",
							caption: "ثبت سفارش",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"ثبت سفارش {ClientName}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog
					}
					else
					{
						return;
					}

					System.Windows.Forms.DialogResult dialogResultPrint =
					Mbb.Windows.Forms.MessageBox.Show
					(text: "آیا نسخه چاپی نیاز دارید؟",
					caption: "چاپ سفارش",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);
					if (dialogResultPrint == DialogResult.Yes)
					{
						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"صدور فیش {ClientName}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog

						List<ClientOrderList> lists = new List<ClientOrderList>();

						foreach (DataGridViewRow rows in orderDataGridView.Rows)
						{
							ClientOrderList clientOrderList = new ClientOrderList
							{
								OrderName = rows.Cells[0].Value.ToString(),
								Price = rows.Cells[1].Value.ToString(),
								Number = int.Parse(rows.Cells[2].Value.ToString()),
								SumPrice = rows.Cells[3].Value.ToString(),
							};
							lists.Add(clientOrderList);
						}

						if (string.IsNullOrEmpty(Entry_Payment))
						{
							Entry_Payment = "0";
						}

						string orderDate = OrderDate;
						StiReport clientOrderReport = new StiReport();

						clientOrderReport.Load("Order.mrt");
						clientOrderReport.RegBusinessObject("ClientOrder", lists);

						(clientOrderReport.GetComponentByName("clientNameTextBox") as StiText).Text = ClientName;
						(clientOrderReport.GetComponentByName("orderDateTextBox") as StiText).Text = orderDate;
						(clientOrderReport.GetComponentByName("totalSumPriceTextBox") as StiText).Text = Total_Price_String + " تومان";
						(clientOrderReport.GetComponentByName("amountPaymentTextBox") as StiText).Text = Entry_Payment + " تومان";
						(clientOrderReport.GetComponentByName("amountRemainingTextBox") as StiText).Text = Remaining_string + " تومان";

						clientOrderReport.Show(true);
					}

					NewOrder();
				}
			}
		}
		#endregion /SaveAndPrintButton_Click

		#region NewOrderButton_Click
		private void NewOrderButton_Click(object sender, EventArgs e)
		{
			NewOrder();
		}
		#endregion /NewOrderButton_Click
		//-----
		#endregion /ORDER

		#region STORE
		//-----
		#region StoreButton_Click
		private void StoreButton_Click(object sender, System.EventArgs e)
		{
			if (Store == true)
			{
				return;//---برای اینکه کامپوننت menuTransation مجدد کار نکند.
			}
			else
			{
				Order = false;
				Store = true;
				Report = false;
				Setting = false;

				orderPanel.Visible = false;
				storePanel.Visible = false;
				reportPanel.Visible = false;
				settingPanel.Visible = false;

				this.mainPanel.Controls.Clear();
				this.mainPanel.Controls.Add(storePanel);
				showPageTransition2.Show(storePanel);

				focusPanel.Height = storeButton.Height;
				focusPanel.Top = storeButton.Top;

				currentPageLabel.Text = storeButton.Text;
				iconPagePicturBox.Image = Properties.Resources.warehouse_512px;
			}
		}
		#endregion /StoreButton_Click

		#region HOOKAH_STORE
		//-----
		#region HookahAddButton_Click
		private void HookahAddButton_Click(object sender, System.EventArgs e)
		{
			selectHookahStorBunifuElipse.TargetControl = hookahPanel;
			hookahPanel.BringToFront();
			drinkPanel.SendToBack();
			foodPanel.SendToBack();
		}
		#endregion /HookahAddButton_Click

		#region HookahNameTextBox
		//-----HookahNameTextBox
		#region HookahNameTextBox_Enter
		private void HookahNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			hookahNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(hookahNameTextBox.Text, "نام قلیان") == 0)
			{
				hookahNameTextBox.Clear();
			}
		}
		#endregion /HookahNameTextBox_Enter

		#region HookahNameTextBox_KeyPress
		private void HookahNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /HookahNameTextBox_KeyPress

		#region HookahNameTextBox_Leave
		private void HookahNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hookahNameTextBox.Text) || string.Compare(hookahNameTextBox.Text, "نام قلیان") == 0)
			{
				hookahNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				hookahNamePanel.BackColor =
					Infrastructure.Utility.GrayColor();

				hookahNameTextBox.Text = "نام قلیان";
				HookahName = null;
			}
			else
			{
				hookahNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				hookahNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				HookahName = hookahNameTextBox.Text;
			}
		}
		#endregion /HookahNameTextBox_Leave 
		//-----HookahNameTextBox
		#endregion /HookahNameTextBox

		#region  HookahPriceTextBox
		//-----
		#region HookahPriceTextBox_Enter
		private void HookahPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			hookahPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahPricePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(hookahPriceTextBox.Text, "قیمت") == 0)
			{
				hookahPriceTextBox.Text = "0 تومان";
				hookahPriceTextBox.Select(0, 1);
				return;
			}
		}
		#endregion /HookahPriceTextBox_Enter

		#region HookahPriceTextBox_KeyPress
		private void HookahPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /HookahPriceTextBox_KeyPress

		#region HookahPriceTextBox_Leave
		private void HookahPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hookahPriceTextBox.Text) || string.Compare(hookahPriceTextBox.Text, "قیمت") == 0 || string.Compare(hookahPriceTextBox.Text, "0 تومان") == 0)
			{
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				hookahPriceTextBox.Text = "قیمت";
				HookahPrice = 0;
			}
			else if (string.Compare(hookahPriceTextBox.Text, " تومان") == 0 || string.Compare(hookahPriceTextBox.Text, "تومان") == 0 || string.Compare(hookahPriceTextBox.Text, "توما") == 0 || string.Compare(hookahPriceTextBox.Text, "توم") == 0 || string.Compare(hookahPriceTextBox.Text, "تو") == 0 || string.Compare(hookahPriceTextBox.Text, "ت") == 0)
			{
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				hookahPriceTextBox.Text = "قیمت";
				HookahPrice = 0;
			}
			else
			{
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				HookahPrice_String = hookahPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				HookahPrice = int.Parse(HookahPrice_String.Replace(",", string.Empty).Trim());
				hookahPriceTextBox.Text = $"{HookahPrice:#,0} تومان";
				HookahPrice_String = hookahPriceTextBox.Text;
			}
		}
		#endregion /HookahPriceTextBox_Leave
		//-----
		#endregion / HookahPriceTextBox

		#region HookahDescriptionTextBox
		//-----
		#region HookahDescriptionTextBox_Enter
		private void HookahDescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			hookahDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahDescriptionPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(hookahDescriptionTextBox.Text, "توضیحات") == 0)
			{
				hookahDescriptionTextBox.Clear();
			}
		}
		#endregion /HookahDescriptionTextBox_Enter

		#region HookahDescriptionTextBox_KeyPress
		private void HookahDescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /HookahDescriptionTextBox_KeyPress

		#region HookahDescriptionTextBox_Leave
		private void HookahDescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hookahDescriptionTextBox.Text) || string.Compare(hookahDescriptionTextBox.Text, "توضیحات") == 0)
			{
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				HookahDescription = hookahDescriptionTextBox.Text = "توضیحات";
				//HookahDescription = "توضیحات";
			}
			else
			{
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				HookahDescription = hookahDescriptionTextBox.Text;
			}
		}
		#endregion /HookahDescriptionTextBox_Leave
		//-----
		#endregion /HookahDescriptionTextBox

		#region DeleteHookahImageButton_Click
		private void DeleteHookahImageButton_Click(object sender, EventArgs e)
		{
			HookahImage = string.Empty;
			userImagePicturBox.BackgroundImage =
				Properties.Resources.hookah_512px;
			deleteHookahImageButton.Visible = false;
		}
		#endregion /DeleteHookahImageButton_Click

		#region HookahImagePicturBox_MouseDoubleClick
		private void HookahImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				HookahImage = openFileDialog.FileName;
				userImagePicturBox.BackgroundImage =
				System.Drawing.Image.FromFile(HookahImage);
			}
			if (HookahImage != string.Empty)
			{
				deleteHookahImageButton.Visible = true;
			}
			else
			{
				deleteHookahImageButton.Visible = false;
			}
		}
		#endregion /HookahImagePicturBox_MouseDoubleClick

		#region HookahSaveButton_Click
		private void HookahSaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string errorMessage = string.Empty;

				#region Validation
				//-----
				if (string.IsNullOrWhiteSpace(hookahNameTextBox.Text) || string.Compare(hookahNameTextBox.Text, "نام قلیان") == 0)
				{
					errorMessage = "فیلد قلیان تکمیل گردد!";
				}
				if (string.IsNullOrWhiteSpace(hookahPriceTextBox.Text) || string.Compare(hookahPriceTextBox.Text, "قیمت") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"فیلد مبلغ تکمیل گردد!";
				}
				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(hookahNameTextBox.Text) ||
							string.Compare(hookahNameTextBox.Text, "نام قلیان") == 0)
					{
						hookahNameTextBox.Focus();
						hookahNameTextBox.Clear();
					}
					else if (string.IsNullOrWhiteSpace(hookahPriceTextBox.Text) || string.Compare(hookahPriceTextBox.Text, "قیمت") == 0)
					{
						hookahPriceTextBox.Focus();
						hookahPriceTextBox.Text = "0 تومان";
					}
					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage, caption: "تکمیل اطلاعات", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				if (string.IsNullOrEmpty(HookahImage))
				{
					HookahImage =
						"D:\\Visual Studio Project\\Personal Project\\HOOKAH_SALON\\HOOKAH_SALON\\Resources\\hookah_512px.png";
				}
				//-----
				#endregion /Validation

				if (string.IsNullOrEmpty(HookahDescription))
				{
					HookahDescription = "توضیحات ندارد";
				}

				errorMessage = string.Empty;
				System.Windows.Forms.DialogResult dialogResult;
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: $"{HookahName} ثبت گردد؟", caption: "ذخیره کالا", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Hookah hookah =
					dataBaseContext.Hookahs
					.Where(current => string.Compare(current.HookahName, HookahName, false) == 0)
					.FirstOrDefault();
					if (hookah != null)
					{
						errorMessage =
							$"{HookahName} در سیستم موجود است!";

						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "کالای تکراری", icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						hookahNameTextBox.Focus();
						hookahNameTextBox.SelectAll();
						return;
					}
					else
					{
						HookahRegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						HookahRegisterTime = Infrastructure.Utility.ShowTime();
						HookahUpdateTime = "00:00:00 - 0000/00/00";
						HookahNumberUpdate = 0;
						if (string.IsNullOrEmpty(HookahDescription))
						{
							HookahDescription = "توضیحات";
						}
						hookah =
							new Models.Hookah
							{
								HookahName = HookahName,
								HookahPrice = HookahPrice_String,
								HookahDescription = HookahDescription,
								HookahImage = System.IO.File.ReadAllBytes(HookahImage),
								RegisterTime = $"{HookahRegisterTime} - {HookahRegisterDate}",
								UpdateTime = HookahUpdateTime,
								NumberUpdate = HookahNumberUpdate,
							};
						dataBaseContext.Hookahs.Add(hookah);
						dataBaseContext.SaveChanges();

						//-----جهت بارگذاری اطلاعات قلیان در جدول داده 
						if (HOOKAH_SALON.MainForm.HookahStoreForm != null)
						{
							HOOKAH_SALON.MainForm.HookahStoreForm.HookahLoader();
						}

						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"ثبت {HookahName}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog

						string message =
							$"{HookahName} ثبت گردید.";

						Infrastructure.Utility.WindowsNotification
							(message: message,
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
							picture: HookahImage);
						AllClearHookah();
					}
				}
				else
				{
					return;
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
		#endregion /HookahSaveButton_Click

		#region HookahResetButton_Click
		private void HookahResetButton_Click(object sender, System.EventArgs e)
		{
			AllClearHookah();
		}
		#endregion /HookahResetButton_Click

		#region InventoryHookahButton_Click
		private void InventoryHookahButton_Click(object sender, EventArgs e)
		{
			HookahStoreForm.ShowDialog();
		}
		#endregion /InventoryHookahButton_Click
		//-----
		#endregion /HOOKAH_STORE

		#region DRINK_STORE
		//-----
		#region DrinkAddButton_Click
		private void DrinkAddButton_Click(object sender, System.EventArgs e)
		{
			selectHookahStorBunifuElipse.TargetControl = drinkPanel;
			hookahPanel.SendToBack();
			drinkPanel.BringToFront();
			foodPanel.SendToBack();
		}
		#endregion /DrinkAddButton_Click

		#region DrinkNameTextBox
		//-----DrinkNameTextBox
		#region DrinkNameTextBox_Enter
		private void DrinkNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			drinkNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
			{
				drinkNameTextBox.Clear();
			}
		}
		#endregion /DrinkNameTextBox_Enter

		#region DrinkNameTextBox_KeyPress
		private void DrinkNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /DrinkNameTextBox_KeyPress

		#region DrinkNameTextBox_Leave
		private void DrinkNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) || string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
			{
				drinkNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				drinkNamePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				drinkNameTextBox.Text = "نام نوشیدنی";
				DrinkName = null;
			}
			else
			{
				drinkNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				drinkNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				DrinkName = drinkNameTextBox.Text;

			}
		}
		#endregion /DrinkNameTextBox_Leave
		//-----DrinkNameTextBox
		#endregion /DrinkNameTextBox

		#region DrinkPriceTextBox
		//-----
		#region DrinkPriceTextBox_Enter
		private void DrinkPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkPriceTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			drinkPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			drinkPricePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(drinkPriceTextBox.Text, "قیمت") == 0)
			{
				drinkPriceTextBox.Text = "0 تومان";
				drinkPriceTextBox.Select(0, 1);
				return;
			}
		}

		#endregion /DrinkPriceTextBox_Enter

		#region DrinkPriceTextBox_KeyPress
		private void DrinkPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /DrinkPriceTextBox_KeyPress

		#region DrinkPriceTextBox_Leave
		private void DrinkPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) || string.Compare(drinkPriceTextBox.Text, "قیمت") == 0 || string.Compare(drinkPriceTextBox.Text, "0 تومان") == 0)
			{
				drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				drinkPriceTextBox.Text = "قیمت";
				DrinkPrice = 0;
			}
			else if (string.Compare(drinkPriceTextBox.Text, " تومان") == 0 || string.Compare(drinkPriceTextBox.Text, "تومان") == 0 || string.Compare(drinkPriceTextBox.Text, "توما") == 0 || string.Compare(drinkPriceTextBox.Text, "توم") == 0 || string.Compare(drinkPriceTextBox.Text, "تو") == 0 || string.Compare(drinkPriceTextBox.Text, "ت") == 0)
			{
				drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				drinkPriceTextBox.Text = "قیمت";
				DrinkPrice = 0;
			}
			else
			{
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				DrinkPrice_String = drinkPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				DrinkPrice = int.Parse(DrinkPrice_String.Replace(",", string.Empty).Trim());
				drinkPriceTextBox.Text = $"{DrinkPrice:#,0} تومان";
				DrinkPrice_String = drinkPriceTextBox.Text;
			}
		}
		#endregion /DrinkPriceTextBox_Leave	
		//-----
		#endregion /DrinkPriceTextBox

		#region DescriptionTextBox
		//-----DescriptionTextBox
		#region DrinkDescriptionTextBox_Enter
		private void DrinkDescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(drinkDescriptionTextBox.Text, "توضیحات") == 0)
			{
				drinkDescriptionTextBox.Clear();
			}
		}
		#endregion /DrinkDescriptionTextBox_Enter

		#region DrinkDescriptionTextBox_KeyPress
		private void DrinkDescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DrinkDescriptionTextBox_KeyPress

		#region DrinkDescriptionTextBox_Leave
		private void DrinkDescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkDescriptionTextBox.Text) || string.Compare(drinkDescriptionTextBox.Text, "توضیحات") == 0)
			{
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				DrinkDescription = drinkDescriptionTextBox.Text = "توضیحات";
				//DrinkDescription = "توضیحات"; ;
			}
			else
			{
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				DrinkDescription = drinkDescriptionTextBox.Text;

			}
		}

		#endregion /DrinkDescriptionTextBox_Leave
		//-----DescriptionTextBox
		#endregion /DescriptionTextBox

		#region DeleteDrinkImageButton_Click
		private void DeleteDrinkImageButton_Click(object sender, EventArgs e)
		{
			DrinkImage = null;
			drinkImagePicturBox.BackgroundImage =
				Properties.Resources.pizza_food_512px;
			deleteFoodImageButton.Visible = false;
		}
		#endregion /DeleteDrinkImageButton_Click

		#region DrinkImagePicturBox_MouseDoubleClick
		private void DrinkImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPEP (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				DrinkImage = openFileDialog.FileName;

				drinkImagePicturBox.Image = System.Drawing.Image.FromFile(DrinkImage);
			}
		}
		#endregion /DrinkImagePicturBox_MouseDoubleClick

		#region DrinkSaveButton_Click
		private void DrinkSaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				#region Validation
				//-----
				if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) ||
							string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
				{
					errorMessage = "فیلد نام نوشیدنی تکمیل گردد!";
				}
				if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) ||
					string.Compare(drinkPriceTextBox.Text, "قیمت") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"فیلد مبلغ تکمیل گردد!";
				}
				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) ||
							string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
					{
						drinkNameTextBox.Focus();
						drinkNameTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) ||
						string.Compare(drinkPriceTextBox.Text, "قیمت") == 0)
					{
						drinkPriceTextBox.Focus();
						drinkPriceTextBox.Text = "0 تومان";
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage, caption: "تکمیل اطلاعات", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				if (string.IsNullOrEmpty(DrinkImage))
				{
					DrinkImage =
						"D:\\Visual Studio Project\\Personal Project\\HOOKAH_SALON\\HOOKAH_SALON\\Resources\\drink_512.png";
				}
				//-----
				#endregion /Validation

				if (string.IsNullOrEmpty(DrinkDescription))
				{
					DrinkDescription = "توضیحات ندارد";
				}

				errorMessage = string.Empty;
				System.Windows.Forms.DialogResult dialogResult;
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: $"{DrinkName} ثبت گردد؟", caption: "ذخیره کالا", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Drink drink =
					dataBaseContext.Drinks
					.Where(current => string.Compare(current.DrinkName, DrinkName, false) == 0)
					.FirstOrDefault();

					if (drink != null)
					{
						errorMessage =
							$"{DrinkName} در سیستم موجود است!";

						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "کالای تکراری", icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						drinkNameTextBox.Focus();
						drinkNameTextBox.SelectAll();
						return;
					}
					else
					{
						DrinkRegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						DrinkRegisterTime = Infrastructure.Utility.ShowTime();
						DrinkUpdateTime = "00:00:00 - 0000/00/00";
						DrinkNumberUpdate = 0;
						if (string.IsNullOrEmpty(DrinkDescription))
						{
							DrinkDescription = "توضیحات";
						}
						drink =
							new Models.Drink
							{
								DrinkName = DrinkName,
								DrinkPrice = DrinkPrice_String,
								DrinkDescription = DrinkDescription,
								DrinkImage = System.IO.File.ReadAllBytes(DrinkImage),
								RegisterTime = $"{DrinkRegisterTime} - {DrinkRegisterDate}",
								UpdateTime = DrinkUpdateTime,
								NumberUpdate = DrinkNumberUpdate,
							};
						dataBaseContext.Drinks.Add(drink);
						dataBaseContext.SaveChanges();

						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"ثبت  {DrinkName}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog

						string message =
							$"{DrinkName} ثبت گردید.";

						Infrastructure.Utility.WindowsNotification
							(message: message,
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
							picture: DrinkImage);

						AllClearDrink();
					}
				}
				else
				{
					return;
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
		#endregion /DrinkSaveButton_Click

		#region DrinkResetButton_Click
		private void DrinkResetButton_Click(object sender, System.EventArgs e)
		{
			AllClearDrink();
		}
		#endregion /DrinkResetButton_Click

		#region InventoryDrinkButton_Click
		private void InventoryDrinkButton_Click(object sender, EventArgs e)
		{
			DrinkStoreForm.ShowDialog();
		}
		#endregion /InventoryDrinkButton_Click
		//-----
		#endregion /DRINK_STORE

		#region FOOD_STORE
		//-----
		#region FoodAddButton_Click
		private void FoodAddButton_Click(object sender, System.EventArgs e)
		{
			selectHookahStorBunifuElipse.TargetControl = foodPanel;
			hookahPanel.SendToBack();
			drinkPanel.SendToBack();
			foodPanel.BringToFront();
		}
		#endregion /FoodAddButton_Click

		#region FoodNameTextBox
		//-----
		#region FoodNameTextBox_Enter
		private void FoodNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			foodNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			foodNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
			{
				foodNameTextBox.Clear();
				return;
			}
		}
		#endregion /FoodNameTextBox_Enter

		#region FoodNameTextBox_KeyPress
		private void FoodNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /FoodNameTextBox_KeyPress

		#region FoodNameTextBox_Leave
		private void FoodNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) || string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
			{
				foodNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				foodNamePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				foodNameTextBox.Text = "نام غذا";
				FoodName = null;
				return;
			}
			else
			{
				foodNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				foodNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				FoodName = foodNameTextBox.Text;
			}
		}
		#endregion /FoodNameTextBox_Leave
		//-----
		#endregion /FoodNameTextBox

		#region FoodPriceTextBox
		//-----
		#region FoodPriceTextBox_Enter
		private void FoodPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			foodPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			foodPricePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(foodPriceTextBox.Text, "قیمت") == 0)
			{
				foodPriceTextBox.Text = "0 تومان";
				foodPriceTextBox.Select(0, 1);
				return;
			}
		}
		#endregion /FoodPriceTextBox_Enter

		#region FoodPriceTextBox_KeyPress
		private void FoodPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /FoodPriceTextBox_KeyPress

		#region FoodPriceTextBox_Leave
		private void FoodPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) || string.Compare(foodPriceTextBox.Text, "قیمت") == 0 || string.Compare(foodPriceTextBox.Text, "0 تومان") == 0)
			{
				foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				foodPriceTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				foodPriceTextBox.Text = "قیمت";
				FoodPrice = 0;
				return;
			}
			else if (string.Compare(foodPriceTextBox.Text, " تومان") == 0 || string.Compare(foodPriceTextBox.Text, "تومان") == 0 || string.Compare(foodPriceTextBox.Text, "توما") == 0 || string.Compare(foodPriceTextBox.Text, "توم") == 0 || string.Compare(foodPriceTextBox.Text, "تو") == 0 || string.Compare(foodPriceTextBox.Text, "ت") == 0)
			{
				foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				foodPriceTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				foodPriceTextBox.Text = "قیمت";
				FoodPrice = 0;
				return;
			}
			else
			{
				foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				foodPriceTextBox.ForeColor =
				   Infrastructure.Utility.WhiteColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				FoodPrice_String = foodPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				FoodPrice = int.Parse(FoodPrice_String.Replace(",", string.Empty).Trim());
				foodPriceTextBox.Text = $"{FoodPrice:#,0} تومان";
				FoodPrice_String = foodPriceTextBox.Text;
			}
		}
		#endregion /FoodPriceTextBox_Leave
		//-----
		#endregion /FoodPriceTextBox

		#region DescriptionTextBox
		//-----DescriptionTextBox
		#region FoodDescriptionTextBox_Enter
		private void FoodDescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			foodDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			foodDescriptionPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(foodDescriptionTextBox.Text, "توضیحات") == 0)
			{
				foodDescriptionTextBox.Clear();
				return;
			}
		}
		#endregion /FoodDescriptionTextBox_Enter

		#region FoodDescriptionTextBox_KeyPress
		private void FoodDescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /FoodDescriptionTextBox_KeyPress

		#region FoodDescriptionTextBox_Leave
		private void FoodDescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodDescriptionTextBox.Text) || string.Compare(foodDescriptionTextBox.Text, "توضیحات") == 0)
			{
				foodDescriptionTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				FoodDescription = foodDescriptionTextBox.Text = "توضیحات";
				//FoodDescription = "توضیحات"; ;
			}
			else
			{
				foodDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				FoodDescription = foodDescriptionTextBox.Text;
			}
		}
		#endregion /FoodDescriptionTextBox_Leave
		//-----DescriptionTextBox
		#endregion /DescriptionTextBox

		#region DeleteFoodImageButton_Click
		private void DeleteFoodImageButton_Click(object sender, EventArgs e)
		{
			FoodImage = null;
			foodImagePicturBox.BackgroundImage =
				Properties.Resources.pizza_food_512px;
			deleteFoodImageButton.Visible = false;
		}
		#endregion /DeleteFoodImageButton_Click

		#region FoodImagePicturBox_MouseDoubleClick
		private void FoodImagePictureBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPEP (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				FoodImage = openFileDialog.FileName;
				foodImagePicturBox.Image = System.Drawing.Image.FromFile(FoodImage);
			}
		}
		#endregion /FoodImagePicturBox_MouseDoubleClick

		#region FoodSaveButton_Click
		private void FoodSaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string errorMessage = string.Empty;

				#region Validation
				//-----
				if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) ||
							string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
				{
					errorMessage = "فیلد نام غذا تکمیل گردد!";
				}

				if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) ||
					string.Compare(foodPriceTextBox.Text, "قیمت") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"فیلد مبلغ تکمیل گردد!";
				}

				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) ||
							string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
					{
						foodNameTextBox.Focus();
						foodNameTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) ||
						string.Compare(foodPriceTextBox.Text, "قیمت") == 0)
					{
						foodPriceTextBox.Focus();
						foodPriceTextBox.Text = "0 تومان";
					}
					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage, caption: "تکمیل اطلاعات", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				if (string.IsNullOrEmpty(FoodImage))
				{
					FoodImage =
						"D:\\Visual Studio Project\\Personal Project\\HOOKAH_SALON\\HOOKAH_SALON\\Resources\\pizza_food_512px.png";
				}
				//-----
				#endregion /Validation

				if (string.IsNullOrEmpty(FoodDescription))
				{
					FoodDescription = "توضیحات ندارد";
				}

				errorMessage = string.Empty;
				System.Windows.Forms.DialogResult dialogResult;
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: $"{FoodName} ثبت گردد؟", caption: "ذخیره کالا", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Food food =
					dataBaseContext.Foods
					.Where(current => string.Compare(current.FoodName, FoodName, false) == 0)
					.FirstOrDefault();

					if (food != null)
					{
						errorMessage =
							$"{FoodName} در سیستم موجود است!";

						Mbb.Windows.Forms.MessageBox.Show
							(text: errorMessage, caption: "کالای تکراری", icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						foodNameTextBox.Focus();
						foodNameTextBox.SelectAll();
						return;
					}
					else
					{
						FoodRegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						FoodRegisterTime = Infrastructure.Utility.ShowTime();
						FoodUpdateTime = "00:00:00 - 0000/00/00";
						FoodNumberUpdate = 0;
						if (string.IsNullOrEmpty(FoodDescription))
						{
							FoodDescription = "توضیحات";
						}
						food =
							new Models.Food
							{
								FoodName = FoodName,
								FoodPrice = FoodPrice_String,
								FoodDescription = FoodDescription,
								FoodImage = System.IO.File.ReadAllBytes(FoodImage),
								RegisterTime = $"{FoodRegisterTime} - {FoodRegisterDate}",
								UpdateTime = FoodUpdateTime,
								NumberUpdate = FoodNumberUpdate,
							};
						dataBaseContext.Foods.Add(food);
						dataBaseContext.SaveChanges();

						#region EventLog
						EventLog_Username = Program.AuthenticatedUser.Username;
						EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventLog_EventTitle = $"ثبت {FoodName}";

						Infrastructure.Utility.EventLog
							(username: EventLog_Username,
							fullName: EventLog_FullName,
							eventDate: EventLog_EventDate,
							eventTime: EventLog_EventTime,
							eventTitle: EventLog_EventTitle);
						#endregion /EventLog

						string message =
							$"{FoodName} ثبت گردید.";

						Infrastructure.Utility.WindowsNotification
							(message: message,
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
							picture: FoodImage);

						AllClearFood();
					}
				}
				else
				{
					return;
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
		#endregion /FoodSaveButton_Click

		#region FoodResetButton_Click
		private void FoodResetButton_Click(object sender, System.EventArgs e)
		{
			AllClearFood();
		}
		#endregion /FoodResetButton_Click

		#region InventoryFoodButton_Click
		private void InventoryFoodButton_Click(object sender, EventArgs e)
		{
			FoodStoreFrom.ShowDialog();
		}
		#endregion /InventoryFoodButton_Click
		//-----
		#endregion /FOOD_STORE
		//-----
		#endregion /STORE

		#region REPORT
		//-----
		#region ReportButton_Click
		private void ReportButton_Click(object sender, System.EventArgs e)
		{
			if (Report == true)
			{
				return;//---برای اینکه کامپوننت menuTransation مجدد کار نکند.
			}
			else
			{
				Order = false;
				Store = false;
				Report = true;
				Setting = false;

				orderPanel.Visible = false;
				storePanel.Visible = false;
				reportPanel.Visible = false;
				settingPanel.Visible = false;

				this.mainPanel.Controls.Clear();
				this.mainPanel.Controls.Add(reportPanel);
				showPageTransition1.Show(reportPanel);

				focusPanel.Height = reportButton.Height;
				focusPanel.Top = reportButton.Top;

				HOOKAH_SALON.Report.FinancialStatusForm financialStatusForm =
					new Report.FinancialStatusForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

				showSelectReportPanel.Controls.Clear();
				showSelectReportPanel.Controls.Add(financialStatusForm);
				financialStatusForm.Show();

				currentPageLabel.Text = reportButton.Text;
				iconPagePicturBox.Image = Properties.Resources.order_document_512;
			}
		}
		#endregion /ReportButton_Click

		#region FinancialStatusButton_Click
		private void FinancialStatusButton_Click(object sender, EventArgs e)
		{
			HOOKAH_SALON.Report.FinancialStatusForm financialStatusForm = 
				new Report.FinancialStatusForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

			showSelectReportPanel.Controls.Clear();
			showSelectReportPanel.Controls.Add(financialStatusForm);
			financialStatusForm.Show();
		}
		#endregion /FinancialStatusButton_Click

		#region ClientAccountStatusButton_Click
		private void ClientAccountStatusButton_Click(object sender, EventArgs e)
		{
			HOOKAH_SALON.Report.ClientAccountStatusForm clientAccountStatusForm =
				new Report.ClientAccountStatusForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

			showSelectReportPanel.Controls.Clear();
			showSelectReportPanel.Controls.Add(clientAccountStatusForm);
			clientAccountStatusForm.Show();
		}
		#endregion /ClientAccountStatusButton_Click
		//-----
		#endregion /REPORT

		#region SETTING
		//-----
		#region SettingButton_Click
		private void SettingButton_Click(object sender, EventArgs e)
		{
			if (Setting == true)
			{
				return;//---برای اینکه کامپوننت menuTransation مجدد کار نکند.
			}
			else
			{
				selectSettingPanel.Controls.Clear();
				Order = false;
				Store = false;
				Report = false;
				Setting = true;

				orderPanel.Visible = false;
				storePanel.Visible = false;
				reportPanel.Visible = false;
				settingPanel.Visible = false;

				this.mainPanel.Controls.Clear();
				this.mainPanel.Controls.Add(settingPanel);
				showPageTransition2.Show(settingPanel);

				focusPanel.Height = settingButton.Height;
				focusPanel.Top = settingButton.Top;

				currentPageLabel.Text = settingButton.Text;
				iconPagePicturBox.Image = Properties.Resources.settings_512px;
			}
		}
		#endregion /SettingButton_Click

		#region BackupAndRestorButton_Click
		private void BackupAndRestorButton_Click(object sender, EventArgs e)
		{
			BackupAndRestorForm.Dock = DockStyle.Fill;
			BackupAndRestorForm.TopLevel = false;
			BackupAndRestorForm.TopMost = true;

			selectSettingPanel.Controls.Clear();
			selectSettingPanel.Controls.Add(BackupAndRestorForm);
			BackupAndRestorForm.Show();
		}
		#endregion BackupAndRestorButton_Click

		#region AdministratorSettingButton_Click
		private void AdministratorSettingButton_Click(object sender, EventArgs e)
		{
			AdministratorSettingForm.Dock = DockStyle.Fill;
			AdministratorSettingForm.TopLevel = false;
			AdministratorSettingForm.TopMost = true;
			AdministratorSettingForm.showMenuPanel.Controls.Clear();

			selectSettingPanel.Controls.Clear();
			selectSettingPanel.Controls.Add(AdministratorSettingForm);
			AdministratorSettingForm.Show();
		}
		#endregion /AdministratorSettingButton_Click

		#region ClientManagementButton_Click
		private void ClientManagementButton_Click(object sender, EventArgs e)
		{
			ClientManegmentForm.Dock = DockStyle.Fill;
			ClientManegmentForm.TopLevel = false;
			ClientManegmentForm.TopMost = true;
			ClientManegmentForm.selectCustomerTypePanel.Controls.Clear();

			selectSettingPanel.Controls.Clear();
			selectSettingPanel.Controls.Add(ClientManegmentForm);
			ClientManegmentForm.Show();
		}
		#endregion /ClientManagementButton_Click
		//-----
		#endregion /SETTING

		#region ShutdownButton_Click
		private void ShutdownButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "قصد خروج دارید؟", caption: "خروج از برنامه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				SaveLogOutTime(Program.AutenticatLogHistory);
				Application.Exit();
			}
		}
		#endregion /ShutdownButton_Click

		#region LogOutButton_Click
		private void LogOutButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "از حساب کاربری خارج می شوید؟", caption: "خروج از حساب", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				Infrastructure.Utility.SaveLogOutTime(Program.AutenticatLogHistory);
				//SaveLogOutTime(Program.AutenticatLogHistory);
				Program.AuthenticatedUser = null;
				this.Close();
				LoginForm loginForm = new LoginForm();
				loginForm.Show();
			}
		}

		#endregion /LogOutButton_Click

		#region MouseDown
		//-----
		#region TitlePanel_MouseDown
		private void TitlePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /TitlePanel_MouseDown

		#region PopupPanel_MouseDown
		private void PopupPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /PopupPanel_MouseDown

		#region CaptionPanel_MouseDown
		private void CaptionPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /CaptionPanel_MouseDown

		#region RightSidePanel_MouseDown
		private void RightSidePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /RightSidePanel_MouseDown

		#region MenuPanel_MouseDown
		private void MenuPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		#endregion /MenuPanel_MouseDown

		#region MainPanel_MouseDown
		private void MainPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /MainPanel_MouseDown

		#region MainForm_MouseDown
		private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /MainForm_MouseDown

		#region StorePanel_MouseDown
		private void StorePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /StorePanel_MouseDown

		#region MenuStorePanel_MouseDown
		private void MenuStorePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /MenuStorePanel_MouseDown

		#region HookahPanel_MouseDown
		private void HookahPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /HookahPanel_MouseDown

		#region DrinkPanel_MouseDown
		private void DrinkPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /DrinkPanel_MouseDown

		#region FoodPanel_MouseDown
		private void FoodPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /FoodPanel_MouseDown

		#region RegisterOrderPanel_MouseDown
		private void RegisterOrderPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /RegisterOrderPanel_MouseDown

		#region OrderDataGridView_MouseDown
		private void OrderDataGridView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /OrderDataGridView_MouseDown

		#region ListPanel_MouseDown
		private void ListPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /ListPanel_MouseDown

		#region HookahDataGridView_MouseDown
		private void HookahDataGridView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /HookahDataGridView_MouseDown

		#region DrinkDataGridView_MouseDown
		private void DrinkDataGridView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /DrinkDataGridView_MouseDown

		#region FoodDataGridView_MouseDown
		private void FoodDataGridView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /FoodDataGridView_MouseDown
		//-----
		#endregion /MouseDown

		#region Timer1_Tick
		private void FadeFormTimer_Tick(object sender, System.EventArgs e)
		{
			if (this.Opacity < 0.9)
			{
				this.Opacity += 0.05;
			}
			else
			{
				fadeFormTimer.Stop();
			}
		}
		#endregion /Timer1_Tick

		//-----End of coding line

		#region Functions
		//-----
		#region AllClearHookah
		private void AllClearHookah()
		{
			HookahName = null;
			hookahNameTextBox.Text = "نام قلیان";
			hookahNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			hookahNamePanel.BackColor =
				Infrastructure.Utility.GrayColor();

			HookahPrice = 0;
			hookahPriceTextBox.Text = "قیمت";
			hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			hookahPriceTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			hookahPricePanel.BackColor =
				Infrastructure.Utility.GrayColor();

			HookahDescription = "توضیحات";
			hookahDescriptionTextBox.Text = "توضیحات";
			hookahDescriptionTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			hookahDescriptionPanel.BackColor =
				Infrastructure.Utility.GrayColor();

			HookahImage = null;
			hookahImagePicturBox.Image = Properties.Resources.hookah_512px;
			deleteHookahImageButton.Visible = false;
		}
		#endregion /AllClearHookah

		#region AllClearDrink
		private void AllClearDrink()
		{
			DrinkName = null;
			drinkNameTextBox.Text = "نام نوشیدنی";
			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			drinkNamePanel.BackColor =
				Infrastructure.Utility.GrayColor();

			DrinkPrice = 0;
			drinkPriceTextBox.Text = "قیمت";
			drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			drinkPriceTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			drinkPricePanel.BackColor =
				Infrastructure.Utility.GrayColor();

			DrinkDescription = "توضیحات";
			drinkDescriptionTextBox.Text = "توضیحات";
			drinkDescriptionTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			drinkDescriptionPanel.BackColor =
				Infrastructure.Utility.GrayColor();

			DrinkImage = null;
			hookahImagePicturBox.Image = Properties.Resources.drink_512;
			deleteDrinkImageButton.Visible = false;
		}
		#endregion /AllClearDrink

		#region AllClearFood
		private void AllClearFood()
		{
			FoodName = null;
			foodNameTextBox.Text = "نام غذا";
			foodNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			foodNamePanel.BackColor =
				Infrastructure.Utility.GrayColor();

			FoodPrice = 0;
			foodPriceTextBox.Text = "قیمت";
			foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			foodPriceTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			foodPricePanel.BackColor =
				Infrastructure.Utility.GrayColor();

			FoodDescription = "توضیحات";
			foodDescriptionTextBox.Text = "توضیحات";
			foodDescriptionTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			foodDescriptionPanel.BackColor =
				Infrastructure.Utility.GrayColor();

			FoodImage = null;
			foodImagePicturBox.Image = Properties.Resources.pizza_food_512px;
			deleteFoodImageButton.Visible = false;
		}
		#endregion /AllClearDrink

		#region ApprovalClientID
		private bool ApprovalClientID(string clientID)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.PermanentClient permanentClient =
				dataBaseContext.PermanentClients
				.Where(current => current.Client_ID.Contains(clientID))
				.FirstOrDefault();

			if (permanentClient == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /ApprovalClientID

		#region CalculateDayFinancial
		private void CalculateDayFinancial()
		{
			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(DateTime.Now);
			int month = persianCalendar.GetMonth(DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(DateTime.Now);

			string dateNow =
				$"{year}/{month.ToString().PadLeft(2, '0')}/{day.ToString().PadLeft(2, '0')}";

			int sumTotalPrice = 0;
			int resultSumTotalPrice = 0;
			int sumPaymentAmount = 0;
			int resultSumPaymentAmount = 0;
			int sumRemainingAmount = 0;
			int resultSumRemainingAmount = 0;

			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new DataBaseContext();
				List<Financial> financials =
					dataBaseContext.Financials
					.Where(current => current.Register_Date.Contains(dateNow))
					.OrderBy(current => current.Register_Date)
					.ToList();

				if (financials != null)
				{
					foreach (var item in financials)
					{
						sumTotalPrice = int.Parse(item.Total_Price);
						resultSumTotalPrice += sumTotalPrice;

						sumPaymentAmount = int.Parse(item.Payment_Amount);
						resultSumPaymentAmount += sumPaymentAmount;

						sumRemainingAmount = int.Parse(item.Remaining_Amount);
						resultSumRemainingAmount += sumRemainingAmount;
					}
				}

				Models.DailyFinancial dailyFinancial =
					dataBaseContext.DailyFinancials
					.Where(current => string.Compare(current.Register_Date, dateNow) == 0)
					.FirstOrDefault();

				if (dailyFinancial != null)
				{
					dailyFinancial = new DailyFinancial
					{
						Sum_Total_Price_Of_Day = resultSumTotalPrice.ToString(),
						Sum_Payment_Amount_Of_Day = resultSumPaymentAmount.ToString(),
						Sum_Remaining_Amount_Of_Day = resultSumRemainingAmount.ToString(),
						Register_Date = dateNow,
						Year = year,
						Month = month,
						Day = day,
					};
					dataBaseContext.SaveChanges();

					Mbb.Windows.Forms.MessageBox.Show
						(text: "حساب روز محاسبه گردید و بسته شد!",
						caption: "تکمیل محاسبات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				else if (dailyFinancial == null)
				{
					dailyFinancial = new DailyFinancial
					{
						Sum_Total_Price_Of_Day = resultSumTotalPrice.ToString(),
						Sum_Payment_Amount_Of_Day = resultSumPaymentAmount.ToString(),
						Sum_Remaining_Amount_Of_Day = resultSumRemainingAmount.ToString(),
						Register_Date = dateNow,
						Year = year,
						Month = month,
						Day = day,
					};
					dataBaseContext.DailyFinancials.Add(dailyFinancial);
					dataBaseContext.SaveChanges();

					Mbb.Windows.Forms.MessageBox.Show
						(text: "حساب روز محاسبه گردید و بسته شد!",
						caption: "تکمیل محاسبات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}

			}
			catch (Exception ex)
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
		#endregion /CalculateDayFinancial

		#region CalculatMonthFinancial
		private void CalculatMonthFinancial()
		{
			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(DateTime.Now);
			int month = persianCalendar.GetMonth(DateTime.Now);


			string dateNow = $"{year}";

			int sumTotalPrice = 0;
			int resultSumTotalPrice = 0;
			int sumPaymentAmount = 0;
			int resultSumPaymentAmount = 0;
			int sumRemainingAmount = 0;
			int resultSumRemainingAmount = 0;

			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new DataBaseContext();
				List<DailyFinancial> dailyFinancials =
					dataBaseContext.DailyFinancials
					.Where(current => current.Register_Date.Contains(dateNow))
					.OrderBy(current => current.Month)
					.ToList();

				if (dailyFinancials != null)
				{
					foreach (var item in dailyFinancials)
					{
						sumTotalPrice = int.Parse(item.Sum_Total_Price_Of_Day);
						resultSumTotalPrice += sumTotalPrice;

						sumPaymentAmount = int.Parse(item.Sum_Payment_Amount_Of_Day);
						resultSumPaymentAmount += sumPaymentAmount;

						sumRemainingAmount = int.Parse(item.Sum_Remaining_Amount_Of_Day);
						resultSumRemainingAmount += sumRemainingAmount;
					}
				}

				Models.DailyFinancial dailyFinancial = new DailyFinancial
				{
					Sum_Total_Price_Of_Day = resultSumTotalPrice.ToString(),
					Sum_Payment_Amount_Of_Day = resultSumPaymentAmount.ToString(),
					Sum_Remaining_Amount_Of_Day = resultSumRemainingAmount.ToString(),
					Register_Date = dateNow,
					Year = year,
					Month = month,
				};

				dataBaseContext.DailyFinancials.Add(dailyFinancial);
				dataBaseContext.SaveChanges();
			}
			catch (Exception ex)
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
		#endregion /CalculatMonthFinancial

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

		#region DrinkListSearch
		private void DrinkListSearch(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Drink> drinks = null;

				if (string.IsNullOrWhiteSpace(text))
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
						.Where(current => current.DrinkName.Contains(text))
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
			return;
		}
		#endregion /DrinkListSearch

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

		#region FoodListSearch
		private void FoodListSearch(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Food> foods = null;

				if (string.IsNullOrWhiteSpace(text))
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
						.Where(current => current.FoodName.Contains(text))
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
			return;
		}
		#endregion /FoodListSearch

		#region FormLoad
		private void FormLoad()
		{
			mainPanel.Controls.Clear();
			focusPanel.Height = homeButton.Height;
			focusPanel.Top = homeButton.Top;

			Order = false;
			Store = false;
			Report = false;
			Setting = false;

			secondLabel.Text = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			minuteLabel.Text = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			hourLabel.Text = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			clockTimer.Start();

			solarDateLabel.Text = Infrastructure.Utility.PersianCalendar();
			adDateLabel.Text = Infrastructure.Utility.ADCalendar();
		}
		#endregion /FormLoad

		#region FoundedClientID
		private void FoundedClientID(string clientID)
		{

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.PermanentClient permanentClient =
				dataBaseContext.PermanentClients
				.Where(current => string.Compare(current.Client_ID, clientID) == 0)
				.FirstOrDefault();

			if (permanentClient == null)
			{
				return;
			}
			else
			{
				clientNameTextBox.Text = permanentClient.Full_Name;
			}
		}
		#endregion /FoundedClientID

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

		#region HookahListSearch
		private void HookahListSearch(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				List<Hookah> hookahs = null;

				if (string.IsNullOrWhiteSpace(text))
				{
					hookahs =
						dataBaseContext.Hookahs
						.OrderBy(current => current.HookahName)
						.ToList();
				}
				else
				{
					hookahs =
						dataBaseContext.Hookahs
						.Where(current => current.HookahName.Contains(text))
						.OrderBy(current => current.HookahName)
						.ToList();
				}

				hookahStoreDataGridView.DataSource = hookahs;
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
			return;
		}
		#endregion /HookahListSearch

		#region Initialize
		public void Initialize()
		{
			string name =
				$"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";

			if (string.IsNullOrEmpty(Program.AuthenticatedUser.First_Name) || string.IsNullOrEmpty(Program.AuthenticatedUser.Last_Name) || Program.AuthenticatedUser.First_Name == "null" || Program.AuthenticatedUser.Last_Name == "null")
			{
				name =
					Program.AuthenticatedUser.Username;
			}

			usernameLoginLinkLabel.Text = name;

			var byteImage = Program.AuthenticatedUser.User_Image;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(ms);
			}

			if (string.Compare(Program.AuthenticatedUser.Access_Level, "مدیریت") == 0)
			{
				reportButton.Enabled = true;
				settingButton.Enabled = true;
				administratorSettingButton.Enabled = true;
			}
			else if (string.Compare(Program.AuthenticatedUser.Access_Level, "کارمند") == 0)
			{
				administratorSettingButton.Enabled = false;
			}
			else if (string.Compare(Program.AuthenticatedUser.Access_Level, "نیروی خدمات") == 0)
			{
				reportButton.Enabled = false;
				settingButton.Enabled = false;
			}
			else if (string.Compare(Program.AuthenticatedUser.Access_Level, "کاربر ساده") == 0)
			{
				storeButton.Enabled = false;
				reportButton.Enabled = false;
				settingButton.Enabled = false;
			}
		}
		#endregion /Initialize

		#region NewOrder
		private void NewOrder()
		{
			#region EventLog
			EventLog_Username = Program.AuthenticatedUser.Username;
			EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
			EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
			EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
			EventLog_EventTitle = $"ایجاد سفارش جدید";

			Infrastructure.Utility.EventLog
				(username: EventLog_Username,
				fullName: EventLog_FullName,
				eventDate: EventLog_EventDate,
				eventTime: EventLog_EventTime,
				eventTitle: EventLog_EventTitle);
			#endregion /EventLog

			searchTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
			searchPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			Search = null;
			searchTextBox.Text = "جستجو...";
			ClientName = null;
			clientNameTextBox.Text = "نام مشتری";
			clientNameTextBox.ForeColor = Infrastructure.Utility.BlackColor();
			clientNamePanel.BackColor = Infrastructure.Utility.BlackColor();

			ClientID = null;
			clientIDTextBox.Text = "کد مشتری";
			clientIDTextBox.TextAlign = HorizontalAlignment.Left;
			clientIDTextBox.ForeColor = Infrastructure.Utility.BlackColor();
			clientIDPanel.BackColor = Infrastructure.Utility.BlackColor();

			ExtraHead = 0;
			extraHeadTextBox.Text = "مبلغ سری اضافه";
			extraHeadTextBox.TextAlign = HorizontalAlignment.Left;
			extraHeadTextBox.ForeColor = Infrastructure.Utility.BlackColor();
			extraHeadPanel.BackColor = Infrastructure.Utility.BlackColor();

			orderDataGridView.Rows.Clear();

			Total_Price_Int = 0;
			Total_Price_String = null;
			totalPriceTextBox.Text = "0 تومان";

			Payment = 0;
			Entry_Payment = null;
			paymentTextBox.Text = "مبلغ پرداختی...";
			paymentTextBox.TextAlign = HorizontalAlignment.Left;
			paymentTextBox.ForeColor = Infrastructure.Utility.DarkDimGary();

			Remaining = 0;
			Remaining_string = null;
			remainingTextBox.Text = "0 تومان";

			Payment_Type = null;
			cashRadioButton.Checked = false;
			cardRadioButton.Checked = false;
			cashAndCardRadioButton.Checked = false;
			noPaidRadioButton.Checked = false;

			saveAndPrintButton.Enabled = false;
			newOrderButton.Enabled = false;
			reduceRequestButton.Enabled = false;

			AccountStatus = null;
			debtorRadioButton.Checked = false;
			clearingRadioButton.Checked = false;
			creditorRadioButton.Checked = false;

			Permanent = null;
			Temporary = null;
			temporaryRadioButton.Checked = false;
			permanentRadioButton.Checked = false;
		}
		#endregion /NewOrder

		#region SaveLogOutTime
		private void SaveLogOutTime(Models.LogHistory log)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LogHistory logHistory =
					dataBaseContext.LogHistories
					.Where(current => string.Compare(current.Username, log.Username) == 0)
					.OrderByDescending(current => current.Login_Time)
					.SingleOrDefault(current => current.Id == log.Id);

				if (logHistory != null)
				{
					LogOutTime = $"{Infrastructure.Utility.ShowTime()}" +
						$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} ";

					logHistory.Logout_Time = LogOutTime;

					dataBaseContext.SaveChanges();
				}
				else
				{
					return;
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
		#endregion /SaveLogOutTime

		#region UpLoadPicture
		public void UpLoadPicture()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, Program.AuthenticatedUser.Username) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					var image = user.User_Image;
					using (System.IO.MemoryStream userImage = new System.IO.MemoryStream(image))
					{
						userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(userImage);
					}
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
		#endregion /UpLoadPicture
		//-----
		#endregion /Functions
	}
}