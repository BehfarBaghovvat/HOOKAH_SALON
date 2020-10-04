using System.Linq;

namespace HOOKAH_SALON.Setting.Client
{
	public partial class PermanentClientEditForm : Infrastructure.BaseForm
	{
		public PermanentClientEditForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Username { get; set; }
		public string FullName { get; set; }
		public string EventDate { get; set; }
		public string EventTime { get; private set; }
		public string EventTitle { get; set; }
		public string ClientID_Load { get; set; }
		public string ClientID { get; set; }
		public string ClientFullName { get; set; }
		public PermanentClientListForm MyPermanentClientListForm { get; set; }
		public string ClientID_FirstLoad { get; private set; }
		public string FullName_FirstLoad { get; private set; }
		public string ClientID_New { get; private set; }
		public string FullName_New { get; private set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region PermanentClientEditForm_Load
		private void PermanentClientEditForm_Load(object sender, System.EventArgs e)
		{
			ClientLoad(ClientID_Load);
		}
		#endregion /PermanentClientEditForm_Load

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

		#region ClientIDTextBox_Enter
		private void ClientIDTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			clientIDTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientIDPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (clientIDTextBox.Text.Contains("-"))
			{
				clientIDTextBox.Text = clientIDTextBox.Text.Replace("-", string.Empty).Trim();
			}
		}
		#endregion /ClientIDTextBox_Enter

		#region ClientIDTextBox_KeyPress
		private void ClientIDTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ClientIDTextBox_KeyPress

		#region ClientIDTextBox_Leave
		private void ClientIDTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, ClientID_FirstLoad) == 0)
			{
				confirmClientIDPicturBox.Visible = false;
				clientIDTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				clientIDPanel.BackColor =
					Infrastructure.Utility.DarkGrayColor();
				clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				clientIDTextBox.Text = ClientID_FirstLoad.Insert(4, "-");
				ClientID_New = string.Empty;
			}
			else
			{
				ClientID_New = clientIDTextBox.Text;

				if (ClientID.Length < 11)
				{
					confirmClientIDPicturBox.Visible = true;
					confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
					clientIDTextBox.Focus();
					ClientID_New = null;
					return;
				}
				else
				{
					if (Validation_ClientID(clientIDTextBox.Text) == true)
					{
						clientIDTextBox.ForeColor =
							Infrastructure.Utility.WhiteColor();
						clientIDPanel.BackColor =
							Infrastructure.Utility.WhiteColor();
						clientIDTextBox.TextAlign =
							System.Windows.Forms.HorizontalAlignment.Right;

						if (clientIDTextBox.Text.StartsWith("09"))
						{
							showMessageToolTip.ToolTipTitle = "فرمت کد باید با 09 آغاز گردد.";
							confirmClientIDPicturBox.Visible = true;
							confirmClientIDPicturBox.Image = Properties.Resources.Tik_True;
							editClientButton.Enabled = true;
							clientIDTextBox.Text = clientIDTextBox.Text.Insert(4, "-");
							ClientID_New = ClientID_New.Replace("-", string.Empty).Trim();
						}
						else
						{
							clientIDTextBox.Focus();
							return;
						}
					}
					else if (Validation_ClientID(clientIDTextBox.Text) == false)
					{
						confirmClientIDPicturBox.Visible = true;
						confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;

						clientIDTextBox.Focus();
						ClientID_New = null;
						editClientButton.Enabled = false;
					}
				}
			}
		}
		#endregion /ClientIDTextBox_Leave

		#region ClientIDTextBox_TextChanged
		private void ClientIDTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد شناسه") == 0)
			{
				clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				ClientID_New = null;

				confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
				confirmClientIDPicturBox.Visible = false;
				ClientID_New = null;
			}
			else
			{
				if (clientIDTextBox.Text.Length < 11)
				{
					confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
					return;
				}
				else
				{
					clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					clientIDTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
					clientIDPanel.BackColor =
						Infrastructure.Utility.WhiteColor();

					if (Validation_ClientID(clientIDTextBox.Text) == true)
					{
						confirmClientIDPicturBox.Visible = true;
						confirmClientIDPicturBox.Image = Properties.Resources.Tik_True;
						ClientID_New = clientIDTextBox.Text;
						clientIDTextBox.Select(11, 0);
					}
					else
					{
						confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
						confirmClientIDPicturBox.Visible = true;
						ClientID_New = null;
					}
				}
			}
		}
		#endregion /ClientIDTextBox_TextChanged

		#region FullNameTextBox_Enter
		private void FullNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			fullNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			fullNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(fullNameTextBox.Text, FullName_FirstLoad) == 0)
			{
				fullNameTextBox.Clear();
			}
		}
		#endregion /FullNameTextBox_Enter

		#region FullNameTextBox_KeyPress
		private void FullNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /FullNameTextBox_KeyPress

		#region FullNameTextBox_Leave
		private void FullNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.Compare(fullNameTextBox.Text, FullName_FirstLoad) == 0)
			{
				fullNameTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				fullNamePanel.BackColor =
					Infrastructure.Utility.DarkGrayColor();
				fullNameTextBox.Text = FullName_FirstLoad;
				FullName = null;
			}
			else
			{
				fullNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				fullNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				FullName_New = fullNameTextBox.Text;
			}
		}
		#endregion /FullNameTextBox_Leave

		#region EditClientButton_Click
		private void EditClientButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Windows.Forms.DialogResult dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: "آیا برای انجام تغییر اطمینان دارید؟",
					caption: "دستور ویرایش",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.PermanentClient permanentClient =
					new Models.PermanentClient
					{
						Client_ID = ClientID_New,
						Full_Name = FullName_New,
					};

					dataBaseContext.SaveChanges();

					Infrastructure.Utility.WindowsNotification
						(message: "ویرایش انجام شد.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					#region EventLog
					Username = Program.AuthenticatedUser.Username;
					FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventTime = $"{Infrastructure.Utility.ShowTime()}";
					EventTitle = $"ویرایش کد {ClientID_FirstLoad} به {ClientID_New} و یا نام {FullName_FirstLoad} به {FullName_New}";

					Infrastructure.Utility.EventLog
						(username: Username,
						fullName: FullName,
						eventDate: EventDate,
						eventTime: EventTime,
						eventTitle: EventTitle);
					#endregion /EventLog
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
		#endregion /EditClientButton_Click

		//-----End of coding line.

		#region Founctions
		//-----
		#region Validation_ClientID
		private bool Validation_ClientID(string clientID)
		{
			bool status = false;

			Models.DataBaseContext dataBaseContext = null;

			dataBaseContext =
				new Models.DataBaseContext();

			Models.PermanentClient client =
				dataBaseContext.PermanentClients
				.Where(current => string.Compare(current.Client_ID, clientID) == 0)
				.FirstOrDefault();

			if (client == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			return status;
		}
		#endregion /Validation_ClientID

		#region ClientLoad
		private void ClientLoad(string clientID)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.PermanentClient permanentClient =
					dataBaseContext.PermanentClients
					.Where(current => string.Compare(current.Client_ID, clientID) == 0)
					.FirstOrDefault();

				if (permanentClient != null)
				{
					ClientID_FirstLoad = permanentClient.Client_ID;
					FullName_FirstLoad = permanentClient.Full_Name;
				}

				if (ClientID_FirstLoad.StartsWith("09"))
				{
					clientIDTextBox.Text = ClientID_FirstLoad.Insert(4, "-");
				}

				fullNameTextBox.Text = FullName_FirstLoad;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext!=null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /ClientLoad
		//-----
		#endregion /Founctions

		
	}
}
