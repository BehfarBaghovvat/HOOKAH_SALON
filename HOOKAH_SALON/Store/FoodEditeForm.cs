using System;
using System.Linq;

namespace HOOKAH_SALON.Store
{
	public partial class FoodEditeForm : Infrastructure.BaseForm
	{
		public FoodEditeForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string FoodName_FirstLoad { get; set; }
		public string FoodName_New { get; set; }
		public string FoodName { get; set; }
		public string FoodPrice_FirstLoad { get; set; }
		public string FoodPrice_New { get; set; }
		public int FoodPrice_Int { get; private set; }
		public string FoodPrice { get; set; }
		public string FoodDescription_FirstLoad { get; set; }
		public string FoodDescription_New { get; set; }
		public string FoodDescription { get; set; }
		public string Select_FoodImage { get; private set; }
		public byte[] FoodImage_FirstLoad { get; set; }
		public byte[] FoodImage_New { get; set; }
		public byte[] FoodImage { get; set; }
		public string FoodUpdateTime { get; set; }
		public int FoodNumberUpdate { get; set; }
		public FoodStoreFrom MyFoodStoreForm { get; set; }
		public string EventRegisterDate { get; set; }
		public string EventTitle { get; set; }
		public string Username { get; set; }
		public string FullName { get; set; }
		public string EventDate { get; set; }
		public string EventTime { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region FoodEditeForm_Load
		private void FoodEditeForm_Load(object sender, System.EventArgs e)
		{
			FoodLoad();
		}
		#endregion /FoodEditeForm_Load

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

			if (string.Compare(foodNameTextBox.Text, FoodName_FirstLoad) == 0)
			{
				foodNameTextBox.Select(foodNameTextBox.Text.Length, 0);
				FoodName_New = null;
			}
			else
			{
				return;
			}
		}
		#endregion /FoodNameTextBox_Enter

		#region FoodNameTextBox_KeyPress
		private void FoodNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);

			if (string.Compare(foodNameTextBox.Text, FoodName_FirstLoad) == 0)
			{
				foodNameTextBox.Clear();
			}
		}
		#endregion /FoodNameTextBox_KeyPress

		#region FoodNameTextBox_Leave
		private void FoodNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) || string.Compare(foodNameTextBox.Text, FoodName_FirstLoad) == 0)
			{
				foodNameTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodNamePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				foodNameTextBox.Text = FoodName_FirstLoad;
				FoodName_New = null;
			}
			else
			{
				foodNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				FoodName_New = foodNameTextBox.Text;
			}
		}
		#endregion /FoodNameTextBox_Leave

		#region FoodNameTextBox_TextChanged
		private void FoodNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) || string.Compare(foodNameTextBox.Text, FoodName_FirstLoad) == 0)
			{
				foodNameTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodNamePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				return;
			}
			else
			{
				foodNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /FoodNameTextBox_TextChanged
		//-----
		#endregion /FoodNameTextBox

		#region FoodPriceTextBox
		//-----
		#region FoodPriceTextBox_Enter
		private void FoodPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			foodPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			foodPricePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(foodPriceTextBox.Text, FoodPrice_FirstLoad) == 0)
			{
				foodPriceTextBox.Select(0, foodPriceTextBox.Text.LastIndexOf(" ") - 1);
				FoodPrice_New = null;
				FoodPrice_Int = 0;
				return;
			}
			else
			{
				foodPriceTextBox.Select(0, foodPriceTextBox.Text.LastIndexOf(" ") - 1);
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
			if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) || string.Compare(foodPriceTextBox.Text, FoodPrice_FirstLoad) == 0)
			{
				foodPriceTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				foodPriceTextBox.Text = FoodPrice_FirstLoad;
				FoodPrice_New = null;
				FoodPrice_Int = 0;
			}
			else
			{
				foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				foodPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				FoodPrice_New = foodPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				FoodPrice_Int = int.Parse(FoodPrice_New.Replace(",", string.Empty).Trim());
				foodPriceTextBox.Text = $"{FoodPrice_Int:#,0} تومان";
				FoodPrice_New = foodPriceTextBox.Text;
			}
		}
		#endregion /FoodPriceTextBox_Leave

		#region FoodPriceTextBox_TextChanged
		private void FoodPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) || string.Compare(foodPriceTextBox.Text, FoodPrice_FirstLoad) == 0)
			{
				foodPriceTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				return;
			}
			else
			{
				foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				foodPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /FoodPriceTextBox_TextChanged 
		//-----
		#endregion /FoodPriceTextBox

		#region FoodDescriptionTextBox
		//-----
		#region FoodDescriptionTextBox_Enter
		private void FoodDescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			foodDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			foodDescriptionPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(foodDescriptionTextBox.Text, FoodDescription_FirstLoad) == 0)
			{
				foodDescriptionTextBox.Clear();
				FoodDescription_New = null;
			}
			else
			{
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
			if (string.IsNullOrWhiteSpace(foodDescriptionTextBox.Text) || string.Compare(foodDescriptionTextBox.Text, FoodDescription_FirstLoad) == 0)
			{
				foodDescriptionTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				foodDescriptionTextBox.Text = FoodDescription_FirstLoad;
				FoodDescription_New = null;
			}
			else
			{
				foodDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				FoodDescription_New = foodDescriptionTextBox.Text;
			}
		}
		#endregion /FoodDescriptionTextBox_Leave

		#region FoodDescriptionTextBox_TextChanged
		private void FoodDescriptionTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodDescriptionTextBox.Text) || string.Compare(foodDescriptionTextBox.Text, FoodDescription_FirstLoad) == 0)
			{
				foodDescriptionTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				return;
			}
			else
			{
				foodDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /FoodDescriptionTextBox_TextChanged 
		//-----
		#endregion FoodDescriptionTextBox

		#region DrinkImagePicturBox_MouseDoubleClick
		private void DrinkImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load Food Picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Select_FoodImage = openFileDialog.FileName;
				foodImagePicturBox.Image =
				System.Drawing.Image.FromFile(Select_FoodImage);
				FoodImage_New = System.IO.File.ReadAllBytes(Select_FoodImage);
			}
			else
			{
				Select_FoodImage = null;
				FoodImage_New = null;
				deleteFoodImageButton.Visible = false;
			}
		}
		#endregion /DrinkImagePicturBox_MouseDoubleClick

		#region DeleteFoodImageButton_Click
		private void DeleteFoodImageButton_Click(object sender, System.EventArgs e)
		{
			FoodImage_New = null;
			Select_FoodImage = null;
			FoodImage = null;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(FoodImage_FirstLoad))
			{
				foodImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
			};
			deleteFoodImageButton.Visible = false;
		}
		#endregion /DeleteFoodImageButton_Click

		#region UpdateDataFoodButton_Click
		private void UpdateDataFoodButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string foodName = null;

				if (string.IsNullOrEmpty(FoodName_New))
				{
					foodName = FoodName_FirstLoad;
					FoodName = FoodName_FirstLoad;
				}
				else
				{
					foodName = FoodName_New;
					FoodName = FoodName_New;
				}

				if (string.IsNullOrEmpty(FoodPrice_New))
				{
					FoodPrice = FoodPrice_FirstLoad;
				}
				else
				{
					FoodPrice = FoodPrice_New;
				}

				if (string.IsNullOrEmpty(FoodDescription_New))
				{
					FoodDescription = FoodDescription_FirstLoad;
				}
				else
				{
					FoodDescription = FoodDescription_New;
				}

				if (string.IsNullOrEmpty(Select_FoodImage))
				{
					FoodImage = FoodImage_FirstLoad;
				}
				else
				{
					FoodImage = FoodImage_New;
				}

				System.Windows.Forms.DialogResult dialogResult;
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: $"{foodName} به روز گردد؟",
					caption: "به روز رسانی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Food food =
					dataBaseContext.Foods
					.Where(current => string.Compare(current.FoodName, FoodName_FirstLoad, false) == 0)
					.FirstOrDefault();

					FoodUpdateTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					FoodNumberUpdate++;

					food.FoodName = FoodName;
					food.FoodPrice = FoodPrice;
					food.FoodDescription = FoodDescription;
					food.FoodImage = FoodImage;
					food.UpdateTime = FoodUpdateTime;
					food.NumberUpdate = FoodNumberUpdate;

					dataBaseContext.SaveChanges();

					//-----جهت بارگذاری اطلاعات قلیان در جدول داده 
					if (HOOKAH_SALON.MainForm.FoodStoreFrom != null)
					{
						HOOKAH_SALON.MainForm.FoodStoreFrom.FoodLoader();
					}

					//-----این بخش مربوط به ثبت رخداد می باشد!
					#region EventLogForFood
					if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage))
					{
						return;
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} و مبلغ آن از {FoodPrice_FirstLoad} به {FoodPrice_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New}و توضیحات آن از {FoodDescription_FirstLoad} به {FoodDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} و قیمت آن از {FoodPrice_FirstLoad} به {FoodPrice_New} و توضیحات آن از {FoodDescription_FirstLoad} به {FoodDescription_New} تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} و قیمت آن از {FoodPrice_FirstLoad} به {FoodPrice_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} و توضیحات آن از {FoodDescription_FirstLoad} به {FoodDescription_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) == false && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {FoodName_FirstLoad} به {FoodName_New} و قیمت از {FoodPrice_FirstLoad} به {FoodPrice_New} و توضیحات از {FoodDescription_FirstLoad} به {FoodDescription_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {FoodName_FirstLoad} از {FoodPrice_FirstLoad} به {FoodPrice_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {FoodName_FirstLoad} از {FoodPrice_FirstLoad} به {FoodPrice_New} و توضیحات آن از {FoodDescription_FirstLoad} به {FoodDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {FoodName_FirstLoad} از {FoodPrice_FirstLoad} به {FoodPrice_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) == false && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {FoodName_FirstLoad} از {FoodPrice_FirstLoad} به {FoodPrice_New} و توضیحات آن از {FoodDescription_FirstLoad} به {FoodDescription_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"توضیحات {FoodName_FirstLoad} از {FoodDescription_FirstLoad} به {FoodDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) == false && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"توضیحات {FoodName_FirstLoad} از {FoodDescription_FirstLoad} به {FoodDescription_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(FoodName_New) && string.IsNullOrEmpty(FoodPrice_New) && string.IsNullOrEmpty(FoodDescription_New) && string.IsNullOrEmpty(Select_FoodImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"عکس {FoodName_FirstLoad} تغییر کرد.";

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
						$"{FoodName} بروز رسانی گردید.";

					Infrastructure.Utility.WindowsNotification
						(message: message,
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
						picture: FoodImage);
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
		#endregion /UpdateDataFoodButton_Click

		//-----End of coding line

		#region Founctions
		//-----
		#region FoodLoad
		private void FoodLoad()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Food food =
					dataBaseContext.Foods
					.Where(current => string.Compare(current.FoodName, FoodName_FirstLoad, true) == 0)
					.FirstOrDefault();

				FoodName = null;
				FoodDescription_New = null;
				foodNameTextBox.Text = food.FoodName;

				FoodPrice = null;
				FoodPrice_Int = 0;
				foodPriceTextBox.Text = food.FoodPrice;
				foodPriceTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodPricePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				FoodPrice_FirstLoad = food.FoodPrice;

				FoodDescription = null;
				foodDescriptionTextBox.Text = food.FoodDescription;
				foodDescriptionTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				foodDescriptionPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				FoodDescription_FirstLoad = food.FoodDescription;

				FoodImage = null;
				FoodImage_New = null;
				FoodImage_FirstLoad = food.FoodImage;
				var byteImage = food.FoodImage;
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					foodImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
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
		#endregion /FoodLoad
		//-----
		#endregion /Founctions
	}
}
