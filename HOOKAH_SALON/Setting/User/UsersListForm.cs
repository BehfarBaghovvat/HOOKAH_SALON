using System.Linq;

namespace HOOKAH_SALON.Setting.User
{
	public partial class UsersListForm : Infrastructure.BaseForm
	{
		public UsersListForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Search { get; set; }
		public string AccessLevel { get; set; }
		public string AccessLevel_New { get; set; }
		public string AccessLeve_FirstLoad { get; private set; }
		public bool Activation_FirstLoad { get; private set; }
		public bool Activation_New { get; private set; }
		public bool IsActive { get; set; }
		public string Username { get; set; }
		public string EventLog_Username { get; private set; }
		public string EventLog_FullName { get; private set; }
		public string EventLog_EventDate { get; private set; }
		public string EventLog_EventTime { get; private set; }
		public string EventLog_EventTitle { get; private set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region UsersListForm_Load
		private void UsersListForm_Load(object sender, System.EventArgs e)
		{
			UsersLoaded();
		}
		#endregion /UsersListForm_Load

		#region UserSearchTextBox_Enter
		private void UserSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			userSearchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			userSearchPanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			userSearchTextBox.Select(0, 0);
		}
		#endregion /UserSearchTextBox_Enter

		#region UserSearchTextBox_KeyPress
		private void UserSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(userSearchTextBox.Text, "جستجوی کاربر...") == 0)
			{
				userSearchTextBox.Clear();
			}
		}
		#endregion /UserSearchTextBox_KeyPress

		#region UserSearchTextBox_Leave
		private void UserSearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(userSearchTextBox.Text, "جستجوی کاربر...") == 0 || string.IsNullOrWhiteSpace(userSearchTextBox.Text))
			{
				userSearchTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				searchPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				Search = null;
				userSearchTextBox.Text = "جستجوی کاربر...";
				return;
			}
			else
			{
				userSearchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				userSearchPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /UserSearchTextBox_Leave

		#region UserSearchTextBox_TextChanged
		private void UserSearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(userSearchTextBox.Text) || string.Compare(userSearchTextBox.Text, "جستجوی کاربر...") == 0)
			{
				Search = null;
				return;
			}
			else
			{
				Search = userSearchTextBox.Text;

			}
		}
		#endregion /UserSearchTextBox_TextChanged

		#region UserListDataGridView_CellDoubleClick
		private void UserListDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <= -1)
			{
				return;
			}

			if (e.ColumnIndex <= -1)
			{
				return;
			}

			Username = userListDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (string.Compare(Username, "administrator") ==0 || string.Compare(Username, Program.AuthenticatedUser.Username) == 0)
			{
				return;
			}
			else
			{
				ShowInformations(foundedUsername: Username);
				updateButton.Enabled = true;
			}
		}
		#endregion /UserListDataGridView_CellDoubleClick

		#region UsenameLabel_TextChanged
		private void UsernameLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(usernameLabel.Text,"شناسه کاربری")!=0)
			{
				usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
				usernameLabel.Font = Infrastructure.Utility.CenturyGothicFont(emSize: 8);
			}
			else
			{
				usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				usernameLabel.Font = Infrastructure.Utility.IranSansFont(emSize: 8);
				usernameLabel.Text = "شناسه کاربری";
			}
		}
		#endregion /UsenameLabel_TextChanged

		#region AdministratorRadioButton_CheckedChanged
		private void AdministratorRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			AccessLevel_New = null;
			AccessLevel_New = administratorRadioButton.Text;
		}
		#endregion /AdministratorRadioButton_CheckedChanged

		#region EmployeedRadioButton_CheckedChanged
		private void EmployeedRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			AccessLevel_New = null;
			AccessLevel_New = employeedRadioButton.Text;
		}
		#endregion /EmployeedRadioButton_CheckedChanged

		#region ServiceForceradioButton_CheckedChanged
		private void ServiceForceRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			AccessLevel_New = null;
			AccessLevel_New = serviceForceRadioButton.Text;
		}
		#endregion /ServiceForceradioButton_CheckedChanged

		#region SimpleUserRadioButton_CheckedChanged
		private void SimpleUserRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			AccessLevel_New = null;
			AccessLevel_New = simpleUserRadioButton.Text;
		}
		#endregion /SimpleUserRadioButton_CheckedChanged

		#region ActivationCheckBox_CheckedChanged
		private void ActivationCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (activationCheckBox.Checked == true)
			{
				Activation_New = true;
			}
			else
			{
				Activation_New = false;
			}
		}
		#endregion /ActivationCheckBox_CheckedChanged

		#region UpdateButton_Click
		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext = 
					new Models.DataBaseContext();

				if (string.Compare(AccessLevel_New,AccessLeve_FirstLoad) == 0)
				{
					AccessLevel = AccessLeve_FirstLoad;
				}
				else
				{
					AccessLevel = AccessLevel_New;
				}

				if (Activation_New == Activation_FirstLoad)
				{
					IsActive = Activation_FirstLoad;
				}
				else
				{
					IsActive = Activation_New;
				}

				Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, Username) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					return;
				}
				else
				{
					user.IsActive = IsActive;
					user.Access_Level = AccessLevel;
				}
				dataBaseContext.SaveChanges();

				if (string.Compare(AccessLevel_New,AccessLeve_FirstLoad)==0 && Activation_New == Activation_FirstLoad)
				{
					return;
				}
				else if(string.Compare(AccessLevel_New, AccessLeve_FirstLoad) != 0 && Activation_New == Activation_FirstLoad)
				{
					#region EventLog
					EventLog_Username = Program.AuthenticatedUser.Username;
					EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
					EventLog_EventTitle = $"سطح دسترسی کاربر {Username} از {AccessLeve_FirstLoad} به {AccessLevel_New} تغییر کرد";

					Infrastructure.Utility.EventLog
						(username: EventLog_Username,
						fullName: EventLog_FullName,
						eventDate: EventLog_EventDate,
						eventTime: EventLog_EventTime,
						eventTitle: EventLog_EventTitle);
					#endregion /EventLog
				}
				else if (string.Compare(AccessLevel_New, AccessLeve_FirstLoad) == 0 && Activation_New != Activation_FirstLoad)
				{
					#region EventLog
					EventLog_Username = Program.AuthenticatedUser.Username;
					EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";

					if (Activation_New)
					{
						EventLog_EventTitle = $"کاربر {Username} فعال گردید.";
					}
					else
					{
						EventLog_EventTitle = $"کاربر {Username} غیر فعال گردید.";
					}

					Infrastructure.Utility.EventLog
						(username: EventLog_Username,
						fullName: EventLog_FullName,
						eventDate: EventLog_EventDate,
						eventTime: EventLog_EventTime,
						eventTitle: EventLog_EventTitle);
					#endregion /EventLog
				}
				else if (string.Compare(AccessLevel_New, AccessLeve_FirstLoad) != 0 && Activation_New != Activation_FirstLoad)
				{
					#region EventLog
					EventLog_Username = Program.AuthenticatedUser.Username;
					EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";

					if (Activation_New)
					{
						EventLog_EventTitle = $"سطح دسترسی کاربر {Username} از {AccessLeve_FirstLoad} به {AccessLevel_New} تغییر و فعال گردید.";
					}
					else
					{
						EventLog_EventTitle = $"سطح دسترسی کاربر {Username} از {AccessLeve_FirstLoad} به {AccessLevel_New} تغییر و غیر فعال گردید.";
					}

					Infrastructure.Utility.EventLog
						(username: EventLog_Username,
						fullName: EventLog_FullName,
						eventDate: EventLog_EventDate,
						eventTime: EventLog_EventTime,
						eventTitle: EventLog_EventTitle);
					#endregion /EventLog
				}

				UsersLoaded();

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
		#endregion /UpdateButton_Click

		//-----End of coding line

		#region Founctions
		//-----
		#region UsersLoaded
		public void UsersLoaded()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.User> users = null;

				users =
					dataBaseContext.Users
					.OrderBy(currnet => currnet.Username)
					.ToList();

				userListDataGridView.DataSource = users;
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
		#endregion /UsersLoaded

		#region ShowInformations
		private void ShowInformations(string foundedUsername)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, foundedUsername) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					if (string.Compare(user.Username, "administrator") ==0 || string.Compare(user.Username, Program.AuthenticatedUser.Username) == 0)
					{
						return;
					}
					else
					{
						usernameLabel.Text = user.Username;
						AccessLeve_FirstLoad = user.Access_Level;

						switch (AccessLeve_FirstLoad)
						{
							case "مدیریت":
								administratorRadioButton.Checked = true;
								employeedRadioButton.Checked = false;
								serviceForceRadioButton.Checked = false;
								simpleUserRadioButton.Checked = false;
								break;
							case "کارمند":
								administratorRadioButton.Checked = false;
								employeedRadioButton.Checked = true;
								serviceForceRadioButton.Checked = false;
								simpleUserRadioButton.Checked = false;
								break;
							case "نیروی خدمات":
								administratorRadioButton.Checked = false;
								employeedRadioButton.Checked = false;
								serviceForceRadioButton.Checked = true;
								simpleUserRadioButton.Checked = false;
								break;
							case "کاربر ساده":
								administratorRadioButton.Checked = false;
								employeedRadioButton.Checked = false;
								serviceForceRadioButton.Checked = false;
								simpleUserRadioButton.Checked = true;
								break;
							default:
								break;
						}

						Activation_FirstLoad = user.IsActive;
						activationCheckBox.Checked = user.IsActive;

						var byteImage = user.User_Image;
						using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
						{
							userImagePictureBox.BackgroundImage = System.Drawing.Image.FromStream(ms);
						}
						updateButton.Enabled = false;
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
		#endregion /ShowInformations

		//-----
		#endregion /Founctions

		
	}
}
