using BunifuAnimatorNS;
using HOOKAH_SALON.Properties;
using Stimulsoft.Controls.Win.Editors;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace HOOKAH_SALON
{
	public partial class EditUsernameForm : Infrastructure.BaseForm
	{

		#region Properties
		//-----
		public string Username { get; set; }
		public string Old_Email { get; private set; }
		public string New_Email { get; private set; }
		public string Old_Password { get; private set; }
		public string New_Password { get; private set; }
		public string New_PasswordConfirm { get; private set; }
		public string Old_Description { get; private set; }
		public string New_Description { get; private set; }
		public byte[] Old_UserImage { get; private set; }
		public byte[] New_UserImage { get; set; }
		public string Select_UserImage { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Old_Tel { get; private set; }
		public string Tel { get; set; }
		public string New_Tel { get; private set; }
		public string NationalCode { get; private set; }
		public string Old_Address { get; private set; }
		public string New_Address { get; private set; }
		private enum MarrideList
		{
			مجرد,
			متاهل,
			مطلقه,
		}
		public string Old_Marride { get; private set; }
		public string New_Marride { get; private set; }
		public string RegisterDate { get; private set; }
		public string RegisterTime { get; private set; }
		private MarrideList marride;
		//-----
		#endregion /Properties

		//#region LoginForm
		//private LoginForm loginForm = null;
		//public LoginForm LoginForm
		//{
		//	get
		//	{
		//		if (loginForm == null || loginForm.IsDisposed == true)
		//		{
		//			loginForm =
		//				new LoginForm();
		//		}
		//		return loginForm;
		//	}
		//}
		//#endregion /LoginForm

		#region MainForm
		private MainForm mainForm;
		public MainForm MainForm
		{
			get
			{
				if (mainForm == null || mainForm.IsDisposed == true)
				{
					mainForm =
						new MainForm();
				}
				return mainForm;
			}
			set { mainForm = value; }
		}

		public string EventRegisterDate { get; private set; }
		public string EventTitle { get; private set; }
		#endregion /MainForm

		//-----------------------------------------------------------------------------------------------

		public EditUsernameForm()
		{
			InitializeComponent();
		}

		//-----The beginning of the coding line.

		#region EditUsernameForm_Load
		private void EditUsernameForm_Load(object sender, System.EventArgs e)
		{
			UserLoaded();
		}
		#endregion /EditUsernameForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			if (CheckInformation() == true)
			{
				this.Close();
				return;
			}
			else
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: "آیا از به روز رسانی منصرف شدید؟",
					caption: "انصراف از به روز رسانی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					this.Close();
				}
			}
		}
		#endregion /CloseButton_Click

		#region MinimizedButton_Click
		private void MinimizedButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizedButton_Click

		#region UsernameTextBox_TextChanged
		private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(usernameTextBox.Text, Username) == 0)
			{
				usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				usernameTextBox.Font = Infrastructure.Utility.CenturyGothicFont(emSize: 12);
				usernameTextBox.ForeColor = Infrastructure.Utility.LimeColor();
			}
		}
		#endregion /UsernameTextBox_TextChanged

		#region EmailTextBox_Enter
		private void EmailTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			emailTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			emailTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emSize: 12);
			emailPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(emailTextBox.Text, Old_Email) == 0)
			{
				emailTextBox.Select(0, emailTextBox.Text.Length);
			}
		}
		#endregion /EmailTextBox_Enter

		#region EmailTextBox_KeyPress
		private void EmailTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
			if (string.Compare(emailTextBox.Text, Old_Email) == 0)
			{
				emailTextBox.Clear();
			}
		}
		#endregion /EmailTextBox_KeyPress

		#region EmailTextBox_Leave
		private void EmailTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.Compare(emailTextBox.Text, Old_Email) == 0)
			{
				emailTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				emailPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				confirmEmailTickPicturBox.Visible = false;
				emailTextBox.Text = Old_Email;
				New_Email = null;
			}
			else
			{
				New_Email = emailTextBox.Text;
				if (EmailConfirmation(New_Email) == true)
				{
					if ((Infrastructure.Utility.EmailChecker2(New_Email) == true))
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_True;
						emailTextBox.ForeColor =
							Infrastructure.Utility.WhiteColor();
						emailPanel.BackColor =
							Infrastructure.Utility.WhiteColor();
						New_Email = emailTextBox.Text;
					}
					else
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						emailTextBox.Focus();
						New_Email = null;
					}
				}
				else if (EmailConfirmation(New_Email) == false)
				{
					confirmEmailTickPicturBox.Visible = true;
					confirmEmailTickPicturBox.Image = Resources.Tik_False;
					emailTextBox.Focus();
					New_Email = null;
				}
			}
		}
		#endregion /EmailTextBox_Leave

		#region EmailTextBox_TextChanged
		private void EmailTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(emailTextBox.Text, Old_Email) == 0)
			{
				emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;
				emailTextBox.Font = Infrastructure.Utility.CenturyGothicFont(emSize: 12);
				emailTextBox.ForeColor = Infrastructure.Utility.GrayColor();
				confirmEmailTickPicturBox.Visible = false;
			}
			else
			{
				if (string.IsNullOrWhiteSpace(emailTextBox.Text))
				{
					confirmEmailTickPicturBox.Visible = false;
					return;
				}
				else
				{
					emailTextBox.ForeColor =
						Infrastructure.Utility.MediumSlateBlueColor();
					emailPanel.BackColor =
						Infrastructure.Utility.MediumSlateBlueColor();

					New_Email = emailTextBox.Text;
					if (EmailConfirmation(New_Email) == true)
					{
						if ((Infrastructure.Utility.EmailChecker2(New_Email) == true))
						{
							confirmEmailTickPicturBox.Visible = true;
							confirmEmailTickPicturBox.Image = Resources.Tik_True;
							New_Email = emailTextBox.Text;
						}
						else
						{
							confirmEmailTickPicturBox.Visible = true;
							confirmEmailTickPicturBox.Image = Resources.Tik_False;
							New_Email = null;
						}
					}
					else if (EmailConfirmation(New_Email) == false)
					{
						confirmEmailTickPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						New_Email = null;
					}
				}
			}
		}
		#endregion /EmailTextBox_TextChanged

		#region OldPasswordTextBox_Enter
		private void OldPasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			oldPasswordTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			oldPasswordTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emSize: 12);
			oldPasswordTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			oldPasswordPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(oldPasswordTextBox.Text, "رمز قدیم") == 0)
			{
				oldPasswordTextBox.Clear();
				oldPasswordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /OldPasswordTextBox_Enter

		#region OldPasswordTextBox_Leave
		private void OldPasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(oldPasswordTextBox.Text, "رمز قدیم") == 0 || string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
			{
				oldPasswordTextBox.Font =
					Infrastructure.Utility.IranSansFont(12);
				oldPasswordTextBox.UseSystemPasswordChar = false;
				oldPasswordTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				oldPasswordPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				oldPasswordTextBox.Text = "رمز قدیم";
				
				return;
			}
			else if (string.Compare(oldPasswordTextBox.Text, Old_Password) == 0)
			{
				oldPasswordTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				oldPasswordPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
			else
			{
				return;
			}
		}
		#endregion /OldPasswordTextBox_Leave

		#region OldPasswordTextBox_TextChanged
		private void OldPasswordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if ((string.Compare(oldPasswordTextBox.Text, "رمز قدیم") == 0))
			{
				oldPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				oldPasswordTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				oldPasswordPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				emailTextBox.Enabled = false;
				newPasswordTextBox.Enabled = false;
				newPasswordConfirmTextBox.Enabled = false;
				addPictureLinkLabel.Enabled = false;
				telTextBox.Enabled = false;
				addressTextBox.Enabled = false;
				maritalStatusGroupBox.Enabled = false;
				updateButton.Enabled = false;
				return;
			}
			else if  (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text) || string.Compare(oldPasswordTextBox.Text, Old_Password) != 0)
			{
				oldPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				emailTextBox.Enabled = false;
				newPasswordTextBox.Enabled = false;
				newPasswordConfirmTextBox.Enabled = false;
				addPictureLinkLabel.Enabled = false;
				telTextBox.Enabled = false;
				addressTextBox.Enabled = false;
				maritalStatusGroupBox.Enabled = false;
				updateButton.Enabled = false;
				return;
			}
			else if (string.Compare(oldPasswordTextBox.Text, Old_Password) == 0)
			{
				oldPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				emailTextBox.Enabled = true;
				newPasswordTextBox.Enabled = true;
				newPasswordConfirmTextBox.Enabled = true;
				addPictureLinkLabel.Enabled = true;
				telTextBox.Enabled = true;
				addressTextBox.Enabled = true;
				maritalStatusGroupBox.Enabled = true;
				updateButton.Enabled = true;
			}
		}
		#endregion /OldPasswordTextBox_TextChanged

		#region OldPasswordShowPicturBox_MouseDown
		private void OldPasswordShowPicturBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			oldPasswordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /OldPasswordShowPicturBox_MouseDown

		#region OldPasswordShowPicturBox_MouseUp
		private void OldPasswordShowPicturBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			oldPasswordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /OldPasswordShowPicturBox_MouseUp

		#region NewPasswordTextBox_Enter
		private void NewPasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			newPasswordTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			newPasswordTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emSize: 12);
			newPasswordTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			newPasswordPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(newPasswordTextBox.Text, "رمز جدید") == 0)
			{
				newPasswordTextBox.Clear();
				newPasswordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /NewPasswordTextBox_Leave

		#region NewPasswordTextBox_Leave
		private void NewPasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text) || string.Compare(newPasswordTextBox.Text, "رمز جدید") == 0)
			{
				newPasswordTextBox.RightToLeft = 
					System.Windows.Forms.RightToLeft.Yes;
				newPasswordTextBox.Font =
					Infrastructure.Utility.IranSansFont(emSize: 12);
				newPasswordTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				newPasswordPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				newPasswordTextBox.Text = "رمز جدید";
				newPasswordTextBox.UseSystemPasswordChar = false;
				New_Password = null;
			}
			else
			{
				newPasswordTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
				newPasswordTextBox.Font =
					Infrastructure.Utility.CenturyGothicFont(emSize: 12);
				newPasswordTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				newPasswordPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				New_Password = newPasswordTextBox.Text;
			}
		}
		#endregion /NewPasswordTextBox_Leave

		#region PasswordShowPicturBox1_MouseDown
		private void PasswordShowPicturBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
				Properties.Resources.hide_512;

			if (string.Compare(newPasswordTextBox.Text, "رمز عبور") != 0)
			{
				newPasswordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordShowPicturBox1_MouseDown

		#region PasswordShowPicturBox1_MouseUp
		private void PasswordShowPicturBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
			Properties.Resources.show_512;
			if (string.Compare(newPasswordTextBox.Text, "رمز عبور") != 0)
			{
				newPasswordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordShowPicturBox1_MouseUp

		#region NewPasswordConfirmTextBox_Enter
		private void NewPasswordConfirmTextBox_Enter(object sender, System.EventArgs e)
		{
			newPasswordConfirmTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			newPasswordConfirmTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emSize: 12);
			newPasswordConfirmTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			newPasswordConfirmPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(newPasswordConfirmTextBox.Text, "تایید رمز جدید") == 0)
			{
				newPasswordConfirmTextBox.Clear();
				newPasswordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordConfirmTextBox_Enter

		#region NewPasswordConfirmTextBox_Leave
		private void NewPasswordConfirmTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(newPasswordConfirmTextBox.Text) || string.Compare(newPasswordConfirmTextBox.Text, "تایید رمز جدید") == 0)
			{
				newPasswordConfirmTextBox.RightToLeft = 
					System.Windows.Forms.RightToLeft.Yes;
				newPasswordConfirmTextBox.ForeColor = 
					Infrastructure.Utility.GrayColor();
				newPasswordConfirmPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				newPasswordConfirmTextBox.Text = "تایید رمز جدید";
				newPasswordConfirmTextBox.Font = 
					Infrastructure.Utility.IranSansFont(emSize: 12);
				newPasswordConfirmTextBox.UseSystemPasswordChar = false;
				New_PasswordConfirm = null;
			}
			else
			{
				newPasswordConfirmTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();

				newPasswordConfirmPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				New_PasswordConfirm = newPasswordConfirmTextBox.Text;
			}
		}
		#endregion /PasswordConfirmTextBox_Leave

		#region PasswordShowPicturBox2_MouseDown
		private void PasswordShowPicturBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.hide_512;

			if (string.Compare(newPasswordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				newPasswordConfirmTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordShowPicturBox2_MouseDown

		#region PasswordShowPicturBox2_MouseUp
		private void PasswordShowPicturBox2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.show_512;
			if (string.Compare(newPasswordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				newPasswordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordShowPicturBox2_MouseUp

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
				New_Description = null;
			}
			else
			{
				descriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				descriptionPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				New_Description = descriptionTextBox.Text;
			}
		}
		#endregion /DescriptionTextBox_Leave

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
				Select_UserImage = openFileDialog.FileName;

				userImagePicturBox.BackgroundImage =
				System.Drawing.Image.FromFile(Select_UserImage);
				deleteImageButton.Visible = true;
				New_UserImage = System.IO.File.ReadAllBytes(Select_UserImage);
			}
			else
			{
				Select_UserImage = null;
				deleteImageButton.Visible = true;
			}
		}
		#endregion /AddPictureLinkLabel_LinkClicked

		#region DeleteImageButton_Click
		private void DeleteImageButton_Click(object sender, System.EventArgs e)
		{
			Select_UserImage = null;
			New_UserImage = null;
			var userImage = Old_UserImage;
			using (System.IO.MemoryStream image =  new System.IO.MemoryStream(userImage))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(image);
			}
			deleteImageButton.Visible = false;
		}
		#endregion /DeleteImageButton_Click

		#region FirstNameTextBox_TextChanged
		private void FirstNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(firstNameTextBox.Text, FirstName) == 0)
			{
				firstNameTextBox.ForeColor =
					Infrastructure.Utility.LimeColor();
			}
		}
		#endregion /FirstNameTextBox_TextChanged

		#region LastNameTextBox_TextChanged
		private void LastNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(lastNameTextBox.Text, LastName) == 0)
			{
				lastNameTextBox.ForeColor =
					Infrastructure.Utility.LimeColor();
			}
		}
		#endregion /LastNameTextBox_TextChanged

		#region TelTextBox_Enter
		private void TelTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			telTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			telPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			//if (string.Compare(telTextBox.Text, Old_Tel) == 0)
			//{
			//	telTextBox.TextAlign =
			//		System.Windows.Forms.HorizontalAlignment.Right;
			//	if (telTextBox.Text.StartsWith("09"))
			//	{
			//		telTextBox.Text = telTextBox.Text.Insert(4, "-");
			//	}
			//	else
			//	{
			//		telTextBox.Text = telTextBox.Text.Insert(3, "-");
			//	}
			//	telTextBox.SelectAll();
			//}
			if (string.IsNullOrEmpty(New_Tel))
			{
				if (telTextBox.Text.Contains('-') == true)
				{
					Tel = telTextBox.Text.Replace("-", string.Empty).Trim();
					telTextBox.Text = Tel;

					telTextBox.ForeColor =
						Infrastructure.Utility.MediumSlateBlueColor();
					telPanel.BackColor =
						Infrastructure.Utility.MediumSlateBlueColor();
				}
			}
			else
			{
				New_Tel = telTextBox.Text.Replace("-", string.Empty).Trim();
				telTextBox.Text = New_Tel;

			}


		}
		#endregion /TelTextBox_Enter

		#region TelTextBox_KeyPress
		private void TelTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
			if (string.Compare(telTextBox.Text, Tel) == 0 || string.Compare(telTextBox.Text, New_Tel) == 0)
			{
				New_Tel = null;
				telTextBox.Clear();
			}
		}
		#endregion /TelTextBox_KeyPress

		#region TelTextBox_Leave
		private void TelTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(telTextBox.Text))
			{
				telTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;

				telTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				telPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				telTextBox.Text = Tel;
				New_Tel = null;
			}
			else if (string.Compare(telTextBox.Text, Tel) == 0)
			{
				New_Tel = null;
				telTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.No;
				telTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				telPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();

				if (telTextBox.Text.StartsWith("09"))
				{
					telTextBox.Text = telTextBox.Text.Insert(4, "-");
				}
				else
				{
					telTextBox.Text = telTextBox.Text.Insert(3, "-");
				}
				confirmTelPicturBox.Visible = false;
				return;
			}
			else
			{
				New_Tel = telTextBox.Text;
				if (New_Tel.Length < 11)
				{
					confirmTelPicturBox.Visible = true;
					confirmTelPicturBox.Image = Resources.Tik_False;
					telTextBox.Focus();
					New_Tel = null;
					return;
				}
				else if (string.Compare(New_Tel, Old_Tel) == 0)
				{
					confirmTelPicturBox.Visible = false;
					return;
				}
				else
				{
					if (TelConfirmation(New_Tel) == true)
					{
						telTextBox.ForeColor =
							Infrastructure.Utility.WhiteColor();
						telPanel.BackColor =
							Infrastructure.Utility.WhiteColor();

						if (telTextBox.Text.StartsWith("09"))
						{
							if (telTextBox.Text.Contains('-') == true)
							{
								return;
							}
							else
							{
								telTextBox.Text = telTextBox.Text.Insert(4, "-");
							}


						}
						else
						{
							if (telTextBox.Text.Contains('-') == true)
							{
								return;
							}
							else
							{
								telTextBox.Text = telTextBox.Text.Insert(3, "-");
							}
						}
						confirmTelPicturBox.Visible = true;
						confirmTelPicturBox.Image = Resources.Tik_True;
						New_Tel = telTextBox.Text;
					}
					else if (TelConfirmation(New_Tel) == false)
					{
						confirmTelPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						telTextBox.Focus();
						New_Tel = null;
					}
				}
			}
		}
		#endregion /TelTextBox_Leave

		#region TelTextBox_TextChanged
		private void TelTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(telTextBox.Text))
			{
				New_Tel = null;
				confirmTelPicturBox.Visible = false;
				return;
			}
			else if (string.Compare(telTextBox.Text, Tel) == 0)
			{
				telTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				telPanel.BackColor =
					Infrastructure.Utility.DimGrayColor();
				confirmTelPicturBox.Visible = false;
				telTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				New_Tel = null;
			}
			else
			{
				New_Tel = telTextBox.Text;
				if (New_Tel.Length < 11)
				{
					confirmTelPicturBox.Visible = true;
					confirmTelPicturBox.Image = Resources.Tik_False;
					telTextBox.Focus();
					New_Tel = null;
					return;
				}
				else
				{
					if (string.Compare(New_Tel, Old_Tel) == 0)
					{
						return;
					}
					else if (TelConfirmation(New_Tel) == true)
					{
						if (New_Tel.StartsWith("09"))
						{
							confirmTelPicturBox.Visible = true;
							confirmTelPicturBox.Image = Resources.Tik_True;
							New_Tel = telTextBox.Text;
						}
						else
						{
							confirmTelPicturBox.Visible = true;
							confirmTelPicturBox.Image = Resources.Tik_True;
							New_Tel = telTextBox.Text;
						}

						//confirmTelPicturBox.Visible = true;
						//confirmTelPicturBox.Image = Resources.Tik_True;
						//New_Tel = telTextBox.Text;
						//return;
					}
					else if (TelConfirmation(New_Tel) == false)
					{
						confirmTelPicturBox.Visible = true;
						confirmEmailTickPicturBox.Image = Resources.Tik_False;
						New_Tel = null;
						return;
					}
				}
			}
			//New_Tel = telTextBox.Text;
		}
		#endregion /TelTextBox_TextChanged

		#region NationalCodeTextBox_TextChanged
		private void NationalCodeTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(nationalCodeTextBox.Text, NationalCode) == 0)
			{
				nationalCodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				nationalCodeTextBox.ForeColor =
					Infrastructure.Utility.LimeColor();
			}
		}
		#endregion /NationalCodeTextBox_TextChanged

		#region AddressTextBox_Enter
		private void AddressTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			addressTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			addressPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			if (string.Compare(addressTextBox.Text, Old_Address) == 0)
			{
				addressTextBox.Select(0, addressTextBox.Text.Length);
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
			if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, Old_Address) == 0)
			{
				addressTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				addressPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				addressTextBox.Text = Old_Address;
				New_Address = null;
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
					New_Address = addressTextBox.Text;
					if (AddressConfimation(New_Address) == true)
					{
						confirmAddresspicturBox.Visible = true;
						confirmAddresspicturBox.Image = Resources.Tik_True;
						New_Address = addressTextBox.Text;
					}
					else if (AddressConfimation(New_Address) == false)
					{
						confirmAddresspicturBox.Visible = true;
						confirmAddresspicturBox.Image = Resources.Tik_False;
						addressTextBox.Focus();
						New_Address = null;
					}
				}
			}
		}
		#endregion /AddressTextBox_Leave

		#region AddressTextBox_TextChanged
		private void AddressTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(addressTextBox.Text) || string.Compare(addressTextBox.Text, Old_Address) == 0)
			{
				confirmAddresspicturBox.Visible = false;
				return;
			}
			else
			{
				New_Address = addressTextBox.Text;
				if (AddressConfimation(New_Address) == true)
				{
					confirmAddresspicturBox.Visible = true;
					confirmAddresspicturBox.Image = Resources.Tik_True;
					New_Address = addressTextBox.Text;
				}
				else if (AddressConfimation(New_Address) == false)
				{
					confirmAddresspicturBox.Visible = true;
					confirmAddresspicturBox.Image = Resources.Tik_False;
					New_Address = null;
				}
			}
		}
		#endregion /AddressTextBox_TextChanged

		#region MarriedRadioButton_CheckedChanged
		private void MarriedRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			New_Marride = null;
			marride = MarrideList.متاهل;
			New_Marride = marride.ToString();
		}
		#endregion /MarriedRadioButton_CheckedChanged

		#region SingleRadioButton_CheckedChanged
		private void SingleRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			New_Marride = null;
			marride = MarrideList.مجرد;
			New_Marride = marride.ToString();
		}
		#endregion /SingleRadioButton_CheckedChanged

		#region UpdateButton_Click
		private void UpdateButton_Click(object sender, EventArgs e)
		{
			if (CheckInformation() == true)
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

					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, Username) == 0)
						.FirstOrDefault();
					if (user != null)
					{
						if (string.IsNullOrEmpty(New_Email))
						{
							New_Email = Old_Email;
						}
						if (string.IsNullOrEmpty(New_Password) == false)
						{
							if (PasswordMmatching(newPassword: New_Password, newPasswordConfirm: New_PasswordConfirm) == false)
							{
								Mbb.Windows.Forms.MessageBox.Show
									(text: "رمز جدید با تایید رمز جدید برابر نیستد. \n لطفا مجددا تلاش نمایید!",
									caption: "عدم تصابق رمز عبور",
									icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
									button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

								newPasswordTextBox.Focus();
								return;
							}
						}
						else if (string.IsNullOrEmpty(New_Password))
						{
							New_Password = Old_Password;
						}

						if (string.IsNullOrEmpty(New_Description))
						{
							New_Description = Old_Description;
						}
						if (string.IsNullOrEmpty(New_Tel))
						{
							New_Tel = Old_Tel;
						}
						if (string.IsNullOrEmpty(New_Address))
						{
							New_Address = Old_Address;
						}
						if (string.IsNullOrEmpty(New_Marride))
						{
							New_Marride = Old_Marride;
						}

						user.Username = Username;
						user.Email = New_Email;
						user.Password = New_Password;
						user.Description = New_Description;
						user.First_Name = FirstName;
						user.Last_Name = LastName;
						user.Telephone = New_Tel;
						user.National_Code = NationalCode;
						user.Address = New_Address;
						user.Marital_Status = New_Marride;

						if (string.IsNullOrEmpty(Select_UserImage))
						{
							user.User_Image = Old_UserImage;
						}
						else
						{
							user.User_Image = New_UserImage;
						}
						user.Registration_Date = RegisterDate;
						user.Registration_Time = RegisterTime;
					}
					dataBaseContext.SaveChanges();

					if (string.IsNullOrEmpty(New_Password) || string.Compare(New_Password, Old_Password) == 0)
					{
						Infrastructure.Utility.WindowsNotification
						(message: "حساب کاربری به روز شد!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
						
						UpdadeUsername();
						UserLoaded();
						MainForm.UpLoadPicture();
						return;
					}
					else
					{
						this.Close();
						MainForm.Close();
						Program.AuthenticatedUser = null;
						LoginForm loginForm = new LoginForm();
						loginForm.Show();
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
		}
		#endregion /UpdateButton_Click

		//-----End of coding line

		#region Founctions
		//-----
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

		#region PasswordMmatching
		private bool PasswordMmatching(string newPassword, string newPasswordConfirm)
		{
			if (string.Compare(newPassword, newPasswordConfirm) == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion /PasswordMatching

		#region TelConfirmation
		private static bool TelConfirmation(string tel)
		{
			if (string.Compare(tel.Replace("-", string.Empty).Trim(), Program.AuthenticatedUser.Telephone) == 0)
			{
				return false;
			}
			else
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

		#region UserLoaded
		private void UserLoaded()
		{
			#region Loaded
			Username = Program.AuthenticatedUser.Username;
			usernameTextBox.Text = Program.AuthenticatedUser.Username;

			New_Email = null;
			Old_Email = Program.AuthenticatedUser.Email;
			emailTextBox.Text = Program.AuthenticatedUser.Email;
			emailTextBox.Enabled = false;

			Old_Password = Program.AuthenticatedUser.Password;
			oldPasswordTextBox.Text = "رمز قدیم";
			oldPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			oldPasswordTextBox.Font =
				Infrastructure.Utility.IranSansFont(emSize: 12);

			oldPasswordTextBox.Font =
				Infrastructure.Utility.IranSansFont(emSize: 12);
			oldPasswordTextBox.UseSystemPasswordChar = false;

			New_Password = null;
			newPasswordTextBox.Text = "رمز جدید";
			newPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			newPasswordTextBox.Font =
				Infrastructure.Utility.IranSansFont(emSize: 12);
			newPasswordTextBox.Enabled = false;
			newPasswordTextBox.UseSystemPasswordChar = false;

			New_PasswordConfirm = null;
			newPasswordConfirmTextBox.Text = "تایید رمز جدید";
			newPasswordConfirmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			newPasswordConfirmTextBox.Font =
				Infrastructure.Utility.IranSansFont(emSize: 12);
			newPasswordConfirmTextBox.Enabled = false;
			newPasswordConfirmTextBox.UseSystemPasswordChar = false;

			New_Description = null;
			Old_Description = Program.AuthenticatedUser.Description;
			descriptionTextBox.Text = Program.AuthenticatedUser.Description;
			descriptionTextBox.Enabled = false;

			Old_UserImage = Program.AuthenticatedUser.User_Image;
			var userImage = Program.AuthenticatedUser.User_Image;
			using (System.IO.MemoryStream image = new System.IO.MemoryStream(userImage))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(image);
			}
			addPictureLinkLabel.Enabled = false;
			deleteImageButton.Visible = false;

			FirstName = Program.AuthenticatedUser.First_Name;
			firstNameTextBox.Text = Program.AuthenticatedUser.First_Name;

			LastName = Program.AuthenticatedUser.Last_Name;
			lastNameTextBox.Text = Program.AuthenticatedUser.Last_Name;

			New_Tel = null;
			Old_Tel = Program.AuthenticatedUser.Telephone;
			if (Old_Tel.Length == 11 && Old_Tel.StartsWith("09"))
			{
				Tel = Old_Tel.Insert(4, "-");
			}
			else
			{
				Tel = Old_Tel.Insert(3, "-");
			}
			telTextBox.Text = Tel;
			telTextBox.Enabled = false;

			NationalCode = Program.AuthenticatedUser.National_Code;
			nationalCodeTextBox.Text = Program.AuthenticatedUser.National_Code;

			New_Address = null;
			Old_Address = Program.AuthenticatedUser.Address;
			addressTextBox.Text = Program.AuthenticatedUser.Address;
			addressTextBox.Enabled = false;

			
			Old_Marride = Program.AuthenticatedUser.Marital_Status;
			if (string.Compare(Old_Marride, "متاهل") == 0)
			{
				marriedRadioButton.Checked = true;
				singleRadioButton.Checked = false;
				New_Marride = null;
			}
			else if (string.Compare(Old_Marride, "مجرد") == 0)
			{
				marriedRadioButton.Checked = false;
				singleRadioButton.Checked = true;
				New_Marride = null;
			}
			maritalStatusGroupBox.Enabled = false;

			RegisterDate = Program.AuthenticatedUser.Registration_Date;
			RegisterTime = Program.AuthenticatedUser.Registration_Time;
			#endregion /Loaded
		}
		#endregion /UserLoaded

		#region UpdateUsername
		private void UpdadeUsername()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, Username, true) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					Program.AuthenticatedUser = user;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /UpdateUsername

		#region CheckInformation
		private bool CheckInformation()
		{
			if (string.IsNullOrEmpty(New_Email) && string.IsNullOrEmpty(New_Password) && string.IsNullOrEmpty(New_Description) && string.IsNullOrEmpty(New_Tel) && string.IsNullOrEmpty(New_Address) && string.IsNullOrEmpty(New_Marride))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion /CheckInformation
		//-----
		#endregion /Founctions
	}
}
