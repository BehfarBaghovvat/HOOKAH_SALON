using System;
using System.Linq;

namespace HOOKAH_SALON.Store
{
	public partial class HookahEditFrom : Infrastructure.BaseForm
	{
		

		public HookahEditFrom()
		{
			InitializeComponent();
		}

		#region Properties
		public string HookahName_FirstLoad { get; set; }
		public string HookahName_New { get; private set; }
		public string HookahName { get; private set; }
		public string HookahPrice_FirstLoad { get; private set; }
		public string HookahPrice_New { get; set; }
		public int HookahPrice_Int { get; private set; }
		public string HookahPrice { get; set; }
		public string HookahDescription_FirstLoad { get; private set; }
		public string HookahDescription_New { get; set; }
		public string HookahDescription { get; set; }
		public byte[] HookahImage_FirstLoad { get; set; }
		public byte[] HookahImage_New { get; set; }
		public byte[] HookahImage { get; set; }
		public string Select_HookahImage { get; set; }
		public string HookahUpdateTime { get; set; }
		public int HookahNumberUpdate { get; set; }
		public HOOKAH_SALON.Store.HookahStoreForm MyHookahStoreForm { get; set; }
		public string EventRegisterDate { get; private set; }
		public string EventTitle { get; private set; }
		public string Username { get; private set; }
		public string FullName { get; private set; }
		public string EventDate { get; private set; }
		public string EventTime { get; private set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region HookahEditFrom_Load
		private void HookahEditFrom_Load(object sender, System.EventArgs e)
		{
			FormLoad();
		}
		#endregion /HookahEditFrom_Load

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

		#region HookahNameTextBox_Enter
		private void HookahNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			hookahNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(hookahNameTextBox.Text, HookahName_FirstLoad) == 0)
			{
				hookahNameTextBox.Select(hookahNameTextBox.Text.Length, 0);
				HookahName_New = null;
			}
			else
			{
				return;
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
			if (string.IsNullOrWhiteSpace(hookahNameTextBox.Text) || string.Compare(hookahNameTextBox.Text, HookahName_FirstLoad) == 0)
			{
				hookahNameTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				hookahNamePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
				hookahNameTextBox.Text = HookahName_FirstLoad;
				HookahName_New = null;
			}
			else
			{
				hookahNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				HookahName_New = hookahNameTextBox.Text;
			}
		}
		#endregion /HookahNameTextBox_Leave

		#region HookahNameTextBox_TextChanged
		private void HookahNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hookahNameTextBox.Text) || string.Compare(hookahNameTextBox.Text, HookahName_FirstLoad) == 0)
			{
				hookahNameTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				hookahNamePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
			}
			else
			{
				hookahNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /HookahNameTextBox_TextChanged

		#region HookahPriceTextBox_Enter
		private void HookahPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			hookahNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(hookahPriceTextBox.Text, HookahPrice_FirstLoad) == 0)
			{
				hookahPriceTextBox.Select(0, hookahPriceTextBox.Text.LastIndexOf(" ") - 1);
				hookahPriceTextBox.Clear();
				HookahPrice_New = null;
				HookahPrice_Int = 0;
				return;
			}
			else
			{
				hookahPriceTextBox.Select(0, hookahPriceTextBox.Text.LastIndexOf(" ") - 1);
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
			if (string.IsNullOrWhiteSpace(hookahPriceTextBox.Text) || string.Compare(hookahPriceTextBox.Text, HookahPrice_FirstLoad) == 0)
			{
				hookahNameTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				hookahPriceTextBox.Text = HookahPrice_FirstLoad;
				HookahPrice_New = null;
				HookahPrice_Int = 0;
			}
			else
			{
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				HookahPrice_New = hookahPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				HookahPrice_Int = int.Parse(HookahPrice_New.Replace(",", string.Empty).Trim());
				hookahPriceTextBox.Text = $"{HookahPrice_Int:#,0} تومان";
				HookahPrice_New = hookahPriceTextBox.Text;
			}
		}
		#endregion /HookahPriceTextBox_Leave

		#region HookahPriceTextBox_TextChanged
		private void HookahPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hookahPriceTextBox.Text) || string.Compare(hookahPriceTextBox.Text, HookahPrice_FirstLoad) == 0)
			{
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
			}
			else
			{
				hookahPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /HookahPriceTextBox_TextChanged

		#region HookahDescriptionTextBox_Enter
		private void HookahDescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			hookahDescriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			hookahDescriptionPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(hookahDescriptionTextBox.Text,HookahDescription_FirstLoad) == 0)
			{
				hookahDescriptionTextBox.Clear();
				HookahDescription_New = null;
			}
			else
			{
				return;
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
			if (string.IsNullOrWhiteSpace(hookahDescriptionTextBox.Text) || string.Compare(hookahDescriptionTextBox.Text, HookahDescription_FirstLoad) == 0)
			{
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
				hookahDescriptionTextBox.Text = HookahDescription_FirstLoad;
				HookahDescription_New = null;
			}
			else
			{
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				HookahDescription_New = hookahDescriptionTextBox.Text;
			}
		}
		#endregion /HookahDescriptionTextBox_Leave

		#region HookahDescriptionTextBox_TextChanged
		private void HookahDescriptionTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(hookahDescriptionTextBox.Text) || string.Compare(hookahDescriptionTextBox.Text, HookahDescription_FirstLoad) == 0)
			{
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.DarkDimGary();
			}
			else
			{
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /HookahDescriptionTextBox_TextChanged

		#region HookahImagePicturBox_MouseDoubleClick
		private void HookahImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load Hookah Picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Select_HookahImage = openFileDialog.FileName;
				hookahImagePicturBox.Image =
				System.Drawing.Image.FromFile(Select_HookahImage);
				HookahImage_New = System.IO.File.ReadAllBytes(Select_HookahImage);
			}
			else
			{
				Select_HookahImage = null;
				HookahImage_New = null;
				deleteHookahImageButton.Visible = false;
			}
		}
		#endregion /HookahImagePicturBox_MouseDoubleClick

		#region DeleteHookahImageButton_Click
		private void DeleteHookahImageButton_Click(object sender, System.EventArgs e)
		{
			HookahImage_New = null;
			Select_HookahImage = null;
			HookahImage = null;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(HookahImage_FirstLoad))
			{
				hookahImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
			}
			deleteHookahImageButton.Visible = false;
		}
		#endregion /DeleteHookahImageButton_Click

		#region UpdateDataHookahButton_Click
		private void UpdateDataHookahButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string hookaName = null;

				if (string.IsNullOrEmpty(HookahName_New))
				{
					HookahName = HookahName_FirstLoad;
				}
				else
				{
					HookahName = HookahName_New;
				}

				if (string.IsNullOrEmpty(HookahPrice_New))
				{
					HookahPrice = HookahPrice_FirstLoad;
				}
				else
				{
					HookahPrice = HookahPrice_New;
				}

				if (string.IsNullOrEmpty(HookahDescription_New))
				{
					HookahDescription = HookahDescription_FirstLoad;
				}
				else
				{
					HookahDescription = HookahDescription_New;
				}

				if (string.IsNullOrEmpty(Select_HookahImage))
				{
					HookahImage = HookahImage_FirstLoad;
				}
				else
				{
					HookahImage = HookahImage_New;
				}


				System.Windows.Forms.DialogResult dialogResult;
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: $"{HookahName} به روز گردد؟",
					caption: "به روز رسانی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Hookah hookah =
					dataBaseContext.Hookahs
					.Where(current => string.Compare(current.HookahName, HookahName_FirstLoad, false) == 0)
					.FirstOrDefault();

					HookahNumberUpdate = hookah.NumberUpdate;
					HookahUpdateTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					HookahNumberUpdate++;
					
					hookah.HookahName = HookahName;
					hookah.HookahPrice = HookahPrice;
					hookah.HookahDescription = HookahDescription;
					hookah.HookahImage = HookahImage;
					hookah.UpdateTime = HookahUpdateTime;
					hookah.NumberUpdate = HookahNumberUpdate;

					dataBaseContext.SaveChanges();

					//-----جهت بارگذاری اطلاعات قلیان در جدول داده 
					if (HOOKAH_SALON.MainForm.HookahStoreForm != null)
					{
						HOOKAH_SALON.MainForm.HookahStoreForm.HookahLoader();
					}

					#region EventLogForFood
					if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage))
					{
						return;
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} و مبلغ آن از {HookahPrice_FirstLoad} به {HookahPrice_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New}و توضیحات آن از {HookahDescription_FirstLoad} به {HookahDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} و قیمت آن از {HookahPrice_FirstLoad} به {HookahPrice_New} و توضیحات آن از {HookahDescription_FirstLoad} به {HookahDescription_New} تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} و قیمت آن از {HookahPrice_FirstLoad} به {HookahPrice_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} و توضیحات آن از {HookahDescription_FirstLoad} به {HookahDescription_New} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) == false && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"نام {HookahName_FirstLoad} به {HookahName_New} و قیمت از {HookahPrice_FirstLoad} به {HookahPrice_New} و توضیحات از {HookahDescription_FirstLoad} به {HookahDescription_FirstLoad} و عکس آن تغییر یافت.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {HookahName_FirstLoad} از {HookahPrice_FirstLoad} به {HookahPrice_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {HookahName_FirstLoad} از {HookahPrice_FirstLoad} به {HookahPrice_New} و توضیحات آن از {HookahDescription_New} به {HookahDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {HookahName_FirstLoad} از {HookahPrice_FirstLoad} به {HookahPrice_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) == false && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"قیمت {HookahName_FirstLoad} از {HookahPrice_FirstLoad} به {HookahPrice_New} و توضیحات آن از {HookahDescription_New} به {HookahDescription_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage))
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"توضیحات {HookahName_FirstLoad} از {HookahDescription_New} به {HookahDescription_New} تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) == false && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"توضیحات {HookahName_FirstLoad} از {HookahDescription_New} به {HookahDescription_New} و عکس آن تغییر کرد.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
					else if (string.IsNullOrEmpty(HookahName_New) && string.IsNullOrEmpty(HookahPrice_New) && string.IsNullOrEmpty(HookahDescription_New) && string.IsNullOrEmpty(Select_HookahImage) == false)
					{
						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"عکس {HookahName_FirstLoad} تغییر کرد.";

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
						$"{HookahName} بروز رسانی گردید.";

					Infrastructure.Utility.WindowsNotification
						(message: message,
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
						picture: HookahImage);
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
		#endregion /UpdateDataHookahButton_Click

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

				Models.Hookah hookah =
					dataBaseContext.Hookahs
					.Where(current => string.Compare(current.HookahName, HookahName_FirstLoad, true) == 0)
					.FirstOrDefault();

				HookahName = null;
				HookahName_New = null;
				hookahNameTextBox.Text = hookah.HookahName;

				HookahPrice = null;
				HookahName_New = null;
				HookahPrice_Int = 0;
				hookahPriceTextBox.Text = hookah.HookahPrice;
				HookahPrice_FirstLoad = hookah.HookahPrice;
				hookahPriceTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				hookahPricePanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				HookahDescription = null;
				HookahDescription_New = null;
				hookahDescriptionTextBox.Text = hookah.HookahDescription;
				HookahDescription_FirstLoad = hookah.HookahDescription;
				hookahDescriptionTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				hookahDescriptionPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				HookahImage = null;
				HookahImage_New = null;
				Select_HookahImage = null;
				HookahImage_FirstLoad = hookah.HookahImage;
				var byteImage = hookah.HookahImage;
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					hookahImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
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
