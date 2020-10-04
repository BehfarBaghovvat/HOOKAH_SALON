using HOOKAH_SALON.Properties;
using System.Linq;
using System.Runtime.InteropServices;

namespace HOOKAH_SALON
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties
		private enum MarrideList
		{
			مجرد,
			متاهل,
			مطلقه,
		}
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PasswordConfirm { get; set; }
		public string Description { get; set; }
		public string UserImage { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Tel { get; set; }
		public string NationalCode { get; set; }
		public string Address { get; set; }
		private MarrideList marride;
		public string Marride { get; set; }
		public string RegisterDate { get; set; }
		public string RegisterTime { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region RegisterForm_Load
		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /RegisterForm_Load

		#region RegisterForm_MouseDown
		private void RegisterForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /RegisterForm_MouseDown

		#region TitlePanel_MouseDown
		private void TitlePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion TitlePanel_MouseDown

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizedButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region UsernameTextBox
		//-----
		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			usernameTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			usernameTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(usernameTextBox.Font.Size);
			usernameTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			usernameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			usernamePanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(usernameTextBox.Text, "نام کاربری") == 0)
			{
				usernameTextBox.Clear();
			}
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_KeyPress
		private void UsernameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_Leave
		private void UsernameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.Compare(usernameTextBox.Text, "نام کاربری") == 0)
			{
				usernameTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				usernamePanel.BackColor =
				Infrastructure.Utility.GrayColor();
				usernameTextBox.Text = "نام کاربری";
				usernameTextBox.Font =
					Infrastructure.Utility.IranSansFont(12);
				usernameTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				usernameTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				confirmUsernameTickPicturBox.Visible = false;
				Username = null;
				return;
			}
			else
			{
				Username = usernameTextBox.Text;
				if (UsernameConfirmation(Username) == true)
				{
					if ((Infrastructure.Utility.UserCheck2(Username) == true))
					{
						confirmUsernameTickPicturBox.Visible = true;
						confirmUsernameTickPicturBox.Image = Resources.Tik_True;
						usernameTextBox.ForeColor =
							Infrastructure.Utility.WhiteColor();
						usernamePanel.BackColor =
							Infrastructure.Utility.WhiteColor();
						Username = usernameTextBox.Text;
					}
					else
					{
						confirmUsernameTickPicturBox.Image = Resources.Tik_False;
						Username = null;
						usernameTextBox.Focus();
					}
				}
				else if (UsernameConfirmation(Username) == false)
				{
					confirmUsernameTickPicturBox.Visible = true;
					confirmUsernameTickPicturBox.Image = Resources.Tik_False;
					Username = null;
					usernameTextBox.Focus();
				}
			}
		}
		#endregion /UsernameTextBox_Leave

		#region UsernameTextBox_TextChanged
		private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.Compare(usernameTextBox.Text, "نام کاربری") == 0)
			{
				confirmUsernameTickPicturBox.Visible = false;
				return;
			}
			else
			{
				Username = usernameTextBox.Text;
				if (UsernameConfirmation(Username) == true)
				{
					if ((Infrastructure.Utility.UserCheck2(Username) == true))
					{
						confirmUsernameTickPicturBox.Visible = true;
						confirmUsernameTickPicturBox.Image = Resources.Tik_True;
						Username = usernameTextBox.Text;
					}
					else
					{
						confirmUsernameTickPicturBox.Visible = true;
						confirmUsernameTickPicturBox.Image = Resources.Tik_False;
						Username = null;
					}
				}
				else if (UsernameConfirmation(Username) == false)
				{
					confirmUsernameTickPicturBox.Image = Resources.Tik_False;
					Username = null;
				}
			}
		}
		#endregion /UsernameTextBox_TextChanged
		//-----
		#endregion /UsernameTextBox

		#region  EmailTextBox
		//-----
		#region EmailTextBox_Enter
		private void EmailTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			emailTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			emailTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emailTextBox.Font.Size);
			emailPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				emailTextBox.Clear();
			}
		}
		#endregion /EmailTextBox_Enter

		#region EmailTextBox_KeyPress
		private void EmailTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /EmailTextBox_KeyPress

		#region EmailTextBox_Leave
		private void EmailTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				emailTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				emailPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				emailTextBox.Font =
					Infrastructure.Utility.IranSansFont(12);

				emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
				emailTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				confirmEmailTickPicturBox.Visible = false;
				emailTextBox.Text = "پست الکترونیکی";
				Email = null;
			}
			else
			{
				Email = emailTextBox.Text;
				if (EmailConfirmation(Email) == true)
				{
					if ((Infrastructure.Utility.EmailChecker2(Email) == true))
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_True;
						emailTextBox.ForeColor =
							Infrastructure.Utility.WhiteColor();
						emailPanel.BackColor =
							Infrastructure.Utility.WhiteColor();
						Email = emailTextBox.Text;
					}
					else
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						emailTextBox.Focus();
						Email = null;
					}
				}
				else if (EmailConfirmation(Email) == false)
				{
					confirmEmailTickPicturBox.Visible = true;
					confirmEmailTickPicturBox.Image = Resources.Tik_False;
					emailTextBox.Focus();
					Email = null;
				}
			}
		}
		#endregion /EmailTextBox_Leave

		#region EmailTextBox_TextChanged
		private void EmailTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				confirmEmailTickPicturBox.Visible = false;
				return;
			}
			else
			{
				Email = emailTextBox.Text;
				if (EmailConfirmation(Email) == true)
				{
					if ((Infrastructure.Utility.EmailChecker2(Email) == true))
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_True;
						Email = emailTextBox.Text;
					}
					else
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						Email = null;
					}
				}
				else if (EmailConfirmation(Email) == false)
				{
					confirmEmailTickPicturBox.Visible = true;
					confirmEmailTickPicturBox.Image = Resources.Tik_False;
					Email = null;
				}
			}
		}
		#endregion /EmailTextBox_TextChanged
		//-----
		#endregion / EmailTextBox

		#region PasswordTextBox
		//-----
		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			passwordPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				passwordTextBox.Text = "رمز عبور";
				passwordTextBox.UseSystemPasswordChar = false;

				Password = string.Empty;
			}
			else
			{
				passwordTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Password = passwordTextBox.Text;
			}
		}
		#endregion /PasswordTextBox_Leave

		#region ShowPasswordPicturBox1_MouseDown
		private void PasswordShowPicturBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
				Properties.Resources.hide_512;

			if (string.Compare(passwordTextBox.Text, "رمز عبور") != 0)
			{
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /ShowPasswordPicturBox1_MouseDown

		#region ShowPasswordPicturBox1_MouseUp
		private void PasswordShowPicturBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
			Properties.Resources.show_512;
			if (string.Compare(passwordTextBox.Text, "رمز عبور") != 0)
			{
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /ShowPasswordPicturBox1_MouseUp 
		//-----
		#endregion

		#region PasswordConfirmTextBox
		//-----
		#region PasswordConfirmTextBox_Enter
		private void PasswordConfirmTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			passwordConfirmPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.Clear();
				passwordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordConfirmTextBox_Enter

		#region PasswordConfirmTextBox_Leave
		private void PasswordConfirmTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text) || string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();

				passwordConfirmPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				passwordConfirmTextBox.Text = "تایید رمز عبور";

				passwordConfirmTextBox.UseSystemPasswordChar = false;
				PasswordConfirm = string.Empty;
			}
			else
			{
				passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();

				passwordConfirmPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				PasswordConfirm = passwordConfirmTextBox.Text;
			}
		}
		#endregion /PasswordConfirmTextBox_Leave

		#region ShowPasswordPicturBox2_MouseDown
		private void PasswordShowPicturBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.hide_512;

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				passwordConfirmTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /ShowPasswordPicturBox2_MouseDown

		#region ShowPasswordPicturBox2_MouseUp
		private void PasswordShowPicturBox2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.show_512;
			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				passwordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /ShowPasswordPicturBox2_MouseUp 
		//-----
		#endregion /PasswordConfirmTextBox

		#region DescriptionTextBox
		//-----
		#region DescriptionTextBox_Enter
		private void DescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			descriptionTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			descriptionPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				descriptionTextBox.Clear();
			}
		}
		#endregion /DescriptionTextBox_Enter

		#region DescriptionTextBox_KeyPress
		private void DescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DescriptionTextBox_KeyPress

		#region DescriptionTextBox_Leave
		private void DescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) || string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				descriptionTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				descriptionTextBox.Text = "توضیحات";

				Description =null;
			}
			else
			{
				descriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Description = descriptionTextBox.Text;
			}
		}
		#endregion /DescriptionTextBox_Leave 
		//------
		#endregion /DescriptionTextBox

		#region AddPictureLinkLabel_LinkClicked
		private void AddPictureLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
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
				UserImage = openFileDialog.FileName;
				userImagePicturBox.BackgroundImage =
				System.Drawing.Image.FromFile(UserImage);
			}
			if (UserImage != string.Empty)
			{
				deleteImageButton.Visible = true;
			}
			else
			{
				deleteImageButton.Visible = false;
			}
		}
		#endregion /AddPictureLinkLabel_LinkClicked

		#region DeleteImageButton_Click
		private void DeleteImageButton_Click(object sender, System.EventArgs e)
		{
			UserImage = null;
			userImagePicturBox.BackgroundImage =
				Properties.Resources.user_1024;
			deleteImageButton.Visible = false;
		}
		#endregion /DeleteImageButton_Click

		#region FirstNameTextBox
		//-----
		#region FirstNameTextBox_Enter
		private void FirstNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			firstNameTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			firstNamePanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(firstNameTextBox.Text, "نام") == 0)
			{
				firstNameTextBox.Clear();
			}
		}
		#endregion /FirstNameTextBox_Enter

		#region FirstNameTextBox_KeyPress
		private void FirstNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /FirstNameTextBox_KeyPress

		#region FirstNameTextBox_Leave
		private void FirstNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.Compare(firstNameTextBox.Text, "نام") == 0)
			{
				firstNameTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				firstNamePanel.BackColor =
					Infrastructure.Utility.GrayColor();

				firstNameTextBox.Text = "نام";
				FirstName = string.Empty;
			}
			else
			{
				firstNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				firstNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				FirstName = firstNameTextBox.Text;
			}
		}
		#endregion /FirstNameTextBox_Leave 
		//-----
		#endregion /FirstNameTextBox

		#region LastNameTextBox
		//-----
		#region LastNameTextBox_Enter
		private void LastNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			lastNameTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			lastNamePanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(lastNameTextBox.Text, "نام خانوادگی") == 0)
			{
				lastNameTextBox.Clear();
			}
		}
		#endregion /LastNameTextBox_Enter

		#region LastNameTextBox_KeyPress
		private void LastNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /LastNameTextBox_KeyPress

		#region LastNameTextBox_Leave
		private void LastNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) || string.Compare(lastNameTextBox.Text, "نام خانوادگی") == 0)
			{
				lastNameTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				lastNamePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				lastNameTextBox.Text = "نام خانوادگی";
				LastName = string.Empty;
			}
			else
			{
				lastNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				lastNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();

				LastName = lastNameTextBox.Text;
			}
		}
		#endregion /LastNameTextBox_Leave 
		//-----
		#endregion /LastNameTextBox

		#region TelTextBox
		//-----
		#region TelTextBox_Enter
		private void TelTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			telTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			telPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(telTextBox.Text, "شماره تماس") == 0)
			{
				telTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Right;
				telTextBox.Clear();
			}
			else if (string.IsNullOrEmpty(Tel))
			{
				return;
			}
			else if (Tel.Contains('-') == true)
			{
				telTextBox.Text = Tel.Replace("-", string.Empty).Trim();
			}
		}
		#endregion /TelTextBox_Enter

		#region TelTextBox_KeyPress
		private void TelTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /TelTextBox_KeyPress

		#region TelTextBox_Leave
		private void TelTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(telTextBox.Text) || string.Compare(telTextBox.Text, "شماره تماس") == 0)
			{
				telTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				confirmTelPicturBox.Visible = false;
				telTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				telPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				telTextBox.Text = "شماره تماس";
				Tel = null;
			}
			else
			{
				Tel = telTextBox.Text;
				if (Tel.Length < 11)
				{
					confirmTelPicturBox.Visible = true;
					confirmTelPicturBox.Image = Resources.Tik_False;
					telTextBox.Focus();
					Tel = null;
					return;
				}
				else
				{
					if (TelConfirmation(Tel) == true)
					{
						telTextBox.ForeColor =
							Infrastructure.Utility.WhiteColor();
						telPanel.BackColor =
							Infrastructure.Utility.WhiteColor();

						if (telTextBox.Text.StartsWith("09"))
						{
							telTextBox.Text = telTextBox.Text.Insert(4, "-");
						}
						else
						{
							telTextBox.Text = telTextBox.Text.Insert(3, "-");
						}
						confirmTelPicturBox.Visible = true;
						confirmTelPicturBox.Image = Resources.Tik_True;
						Tel = telTextBox.Text;
					}
					else if (TelConfirmation(Tel) == false)
					{
						confirmTelPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						telTextBox.Focus();
						Tel = null;
					}
				}
			}
		}
		#endregion /TelTextBox_Leave 

		#region TelTextBox_TextChanged
		private void TelTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(telTextBox.Text) || string.Compare(telTextBox.Text, "شماره تماس") == 0)
			{
				confirmTelPicturBox.Visible = false;
				return;
			}
			else
			{
				Tel = telTextBox.Text;
				if (Tel.Length < 11)
				{
					confirmTelPicturBox.Visible = true;
					confirmTelPicturBox.Image = Resources.Tik_False;
					telTextBox.Focus();
					Tel = null;
					return;
				}
				else
				{
					if (TelConfirmation(Tel) == true)
					{
						confirmTelPicturBox.Visible = true;
						confirmTelPicturBox.Image = Resources.Tik_True;
						Tel = telTextBox.Text;
					}
					else if (TelConfirmation(Tel) == false)
					{
						confirmTelPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						Tel = null;
					}
				}
			}
		}
		#endregion /TelTextBox_TextChanged
		//-----
		#endregion TelTextBox

		#region NationalCodeTextBox
		//-----
		#region NationalCodeTextBox_Enter
		private void NationalCodeTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			nationalCodeTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			nationalCodePanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();


			if (string.Compare(nationalCodeTextBox.Text, "کد ملی") == 0)
			{
				nationalCodeTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Right;
				nationalCodeTextBox.Clear();
				return;
			}
			else if (string.IsNullOrEmpty(NationalCode))
			{
				return;
			}
			else if (NationalCode.Contains('-') == true)
			{
				nationalCodeTextBox.Text = NationalCode.Replace("-", string.Empty).Trim();
			}
		}
		#endregion /NationalCodeTextBox_Enter

		#region NationalCodeTextBox_KeyPress
		private void NationalCodeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /NationalCodeTextBox_KeyPress

		#region NationalCodeTextBox_Leave
		private void NationalCodeTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text) || string.Compare(nationalCodeTextBox.Text, "کد ملی") == 0)
			{
				confirmNationalCodePicturBox.Visible = false;
				nationalCodeTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				nationalCodePanel.BackColor =
					Infrastructure.Utility.GrayColor();
				nationalCodeTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				nationalCodeTextBox.Text = "کد ملی";
				NationalCode = null;
			}
			else
			{
				NationalCode = nationalCodeTextBox.Text;
				NationalCode = nationalCodeTextBox.Text;
				if (NationalCode.Length < 10)
				{
					confirmNationalCodePicturBox.Visible = true;
					confirmNationalCodePicturBox.Image = Resources.Tik_False;
					nationalCodeTextBox.Focus();
					NationalCode = null;
					return;
				}
				else
				{
					if (NationalCodeConfirmation(NationalCode) == true)
					{
						nationalCodeTextBox.ForeColor = 
							Infrastructure.Utility.WhiteColor();
						nationalCodePanel.BackColor = 
							Infrastructure.Utility.WhiteColor();
						confirmNationalCodePicturBox.Visible = true;
						nationalCodeTextBox.Text = nationalCodeTextBox.Text.Insert(3, "-").Insert(10, "-");
						confirmNationalCodePicturBox.Image = Resources.Tik_True;
						NationalCode = nationalCodeTextBox.Text;
					}
					else if (NationalCodeConfirmation(NationalCode) == false)
					{
						confirmNationalCodePicturBox.Visible = true;
						confirmNationalCodePicturBox.Image = Resources.Tik_False;
						nationalCodeTextBox.Focus();
						NationalCode = null;
					}
				}
			}
		}
		#endregion /NationalCodeTextBox_Leave

		#region NationalCodeTextBox_TextChanged
		private void NationalCodeTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text) || string.Compare(nationalCodeTextBox.Text, "کد ملی") == 0)
			{
				confirmNationalCodePicturBox.Visible = false;
				return;
			}
			else
			{
				NationalCode = nationalCodeTextBox.Text;
				if (NationalCode.Length < 10)
				{
					confirmNationalCodePicturBox.Visible = true;
					confirmNationalCodePicturBox.Image = Resources.Tik_False;
					nationalCodeTextBox.Focus();
					NationalCode = null;
					return;
				}
				else
				{
					if (NationalCodeConfirmation(NationalCode) == true)
					{
						confirmNationalCodePicturBox.Visible = true;
						confirmNationalCodePicturBox.Image = Resources.Tik_True;
						NationalCode = nationalCodeTextBox.Text;
					}
					else if (NationalCodeConfirmation(NationalCode) == false)
					{
						confirmNationalCodePicturBox.Visible = true;
						confirmNationalCodePicturBox.Image = Resources.Tik_False;
						NationalCode = null;
					}
				}
			}
		}
		#endregion /NationalCodeTextBox_TextChanged
		//-----
		#endregion /NationalCodeTextBox

		#region AddressTextBox
		//-----
		#region AddressTextBox_Enter
		private void AddressTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			addressTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			addressPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			if (string.Compare(addressTextBox.Text, "آدرس") == 0)
			{
				addressTextBox.Clear();
			}
		}
		#endregion /AddressTextBox_Enter

		#region AddressTextBox_KeyPress
		private void AddressTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /AddressTextBox_KeyPress

		#region AddressTextBox_Leave
		private void AddressTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, "آدرس") == 0)
			{
				addressTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				addressPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				addressTextBox.Text = "آدرس";
				Address = null;
			}
			else
			{
				if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, "آدرس") == 0)
				{
					confirmAddresspicturBox.Visible = false;
					return;
				}
				else
				{
					Address = addressTextBox.Text;
					if (AddressConfimation(Address) == true)
					{
						addressTextBox.ForeColor = 
							Infrastructure.Utility.WhiteColor();
						addressPanel.BackColor = 
							Infrastructure.Utility.WhiteColor();
						confirmAddresspicturBox.Visible = true;
						confirmAddresspicturBox.Image = Resources.Tik_True;
						Address = addressTextBox.Text;
					}
					else if (AddressConfimation(Address) == false)
					{
						confirmAddresspicturBox.Visible = true;
						confirmAddresspicturBox.Image = Resources.Tik_False;
						addressTextBox.Focus();
						Address = null;
					}
				}
			}
		}
		#endregion /AddressTextBox_Leave

		#region AddressTextBox_TextChanged
		private void AddressTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, "آدرس") == 0)
			{
				confirmAddresspicturBox.Visible = false;
				return;
			}
			else
			{
				Address = addressTextBox.Text;
				if (AddressConfimation(Address) == true)
				{
					confirmAddresspicturBox.Visible = true;
					confirmAddresspicturBox.Image = Resources.Tik_True;
					Address = addressTextBox.Text;
				}
				else if (AddressConfimation(Address) == false)
				{
					confirmAddresspicturBox.Visible = true;
					confirmAddresspicturBox.Image = Resources.Tik_False;
					Address = null;
				}
			}
		}
		#endregion /AddressTextBox_TextChanged
		//-----
		#endregion /AddressTextBox

		#region MarriedRadioButton_CheckedChanged
		private void MarriedRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			Marride = null;
			marride = MarrideList.متاهل;
			Marride = marride.ToString();
		}
		#endregion /MarriedRadioButton_CheckedChanged

		#region SingleRadioButton_CheckedChanged
		private void SingleRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			Marride = null;
			marride = MarrideList.مجرد;
			Marride = marride.ToString();
		}
		#endregion /SingleRadioButton_CheckedChanged

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetButton_Click

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string inputError = string.Empty;

				#region Validation
				if (string.IsNullOrEmpty(Username))
				{
					inputError =
						"فیلد شناسه کاربری را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Email))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"فیلد پست الکترونیکی را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Password))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"فیلد رمز عبور را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(PasswordConfirm))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"فیلد تایید رمز عبور را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(UserImage))
				{
					if (string.IsNullOrEmpty(inputError)== false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"تصویر کاربر را انتخاب نمایید!";
				}
				if (string.IsNullOrEmpty(FirstName))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"فیلد نام را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(LastName))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"فیلد نام خانوادگی را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Tel))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"فیلد شماره تماس را تکمیل کنید!";
				}
				if (string.IsNullOrEmpty(Marride))
				{
					if (string.IsNullOrEmpty(inputError) == false)
					{
						inputError +=
							System.Environment.NewLine;
					}
					inputError +=
						"وضعیت تاهل را تعیین کنید!";
				}
				//------------------------------------------------
				if (string.IsNullOrEmpty(inputError) != true)
				{
					if (string.IsNullOrEmpty(Username))
					{
						usernameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Email))
					{
						emailTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Password))
					{
						passwordTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(PasswordConfirm))
					{
						passwordConfirmTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(FirstName))
					{
						firstNameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(LastName))
					{
						lastNameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Tel))
					{
						telTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Marride))
					{
						singleRadioButton.Focus();
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: inputError,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}

				if (string.IsNullOrEmpty(inputError) != true)
				{
					if (string.IsNullOrEmpty(UserImage))
					{

						System.Windows.Forms.OpenFileDialog openFileDialog =
								new System.Windows.Forms.OpenFileDialog
								{
									Filter =
									"JPG (*.jpg)|*.jpg|" +
									"PNG (*.png)|*.png|" +
									"BMP (*.bmp)|*.bmp",
									Title = "Load user picture ",
								};
						if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							UserImage = openFileDialog.FileName;
							userImagePicturBox.BackgroundImage =
							System.Drawing.Image.FromFile(UserImage);
						}
						if (UserImage != string.Empty)
						{
							deleteImageButton.Visible = true;
						}
						else
						{
							deleteImageButton.Visible = false;
						}
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: inputError,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				




				if (Infrastructure.Utility.PasswordSet(password: Password, passwordConfirm: PasswordConfirm) == false)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: "عدم تطابق پسوردها",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					passwordTextBox.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text) || string.Compare(nationalCodeTextBox.Text, "کد ملی") == 0)
				{
					NationalCode = null;
				}
				if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, "آدرس") == 0)
				{
					Address = null;
				}
				#endregion/Validation

				System.Windows.Forms.DialogResult dialogResult;
				string message = $"نام کاربری {Username} ذخیره گردد؟.";

				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: message,
						caption: "ذخیره اطلاعات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.User username =
								dataBaseContext.Users
								.Where(current => string.Compare(current.Username, Username) == 0)
								.FirstOrDefault();

					if (username != null)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: $"نام کاربری {Username} در سیستم موجود میباشد. لطفا از نام دیگری استفاده نمایید.",
						caption: "اطلاعات مشابه",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						usernameTextBox.Focus();
						return;
					}
					else
					{
						RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						RegisterTime = Infrastructure.Utility.ShowTime();

						username =
							new Models.User
							{
								IsActive = true,
								Access_Level = "کاربر ساده",
								Username = Username,
								Email = Email,
								Password = Password,
								Description = Description,
								First_Name = FirstName,
								Last_Name = LastName,
								Telephone = Tel.Replace("-", ""),
								National_Code = NationalCode,
								Marital_Status = Marride,
								Address = Address,
								Registration_Date = RegisterDate,
								Registration_Time = RegisterTime,

								User_Image = System.IO.File.ReadAllBytes(UserImage),
							};

						dataBaseContext.Users.Add(username);
						dataBaseContext.SaveChanges();
					}
				}
				else
				{
					return;
				}
				string successMessage =
					$"اطلاعات کاربر {Username} با موفقیت ذخیره گرید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
					picture: UserImage);

				AllClear();
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
		#endregion /SaveButton_Click

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult;

			if (string.IsNullOrEmpty(Username) != true ||
				string.IsNullOrEmpty(Email) != true ||
				string.IsNullOrEmpty(Password) != true ||
				string.IsNullOrEmpty(PasswordConfirm) != true ||
				string.IsNullOrEmpty(Description) != true ||
				string.IsNullOrEmpty(UserImage) != true ||
				string.IsNullOrEmpty(FirstName) != true ||
				string.IsNullOrEmpty(LastName) != true ||
				string.IsNullOrEmpty(Tel) != true ||
				string.IsNullOrEmpty(NationalCode) != true ||
				string.IsNullOrEmpty(Address) != true)
			{
				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: "آیا از ادامه ثبت نام صرفه نظر کردید؟",
					caption: "انصراف از ثبت نام",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					this.Hide();
					Program.LoginShow();
				}
			}
			else
			{
				this.Hide();
				Program.LoginShow();
				return;
			}
		}
		#endregion

		//-----End of coding line

		#region Functions
		//*****
		#region UsernameConfirmation
		private bool UsernameConfirmation(string username)
		{
			bool status;
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, username) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			return status;
		}
		#endregion /UsernameConfirmation

		#region EmailConfirmation
		private bool EmailConfirmation(string email)
		{
			bool status;
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Email, email) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			return status;
		}
		#endregion /EmailConfirmation

		#region PasswordMatching
		
		#endregion PasswordMatching

		#region TelConfirmation
		private static bool TelConfirmation(string tel)
		{
			bool status;
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Telephone, tel) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			return status;
		}
		#endregion /TelConfirmation

		#region NationalCodeConfirmation
		private static bool NationalCodeConfirmation(string nationalCode)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.National_Code, nationalCode) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;
		}
		#endregion /NationalCodeConfirmation

		#region AddressConfimation
		private static bool AddressConfimation(string address)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Address, address) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;
		}
		#endregion /AddressConfimation

		#region AllClear
		private void AllClear()
		{
			Username = null;
			usernameTextBox.Text =
				"نام کاربری";
			usernameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			usernameTextBox.Font =
				Infrastructure.Utility.IranSansFont(usernameTextBox.Font.Size);
			usernameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			usernamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmUsernameTickPicturBox.Visible = false;

			Email = null;
			emailTextBox.Text =
				"پست الکترونیکی";
			emailTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			emailTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
			emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			emailPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmEmailTickPicturBox.Visible = false;

			Password = null;
			passwordTextBox.Text =
				"رمز عبور";
			passwordTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			passwordTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			passwordPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			passwordTextBox.UseSystemPasswordChar = false;

			PasswordConfirm = null;
			passwordConfirmTextBox.Text =
				"تایید رمز عبور";
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			passwordConfirmTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			passwordConfirmPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			passwordConfirmTextBox.UseSystemPasswordChar = false;

			UserImage = null;
			userImagePicturBox.BackgroundImage =
				Properties.Resources.user_1024;
			deleteImageButton.Visible = false;

			FirstName = null;
			firstNameTextBox.Text =
				"نام";
			firstNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			firstNameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			firstNamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();

			LastName = null;
			lastNameTextBox.Text =
				"نام خانوادگی";
			lastNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			lastNameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			lastNamePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();

			Tel = null;
			telTextBox.Text =
				"شماره تماس";
			telTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			telTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			telPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmTelPicturBox.Visible = false;

			NationalCode = null;
			nationalCodeTextBox.Text =
				"کد ملی";
			nationalCodeTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			nationalCodeTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			nationalCodePanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmNationalCodePicturBox.Visible = false;

			Address = null;
			addressTextBox.Text =
				"آدرس";
			addressTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			addressTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
			addressPanel.BackColor =
				Infrastructure.Utility.DimGrayColor();
			confirmAddresspicturBox.Visible = false;

			marriedRadioButton.Checked = false;
			singleRadioButton.Checked = false;
			Marride = null;
		}
		#endregion /AllClear
		//*****
		#endregion /Functions
	}
}
