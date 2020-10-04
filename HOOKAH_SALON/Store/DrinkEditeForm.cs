using System;
using System.Linq;

namespace HOOKAH_SALON.Store
{
	public partial class DrinkEditeForm : Infrastructure.BaseForm
	{
		public DrinkEditeForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string DrinkName_FirstLoad { get; set; }
		public string DrinkName_New { get; private set; }
		public string DrinkName { get; set; }
		public string DrinkPrice_FirstLoad { get; private set; }
		public string DrinkPrice_New { get; private set; }
		public int DrinkPrice_Int { get; private set; }
		public string DrinkPrice { get; set; }
		public string DrinkDescription_New { get; private set; }
		public string DrinkDescription_FirstLoad { get; private set; }
		public string DrinkDescription { get; set; }
		public byte[] DrinkImage_FirstLoad { get; private set; }
		public byte[] DrinkImage_New { get; private set; }
		public byte[] DrinkImage { get; private set; }
		public string Select_DrinkImage { get; private set; }
		public string DrinkUpdateTime { get; set; }
		public int DrinkNumberUpdate { get; set; }
		public DrinkStoreForm MyDrinkStoreForm { get; set; }
		public string EventRegisterDate { get; private set; }
		public string EventTitle { get; private set; }
		public string Username { get; private set; }
		public string FullName { get; private set; }
		public string EventDate { get; private set; }
		public string EventTime { get; private set; }
		
		#endregion /Properties

		//-----The beginning of the coding line.

		#region DrinkEditeForm_Load
		private void DrinkEditeForm_Load(object sender, System.EventArgs e)
		{
			FormLoad();
		}
		#endregion /DrinkEditeForm_Load

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

		#region DrinkNameTextBox
		//-----
		#region DrinkNameTextBox_Enter
		private void DrinkNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			drinkNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(drinkNameTextBox.Text, DrinkName_FirstLoad) == 0)
			{
				drinkNameTextBox.Clear();
				DrinkName = null;
			}
			else
			{
				return;
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
			if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) || string.Compare(drinkNameTextBox.Text, DrinkName_FirstLoad) == 0)
			{
				drinkNameTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				drinkNamePanel.BackColor =
					Infrastructure.Utility.DarkGrayColor();
				drinkNameTextBox.Text = DrinkName_FirstLoad;
				DrinkName_New = null;
			}
			else
			{
				drinkNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				DrinkName_New = drinkNameTextBox.Text;
			}
		}
		#endregion /DrinkNameTextBox_Leave

		#region DrinkNameTextBox_TextChanged
		private void DrinkNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) || string.Compare(drinkNameTextBox.Text, DrinkName_FirstLoad) == 0)
			{
				drinkNameTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkNamePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
				return;
			}
			else
			{
				drinkNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /DrinkNameTextBox_TextChanged 
		//-----
		#endregion /DrinkNameTextBox

		#region  DrinkPriceTextBox
		//-----
		#region DrinkPriceTextBox_Enter
		private void DrinkPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			drinkNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(drinkPriceTextBox.Text, DrinkPrice_FirstLoad) == 0)
			{
				drinkPriceTextBox.Select(0, drinkPriceTextBox.Text.LastIndexOf(" ") - 1);
				DrinkPrice_New = null;
				DrinkPrice_Int = 0;
				return;
			}
			else
			{
				drinkPriceTextBox.Select(0, drinkPriceTextBox.Text.LastIndexOf(" ") - 1);
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
			if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) || string.Compare(drinkPriceTextBox.Text, DrinkPrice_FirstLoad) == 0)
			{
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
				drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				drinkPriceTextBox.Text = DrinkPrice_FirstLoad;
				DrinkPrice_New = null;
				DrinkPrice_Int = 0;
			}
			else
			{
				drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				DrinkPrice_New = drinkPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				DrinkPrice_Int = int.Parse(DrinkPrice_New.Replace(",", string.Empty).Trim());
				drinkPriceTextBox.Text = $"{DrinkPrice_Int:#,0} تومان";
				DrinkPrice_New = drinkPriceTextBox.Text;
			}
		}
		#endregion /DrinkPriceTextBox_Leave

		#region DrinkPriceTextBox_TextChanged
		private void DrinkPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) || string.Compare(drinkPriceTextBox.Text, DrinkPrice_FirstLoad) == 0)
			{
				drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
			}
			else
			{
				drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /DrinkPriceTextBox_TextChanged 
		//-----
		#endregion / DrinkPriceTextBox

		#region DrinkDescriptionTextBox
		//-----
		#region DrinkDescriptionTextBox_Enter
		private void DrinkDescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			drinkDescriptionPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(drinkDescriptionTextBox.Text, DrinkDescription_FirstLoad) == 0)
			{
				drinkDescriptionTextBox.Clear();
				DrinkDescription = null;
			}
			else
			{
				return;
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
			if (string.IsNullOrWhiteSpace(drinkDescriptionTextBox.Text) || string.Compare(drinkDescriptionTextBox.Text, DrinkDescription_FirstLoad) == 0)
			{
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
				drinkDescriptionTextBox.Text = DrinkDescription_FirstLoad;
				DrinkDescription_New = null;
			}
			else
			{
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				DrinkDescription_New = drinkDescriptionTextBox.Text;
			}
		}
		#endregion /DrinkDescriptionTextBox_Leave

		#region DrinkDescriptionTextBox_TextChanged
		private void DrinkDescriptionTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkDescriptionTextBox.Text) || string.Compare(drinkDescriptionTextBox.Text, DrinkDescription_FirstLoad) == 0)
			{
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
			}
			else
			{
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /DrinkDescriptionTextBox_TextChanged
		//-----
		#endregion /DrinkDescriptionTextBox

		#region DrinkImagePicturBox_MouseDoubleClick
		private void DrinkImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load Drink Picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Select_DrinkImage = openFileDialog.FileName;
				drinkImagePicturBox.Image =
				System.Drawing.Image.FromFile(Select_DrinkImage);

				DrinkImage_New = System.IO.File.ReadAllBytes(Select_DrinkImage);
			}
			else
			{
				Select_DrinkImage = null;
				DrinkImage_New = null;
				deleteDrinkImageButton.Visible = false;
			}
		}
		#endregion /DrinkImagePicturBox_MouseDoubleClick

		#region DeleteDrinkImageButton_Click
		private void DeleteDrinkImageButton_Click(object sender, System.EventArgs e)
		{
			DrinkImage_New = null;
			Select_DrinkImage = null;
			DrinkImage = null;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(DrinkImage_FirstLoad))
			{
				drinkImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
			};
			deleteDrinkImageButton.Visible = false;
		}
		#endregion /DeleteDrinkImageButton_Click

		#region UpdateDataDrinkButton_Click
		private void UpdateDataDrinkButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string drinkName = null;


				if (string.IsNullOrEmpty(DrinkName_New))
				{
					drinkName = DrinkName_FirstLoad;
					DrinkName = DrinkName_FirstLoad;
				}
				else
				{
					drinkName = DrinkName_New;
					DrinkName = DrinkName_New;
				}

				if (string.IsNullOrEmpty(DrinkPrice_New))
				{
					DrinkPrice = DrinkPrice_FirstLoad;
				}
				else
				{
					DrinkPrice = DrinkPrice_New;
				}

				if (string.IsNullOrEmpty(DrinkDescription_New))
				{
					DrinkDescription = DrinkDescription_FirstLoad;
				}
				else
				{
					DrinkDescription = DrinkDescription_New;
				}

				if (string.IsNullOrEmpty(Select_DrinkImage))
				{
					DrinkImage = DrinkImage_FirstLoad;
				}
				else
				{
					DrinkImage = DrinkImage_New;
				}


				System.Windows.Forms.DialogResult dialogResult;
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: $"{DrinkName} به روز گردد؟",
					caption: "به روز رسانی کالا",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Drink drink =
					dataBaseContext.Drinks
					.Where(current => string.Compare(current.DrinkName, DrinkName_FirstLoad) == 0)
					.FirstOrDefault();

					DrinkNumberUpdate = drink.NumberUpdate;
					DrinkUpdateTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					DrinkNumberUpdate++;

					drink.DrinkName = DrinkName;
					drink.DrinkPrice = DrinkPrice;
					drink.DrinkDescription = DrinkDescription;
					drink.UpdateTime = DrinkUpdateTime;
					drink.NumberUpdate = DrinkNumberUpdate;
					drink.DrinkImage = DrinkImage;
					

					dataBaseContext.SaveChanges();

					//-----جهت بارگذاری اطلاعات قلیان در جدول داده 
					if (HOOKAH_SALON.MainForm.DrinkStoreForm != null)
					{
						HOOKAH_SALON.MainForm.DrinkStoreForm.DrinkLoader();
					}

					//-----این بخش مربوط به ثبت رخداد می باشد!
					#region EventLogForFood
					if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage))
					{
						return;
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} و مبلغ آن از {DrinkPrice_FirstLoad} به {DrinkPrice_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New}و توضیحات آن از {DrinkDescription_FirstLoad} به {DrinkDescription} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} و قیمت آن از {DrinkPrice_FirstLoad} به {DrinkPrice_New} و توضیحات آن از {DrinkDescription_FirstLoad} به {DrinkDescription_New} تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} و قیمت آن از {DrinkPrice_FirstLoad} به {DrinkPrice_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} و توضیحات آن از {DrinkDescription_FirstLoad} به {DrinkDescription_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) == false && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {DrinkName_FirstLoad} به {DrinkName_New} و قیمت از {DrinkPrice_FirstLoad} به {DrinkPrice_New} و توضیحات از {DrinkDescription_FirstLoad} به {DrinkDescription_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {DrinkName_FirstLoad} از {DrinkPrice_FirstLoad} به {DrinkPrice_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {DrinkName_FirstLoad} از {DrinkPrice_FirstLoad} به {DrinkPrice_New} و توضیحات آن از {DrinkDescription_FirstLoad} به {DrinkDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {DrinkName_FirstLoad} از {DrinkPrice_FirstLoad} به {DrinkPrice_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) == false && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {DrinkName_FirstLoad} از {DrinkPrice_FirstLoad} به {DrinkPrice_New} و توضیحات آن از {DrinkDescription_FirstLoad} به {DrinkDescription_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"توضیحات {DrinkName_FirstLoad} از {DrinkDescription_FirstLoad} به {DrinkDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) == false && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"توضیحات {DrinkName_FirstLoad} از {DrinkDescription_FirstLoad} به {DrinkDescription_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(DrinkName_New) && string.IsNullOrEmpty(DrinkPrice_New) && string.IsNullOrEmpty(DrinkDescription_New) && string.IsNullOrEmpty(Select_DrinkImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"عکس {DrinkName_FirstLoad} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					#endregion /EventLogForFood

					string message =
						$"{DrinkName} بروز رسانی گردید.";

					Infrastructure.Utility.WindowsNotification
						(message: message,
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
						picture: DrinkImage);
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
		#endregion /UpdateDataDrinkButton_Click

		//-----End of coding line

		#region Founctions
		//-----
		#region FormLoad
		private void FormLoad()
		{ 
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Drink drink =
					dataBaseContext.Drinks
					.Where(current => string.Compare(current.DrinkName, DrinkName_FirstLoad, true) == 0)
					.FirstOrDefault();

				DrinkName = null;
				DrinkDescription_New = null;
				drinkNameTextBox.Text = drink.DrinkName;

				DrinkPrice = null;
				DrinkPrice_New = null;
				DrinkPrice_Int = 0;
				drinkPriceTextBox.Text = drink.DrinkPrice;
				DrinkPrice_FirstLoad = drink.DrinkPrice;
				drinkPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkPricePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();


				DrinkDescription = null;
				DrinkDescription_New = null;
				drinkDescriptionTextBox.Text = drink.DrinkDescription;
				DrinkDescription_FirstLoad = drink.DrinkDescription;
				drinkDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				drinkDescriptionPanel.BackColor =
					Infrastructure.Utility.DarkDimGary();

				DrinkImage = null;
				DrinkDescription_New = null;
				DrinkImage_FirstLoad = drink.DrinkImage; 
				var byteImage = drink.DrinkImage;
				if (byteImage == null)
				{
					deleteDrinkImageButton.Visible = false;
				}
				else
				{
					deleteDrinkImageButton.Visible = true;
					using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
					{
						drinkImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
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
		#endregion /FormLoad
		//-----
		#endregion /Founctions
	}
}
