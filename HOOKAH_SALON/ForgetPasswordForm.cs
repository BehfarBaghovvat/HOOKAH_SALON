using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace HOOKAH_SALON
{
	public partial class ForgetPasswordForm : Infrastructure.BaseForm
	{
		public ForgetPasswordForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties
		//-----
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PasswordConfirm { get; set; }
		public string Code { get; set; }
		public string SenderEmail { get; set; }
		public string PasswordSenderEmail { get; set; }
		public string MessageEmail { get; set; }
		public string SendSMS { get; set; }
		public string Receptor { get; set; }
		public string MessageSMS { get; set; }
		//-----
		#endregion /Properties

		//-----The beginning of the coding line.

		#region ForgetPasswordForm_Load
		private void ForgetPasswordForm_Load(object sender, System.EventArgs e)
		{
			checkIntenetTimer.Start();
			RandomCode();
			emailRadioButton.Checked = true;
		}
		#endregion /ForgetPasswordForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
			Program.LoginShow();
		}
		#endregion /CloseButton_Click

		#region MinimizButton_Click
		private void MinimizButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizButton_Click

		#region SmsRadioButton_CheckedChanged
		private void SmsRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			//sendSMSPanel.BringToFront();
			sendEmailPanel.SendToBack();
			notificationLabel.Visible = true;
		}
		#endregion /SmsRadioButton_CheckedChanged

		#region EmailRadioButton_CheckedChanged
		private void EmailRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			//sendSMSPanel.SendToBack();
			sendEmailPanel.BringToFront();
			notificationLabel.Visible = false;
		}
		#endregion /EmailRadioButton_CheckedChanged

		#region EmailTextBox_Enter
		private void EmailTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();

			emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			emailTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emailTextBox.Font.Size);
			emailTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			emailPanel.BackColor =
				Infrastructure.Utility.LimeColor();

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
				emailTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				emailTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				emailTextBox.Font =
					Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
				emailTextBox.ForeColor =
				Infrastructure.Utility.BlackColor();
				emailPanel.BackColor =
					Infrastructure.Utility.BlackColor();

				emailTextBox.Text = "پست الکترونیکی";
				Email = string.Empty;
			}
			else
			{
				emailTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				emailPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /EmailTextBox_Leave

		#region EmailTextBox_TextChanged
		private void EmailTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				return;
			}
			else
			{
				Email = emailTextBox.Text;
				if (ApprovalEmail(Email) == true)
				{
					emailStatusPicturBox.Visible = true;
					emailStatusPicturBox.Image = Properties.Resources.Tik_True;
					usernameTextBox.Enabled = true;
				}
				else if (ApprovalEmail(Email) == false)
				{
					emailStatusPicturBox.Visible = true;
					emailStatusPicturBox.Image = Properties.Resources.Tik_False;
					usernameTextBox.Enabled = false;
				}
			}
		}
		#endregion /EmailTextBox_TextChanged

		#region CodeTextBox_Enter
		private void CodeTextBox_Enter(object sender, System.EventArgs e)
		{
			codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			codeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			codeTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(codeTextBox.Font.Size);
			codeTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			codePanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(codeTextBox.Text, "کد") == 0)
			{
				codeTextBox.Clear();
			}
		}
		#endregion /CodeTextBox_Enter

		#region CodeTextBox_KeyPress
		private void CodeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /CodeTextBox_KeyPress

		#region CodeTextBox_Leave
		private void CodeTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(codeTextBox.Text) || string.Compare(codeTextBox.Text, "کد") == 0)
			{
				codeTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				codeTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				codeTextBox.Font =
					Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
				codeTextBox.ForeColor =
				Infrastructure.Utility.BlackColor();
				codePanel.BackColor =
					Infrastructure.Utility.BlackColor();

				codeTextBox.Text = "کد";
				Code = string.Empty;
			}
			else
			{
				codeTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				codePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /CodeTextBox_Leave

		#region CodeTextBox_TextChanged
		private void CodeTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(codeTextBox.Text) || string.Compare(codeTextBox.Text, "کد") == 0)
			{
				return;
			}
			else
			{
				Code = codeTextBox.Text;

				if (CheckCode(code: Code) == false)
				{
					passwordTextBox.Enabled = false;
					passwordConfirmTextBox.Enabled = false;
					changePasswordButton.Enabled = false;
				}
				else
				{
					passwordTextBox.Enabled = true;
					passwordConfirmTextBox.Enabled = true;
					changePasswordButton.Enabled = true;
				}
			}
		}
		#endregion /CodeTextBox_TextChanged

		#region SendCodeButton_Click
		private void SendCodeButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();

				SenderEmail = "resetcodegoolge@gmail.com";
				PasswordSenderEmail = "B@9#077a+";
				MessageEmail =
					$"کد تغییر رمز عبور {securityCodeLabel.Text} میباشد. \n اگر این ایمیل برای شما نمیباشد. \n لطفا این ایمیل را نادیده بگیرید. \n با تشکر گروه نرم افزاری هزاره سوم";

				mailMessage.From = new MailAddress(SenderEmail);
				mailMessage.To.Add(Email);
				mailMessage.Subject = "Reset Password";
				mailMessage.Body = MessageEmail;
				mailMessage.IsBodyHtml = true;

				SmtpClient smtp = new SmtpClient("smtp.gmail.com");
				smtp.EnableSsl = true;
				smtp.Port = 587;
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtp.Credentials = new NetworkCredential(SenderEmail, PasswordSenderEmail);
				smtp.Send(message: mailMessage);

				Infrastructure.Utility.WindowsNotification
					("ایمیل برای شما ارسال شد!",
					Infrastructure.PopupNotificationForm.Caption.موفقیت);
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /SendCodeButton_Click

		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			usernameTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(usernameTextBox.Font.Size);
			usernameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			usernamePanel.BackColor =
				Infrastructure.Utility.LimeColor();

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
				usernameTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				usernameTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				usernameTextBox.Font =
					Infrastructure.Utility.IranSansFont(usernameTextBox.Font.Size);
				usernameTextBox.ForeColor =
					Infrastructure.Utility.BlackColor();
				usernamePanel.BackColor =
					Infrastructure.Utility.BlackColor();
				usernameTextBox.Text =
					"نام کاربری";
				userStatusLabel.Text =
					"وضعیت";
				userStatusLabel.ForeColor =
					Infrastructure.Utility.WhiteColor();
				Username = string.Empty;
			}
			else
			{
				usernameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				usernamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /UsernameTextBox_Leave

		#region UsernameTextBox_TextChanged
		private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.Compare(usernameTextBox.Text, "نام کاربری") == 0 || string.Compare(usernameTextBox.Text, "Administrator") == 0)
			{
				return;
			}
			else
			{
				Username = usernameTextBox.Text;
				if (ApprovalUsername(Username) == true)
				{
					userStatusLabel.Text = "کاربر فعال است";
					userStatusLabel.ForeColor =
						System.Drawing.Color.FromArgb(63, 195, 128);
					sendCodeButton.Enabled = true;
					codeTextBox.Enabled = true;
				}
				else if (ApprovalUsername(Username) == false)
				{
					userStatusLabel.Text =
						"کاربر غیر قابل دسترس، نا موجود و یا حذف گردیده است!";
					userStatusLabel.ForeColor =
						System.Drawing.Color.FromArgb(231, 76, 60);
					sendCodeButton.Enabled = false;
					codeTextBox.Enabled = false;
				}
			}
		}
		#endregion /UsernameTextBox_TextChanged

		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			passwordTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emailTextBox.Font.Size);
			passwordTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			passwordPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.Clear();
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				passwordTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				passwordTextBox.Font =
					Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
				passwordTextBox.ForeColor =
				Infrastructure.Utility.BlackColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.BlackColor();

				passwordTextBox.Text = "رمز عبور";
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

		#region PasswordConfirmTextBox_Enter
		private void PasswordConfirmTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordConfirmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			passwordConfirmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			passwordConfirmTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emailTextBox.Font.Size);
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			passwordConfirmPanel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.Clear();
			}
		}
		#endregion /PasswordConfirmTextBox_Enter

		#region PasswordConfirmTextBox_Leave
		private void PasswordConfirmTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text) || string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
				passwordConfirmTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;
				passwordConfirmTextBox.Font =
					Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
				passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.BlackColor();
				passwordConfirmPanel.BackColor =
					Infrastructure.Utility.BlackColor();

				passwordConfirmTextBox.Text = "تایید رمز عبور";
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

		#region ChangePasswordButton_Click
		private void ChangePasswordButton_Click(object sender, System.EventArgs e)
		{
			UpdatePassword();
			AllClear();
			this.Close();
			Program.LoginShow();
		}
		#endregion /ChangePasswordButton_Click

		#region CheckIntenetTimer_Tick
		private void CheckIntenetTimer_Tick(object sender, System.EventArgs e)
		{
			InternetConnection();
		}
		#endregion /CheckIntenetTimer_Tick

		//-----End of coding line.

		#region Functions
		//*****
		#region RandomCode
		private void RandomCode()
		{
			var randomeNumber = new System.Collections.Generic.List<int>();
			var RandomeGenerator = new System.Random();
			var initialCount = 1;

			for (int i = 0; i <= 5; i++)
			{
				while (initialCount <= 5)
				{
					int num = RandomeGenerator.Next(1000, 999999);

					if (!randomeNumber.Contains(num))
					{
						randomeNumber.Add(num);
						initialCount++;
					}

					randomeNumber.Sort();
					randomeNumber.ForEach(x => securityCodeLabel.Text = x.ToString());
				}

			}
		}
		#endregion /RandomCode

		#region ApprovalUsername
		private bool ApprovalUsername(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, text, true) == 0)
				.FirstOrDefault();

			if (user != null && string.Compare(user.Email, Email, true) == 0 && user.IsActive == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion /ApprovalUsername

		#region ApprovalEmail
		private bool ApprovalEmail(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Email, text, true) == 0)
				.FirstOrDefault();

			if (user != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		#endregion /ApprovalEmail

		#region InternetConnection
		private bool InternetConnection()
		{
			bool _connection = NetworkInterface.GetIsNetworkAvailable();
			bool status;

			if (_connection == true)
			{
				netConnectionStatusLabel.Visible = true;
				netConnectionStatusLabel.ForeColor =
					System.Drawing.Color.FromArgb(63, 195, 128);
				netConnectionStatusLabel.Text = " اینترنت در دسترس می باشد. ";
				status = true;
			}
			else
			{
				netConnectionStatusLabel.Visible = true;
				netConnectionStatusLabel.ForeColor =
					System.Drawing.Color.FromArgb(231, 76, 60);
				netConnectionStatusLabel.Text = " اینترنت قطع می باشد. ";
				status = false;
			}

			return status;
		}
		#endregion /InternetConnection

		#region CheckCode
		private bool CheckCode(string code)
		{

			if (string.Compare(code, securityCodeLabel.Text) != 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /CheckCode

		#region UpdatePassword
		private void UpdatePassword()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

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

				System.Windows.Forms.DialogResult dialogResult = Mbb.Windows.Forms.MessageBox.Show
						(text: "از تغییر رمز اطمینان دارید؟",
						caption: "هشدار تغییر",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, Username) == 0)
					.FirstOrDefault();

					if (user != null)
					{
						user.Password = Password;
					}
					dataBaseContext.SaveChanges();
					Mbb.Windows.Forms.MessageBox.Show
						(text: "رمز عبور با موفقیت تغییر یاقت.",
						caption: "تغییر رمز عبور",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
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
		#endregion /UpdatePassword

		#region AllClear
		private void AllClear()
		{
			Email = string.Empty;
			emailTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
			emailTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
			emailTextBox.ForeColor =
			Infrastructure.Utility.BlackColor();
			emailPanel.BackColor =
				Infrastructure.Utility.BlackColor();
			emailTextBox.Text = "پست الکترونیکی";
			//-----
			Code = string.Empty;
			codeTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			codeTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
			codeTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
			codeTextBox.ForeColor =
			Infrastructure.Utility.BlackColor();
			codePanel.BackColor =
				Infrastructure.Utility.BlackColor();
			codeTextBox.Text = "کد";
			codeTextBox.Enabled = false;
			//-----
			Username = string.Empty;
			usernameTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			usernameTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
			usernameTextBox.Font =
				Infrastructure.Utility.IranSansFont(usernameTextBox.Font.Size);
			usernameTextBox.ForeColor =
				Infrastructure.Utility.BlackColor();
			usernamePanel.BackColor =
				Infrastructure.Utility.BlackColor();
			usernameTextBox.Text =
				"نام کاربری";
			usernameTextBox.Enabled = false;
			userStatusLabel.Text =
				"وضعیت";
			userStatusLabel.ForeColor =
				Infrastructure.Utility.WhiteColor();
			//-----
			Password = string.Empty;
			passwordTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			passwordTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
			passwordTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
			passwordTextBox.ForeColor =
			Infrastructure.Utility.BlackColor();
			passwordPanel.BackColor =
				Infrastructure.Utility.BlackColor();
			passwordTextBox.Text = "رمز عبور";
			passwordTextBox.Enabled = false;
			//-----
			PasswordConfirm = string.Empty;
			passwordConfirmTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			passwordConfirmTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.Yes;
			passwordConfirmTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
			passwordConfirmTextBox.ForeColor =
			Infrastructure.Utility.BlackColor();
			passwordConfirmPanel.BackColor =
				Infrastructure.Utility.BlackColor();
			passwordConfirmTextBox.Text = "تایید رمز عبور";
			//-----
			sendCodeButton.Enabled = false;
			changePasswordButton.Enabled = false;

		}


		#endregion /AllClear 
		//******
		#endregion /Functions
	}
}