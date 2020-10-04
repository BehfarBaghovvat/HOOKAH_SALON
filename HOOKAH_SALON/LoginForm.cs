using System.Linq;

namespace HOOKAH_SALON
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		#region Properties
		private ForgetPasswordForm forgetPasswordForm;
		public ForgetPasswordForm ForgetPasswordForm
		{
			get
			{
				if (forgetPasswordForm == null || forgetPasswordForm.IsDisposed == true)
				{
					forgetPasswordForm =
						new ForgetPasswordForm();
				}
				return forgetPasswordForm;
			}
		}
		public string UsernameEmail { get; set; }
		public string Password { get; set; }
		public string LoginTime { get; set; }
		public string LogOutTime { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.
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

		#region UsernameEmailTextBox
		//-----
		#region UsernameTextBox_Enter
		private void UsernameEmailTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			usernameEmailTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			usernameEmailPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(usernameEmailTextBox.Text, "Username/Email") == 0)
			{
				usernameEmailTextBox.Clear();
			}
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_KeyPress
		private void UsernameEmailTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_Leave
		private void UsernameEmailTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameEmailTextBox.Text) || string.Compare(usernameEmailTextBox.Text, "Username/Email") == 0)
			{
				usernameEmailTextBox.ForeColor =
				Infrastructure.Utility.GrayColor();
				usernameEmailPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				usernameEmailTextBox.Text = "Username/Email";
				UsernameEmail = string.Empty;
			}
			else
			{
				usernameEmailTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				usernameEmailPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				UsernameEmail = usernameEmailTextBox.Text;
			}
		}
		#endregion /UsernameTextBox_Leave 

		#region UsernameEmailTextBox_TextChanged
		private void UsernameEmailTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameEmailTextBox.Text) || string.Compare(usernameEmailTextBox.Text, "Username/Email") == 0)
			{
				return;
			}
			else
			{
				Models.DataBaseContext dataBaseContext =
					new Models.DataBaseContext();
				UsernameEmail = usernameEmailTextBox.Text;
				if (ApprovalUsername(text: UsernameEmail) == false && ApprovalEmail(text: UsernameEmail) == false)
				{
					Models.User foundedUser =
							GetUserByUsername(usernameEmailTextBox.Text);

					GetImageByUser(null);

					Models.User foundedEmail =
							GetUserByEmail(usernameEmailTextBox.Text);

					GetImageByUser(null);

					return;
				}
				else if (ApprovalUsername(text: UsernameEmail) == true && ApprovalEmail(text: UsernameEmail) == false)
				{
					Models.User foundedUser =
							GetUserByUsername(usernameEmailTextBox.Text);

					GetImageByUser(foundedUser);

					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, UsernameEmail, true) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, Password, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, Password, true) == 0)
					{
						if (user.IsActive == false)
						{
							System.Windows.Forms.MessageBox.Show("User Locked", "error", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);
							return;
						}
						else
						{
							this.Close();
							Program.AuthenticatedUser = user;
							SaveLoginHistory(user);

							WelcomeUserForm welComeUserForm =
								new WelcomeUserForm();

							welComeUserForm.ShowDialog();
							Program.MainShow();
						}
					}
				}
				else if (ApprovalUsername(text: UsernameEmail) == false && ApprovalEmail(text: UsernameEmail) == true)
				{
					Models.User foundedEmail =
							GetUserByEmail(usernameEmailTextBox.Text);

					GetImageByUser(foundedEmail);


					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Email, UsernameEmail, false) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, Password, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, Password, true) == 0)
					{
						if (user.IsActive == false)
						{
							System.Windows.Forms.MessageBox.Show("User Locked", "error", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);
							return;
						}
						else
						{
							this.Close();
							Program.AuthenticatedUser = user;
							SaveLoginHistory(user);

							WelcomeUserForm welComeUserForm =
								new WelcomeUserForm();

							welComeUserForm.ShowDialog();
							Program.MainShow();
						}
					}
				}
			}
		}
		#endregion /UsernameEmailTextBox_TextChanged
		//-----
		#endregion /UsernameEmailTextBox

		#region PasswordTextBox
		//-----
		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor =
				Infrastructure.Utility.MediumSlateBlueColor();
			passwordPanel.BackColor =
				Infrastructure.Utility.MediumSlateBlueColor();

			if (string.Compare(passwordTextBox.Text, "Password") == 0)
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(usernameEmailTextBox.Text, "Password") == 0)
			{
				passwordTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				passwordPanel.BackColor =
					Infrastructure.Utility.GrayColor();

				passwordTextBox.Text = "Password";
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

		#region PasswordTextBox_TextChanged
		private void PasswordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(passwordTextBox.Text, "Password") == 0)
			{
				return;
			}
			else
			{
				Models.DataBaseContext dataBaseContext =
					new Models.DataBaseContext();
				UsernameEmail = usernameEmailTextBox.Text;
				if (ApprovalUsername(text: UsernameEmail) == false && ApprovalEmail(text: UsernameEmail) == false)
				{
					return;
				}
				else if (ApprovalUsername(text: UsernameEmail) == true && ApprovalEmail(text: UsernameEmail) == false)
				{
					Password = passwordTextBox.Text;
					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, UsernameEmail, true) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, Password, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, Password, true) == 0)
					{
						if (user.IsActive == false)
						{
							System.Windows.Forms.MessageBox.Show("User Locked", "error",buttons: System.Windows.Forms.MessageBoxButtons.OK,icon: System.Windows.Forms.MessageBoxIcon.Error);
							return;
						}
						else
						{
							this.Close();
							Program.AuthenticatedUser = user;
							SaveLoginHistory(user);

							WelcomeUserForm welComeUserForm =
								new WelcomeUserForm();

							welComeUserForm.ShowDialog();
							Program.MainShow();
						}
					}
				}
				else if (ApprovalUsername(text: UsernameEmail) == false && ApprovalEmail(text: UsernameEmail) == true)
				{
					Password = passwordTextBox.Text;
					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Email, UsernameEmail, false) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, Password, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, Password, true) == 0)
					{
						if (user.IsActive == false)
						{
							System.Windows.Forms.MessageBox.Show("User Locked", "error", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);
							return;
						}
						else
						{
							this.Close();
							Program.AuthenticatedUser = user;
							SaveLoginHistory(user);

							WelcomeUserForm welComeUserForm =
								new WelcomeUserForm();

							welComeUserForm.ShowDialog();
							Program.MainShow();
						}
					}
				}
			}
		}
		#endregion /PasswordTextBox_TextChanged

		#region ShowPasswordPicturBox_MouseDown
		private void ShowPasswordPicturBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showPasswordPicturBox.Image =
				Properties.Resources.hide_512;
			if (string.Compare(passwordTextBox.Text,"Password")==0)
			{
				return;
			}
			else
			{
				passwordTextBox.UseSystemPasswordChar = false;
				//passwordTextBox.ForeColor = Infrastructure.Utility.WhiteColor();
			}
		}
		#endregion /ShowPasswordPicturBox_MouseDown

		#region ShowPasswordPicturBox_MouseUp
		private void ShowPasswordPicturBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showPasswordPicturBox.Image =
				Properties.Resources.show_512;
			if (string.Compare(passwordTextBox.Text, "Password") == 0)
			{
				return;
			}
			else
			{
				passwordTextBox.UseSystemPasswordChar = true;
				passwordTextBox.ForeColor = Infrastructure.Utility.MediumSlateBlueColor();
			}
		}
		#endregion /ShowPasswordPicturBox_MouseUp
		//-----
		#endregion /PasswordTextBox

		#region ForgetPasswordLinkLabel_LinkClicked
		private void ForgetPasswordLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
			ForgetPasswordForm.Show();
		}
		#endregion /ForgetPasswordLinkLabel_LinkClicked

		#region NewAccountLinkLabel_LinkClicked
		private void RegisterLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Program.RegistrShow();
		}
		#endregion /NewAccountLinkLabel_LinkClicked
		//-----End of coding line

		#region Functions
		//------
		#region Initialize
		public void Initialize()
		{
			UsernameEmail = string.Empty;
			usernameEmailTextBox.Text = "Username\\Email";
			Password = string.Empty;
			passwordTextBox.Text = "Password";
			passwordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /Initialize

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

			if (user != null)
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

		#region ApprovalUsername
		private bool ApprovalPassword(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Password, text, true) == 0)
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
		#endregion /ApprovalUsernam

		#region GetImageByUser
		//----برای نشان دادن تصویر کاربر
		private void GetImageByUser(Models.User user)
		{
			if (user == null)
			{
				userImagePicturBox.BackgroundImage = Properties.Resources.user_1024;
			}
			else
			{
				var byteImage = user.User_Image;
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(ms);
				}
			}
		}
		#endregion /GetImageByUser

		#region GetUserByEmail
		//----- برای بررسی پست الکترونیکی 
		private Models.User GetUserByEmail(string username)
		{

			Models.DataBaseContext dataBaseContext = null;

			dataBaseContext =
				new Models.DataBaseContext();
			Models.User users =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Email, username, true) == 0)
				.FirstOrDefault();

			if (users != null)
			{
				return users;
			}
			else
			{
				return null;
			}
		}
		#endregion /GetUserByEmail

		#region GetUserByUsername
		//----- برای بررسی شناسه کاربری 
		private Models.User GetUserByUsername(string username)
		{

			Models.DataBaseContext dataBaseContext = null;

			dataBaseContext =
				new Models.DataBaseContext();
			Models.User users =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, username, true) == 0)
				.FirstOrDefault();

			if (users != null)
			{
				return users;
			}
			else
			{
				return null;
			}
		}
		#endregion /GetUserByUsername

		#region SaveLoginHistory
		private void SaveLoginHistory(Models.User user)
		{
			LoginTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";

			LogOutTime = $"Null";

			string fullName;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				if (string.IsNullOrWhiteSpace(user.First_Name) && string.IsNullOrWhiteSpace(user.Last_Name))
				{
					fullName = "Null";
				}
				else
				{
					fullName = $"{user.First_Name} {user.First_Name}";
				}

				dataBaseContext =
					new Models.DataBaseContext();
				Models.LogHistory logHistory =
					dataBaseContext.LogHistories
					.OrderBy(current => current.Login_Time)
					.FirstOrDefault();

				logHistory =
					new Models.LogHistory
					{
						Full_Name = fullName,
						Username = user.Username,
						Login_Time = LoginTime,
						Logout_Time = LogOutTime,
					};

				dataBaseContext.LogHistories.Add(logHistory);
				dataBaseContext.SaveChanges();

				Program.AutenticatLogHistory = logHistory;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			if (dataBaseContext != null)
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}
		}
		#endregion /SaveLoginHistory

		#region LogOut
		//public void LogOut(object sender, System.Windows.Forms.FormClosedEventArgs e)
		//{
		//	Program.AuthenticatedUser = null;
		//	usernameEmailTextBox.Text = "Username/Email";

		//	passwordTextBox.Text = "Password";
		//	passwordTextBox.UseSystemPasswordChar = false;
		//	this.Show();
		//}
		#endregion LogOut
		//-----
		#endregion /Functions
	}
}
