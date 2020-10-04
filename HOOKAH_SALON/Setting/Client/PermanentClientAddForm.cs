using Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HOOKAH_SALON.Setting.Client
{
	public partial class PermanentClientAddForm : Infrastructure.BaseForm
	{
		public PermanentClientAddForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string ClientID { get; private set; }
		public string RegisterDate { get; private set; }
		public string RegisterTime { get; private set; }
		public string Username { get; private set; }
		public string FullName { get; private set; }
		public string EventDate { get; private set; }
		public string EventTime { get; private set; }
		public string EventTitle { get; private set; }
		public string ClientFullName { get; private set; }
		#endregion /Properties

		//-----The beginning of the coding line.

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

		#region ClientIDTextBox
		//-----
		#region ClientIDTextBox_Enter
		private void ClientIDTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			clientIDTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			clientIDPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد شناسه") == 0)
			{
				confirmClientIDPicturBox.Visible = false;
				clientIDTextBox.Clear();
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
			if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد شناسه") == 0)
			{
				confirmClientIDPicturBox.Visible = false;
				clientIDTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
				clientIDPanel.BackColor =
					Infrastructure.Utility.DarkGrayColor();
				clientIDTextBox.Text = "کد شناسه";
				clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;				
				ClientID = null;
			}
			else
			{
				ClientID = clientIDTextBox.Text;

				if (ClientID.Length<11)
				{
					confirmClientIDPicturBox.Visible = true;
					confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
					clientIDTextBox.Focus();
					ClientID = null;
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
							//ClientID = clientIDTextBox.Text;
							confirmClientIDPicturBox.Visible = true;
							confirmClientIDPicturBox.Image = Properties.Resources.Tik_True;
							saveButton.Enabled = true;
							clientIDTextBox.Text = clientIDTextBox.Text.Insert(4, "-");

							ClientID = ClientID.Replace("-", string.Empty).Trim();
						}
						else
						{
							clientIDTextBox.Focus();
							return;
						}
						
					}
					else if(Validation_ClientID(clientIDTextBox.Text) == false)
					{
						confirmClientIDPicturBox.Visible = true;
						confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;

						clientIDTextBox.Focus();
						ClientID = null;
						saveButton.Enabled = false;
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
				resetButton.Enabled = false;
				confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
				saveButton.Enabled = false;
				confirmClientIDPicturBox.Visible = false;
				ClientID = null;
				return;
			}
			else
			{
				resetButton.Enabled = true;
				if (clientIDTextBox.Text.Length<11)
				{
					confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
					saveButton.Enabled = false;
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
						saveButton.Enabled = true;
						ClientID = clientIDTextBox.Text;
						clientIDTextBox.Select(11, 0);
					}
					else
					{
						confirmClientIDPicturBox.Image = Properties.Resources.Tik_False;
						confirmClientIDPicturBox.Visible = true;
						ClientID = null;
						saveButton.Enabled = false;
					}
				}
			}
		}
		#endregion /ClientIDTextBox_TextChanged 
		//-----
		#endregion /ClientIDTextBox

		#region FullNameTextBox
		//-----
		#region FullNameTextBox_Enter
		private void FullNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			fullNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			fullNamePanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.Compare(fullNameTextBox.Text, "نام کامل") == 0)
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
			if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.Compare(fullNameTextBox.Text, "نام کامل") == 0)
			{
				fullNameTextBox.ForeColor =
					Infrastructure.Utility.DarkGrayColor();
				fullNamePanel.BackColor =
					Infrastructure.Utility.DarkGrayColor();
				fullNameTextBox.Text = "نام کامل";
				ClientFullName = string.Empty;
			}
			else
			{
				fullNameTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				fullNamePanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				ClientFullName = fullNameTextBox.Text;
			}
		}
		#endregion /FullNameTextBox_Leave
		//-----
		#endregion /FullNameTextBox

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string errorMessage = null;

				#region Validate
				//-----
				if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد شناسه") == 0)
				{
					errorMessage = "فیلد کد شناسه را تکمیل کنید!";
				}
				if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.Compare(fullNameTextBox.Text,"نام کامل")==0)
				{
					if (errorMessage != null)
					{
						errorMessage += System.Environment.NewLine;
					}

					errorMessage +=
						"فیلد نام کامل را تکمیل کنید!";
				}

				if (errorMessage != null)
				{
					if (string.IsNullOrWhiteSpace(clientIDTextBox.Text) || string.Compare(clientIDTextBox.Text, "کد شناسه") == 0)
					{
						clientIDTextBox.Focus();
					}
					else if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.Compare(fullNameTextBox.Text, "نام کامل") == 0)
					{
						fullNameTextBox.Focus();
					}

					Mbb.Windows.Forms.MessageBox.Show
						(text: errorMessage,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				//-----
				#endregion /Validate

				System.Windows.Forms.DialogResult dialogResult;
				string message = $"کد شناسه {ClientID} ذخیره گردد؟.";

				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: message,
						caption: "ذخیره اطلاعات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.PermanentClient client =
								dataBaseContext.PermanentClients
								.Where(current => string.Compare(current.Client_ID, ClientID) == 0)
								.FirstOrDefault();

					if (client == null)
					{
						RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						RegisterTime = Infrastructure.Utility.ShowTime();

						client =
							new Models.PermanentClient
							{
								Client_ID = ClientID,
								Full_Name = ClientFullName,
								Register_Date = $"{RegisterTime} - {RegisterDate}",
								Last_Order = "00:00:00 - 0000/00/00",
								Number_Order = 0,
								Edit_Date = "00:00:00 - 0000/00/00",
							};

						dataBaseContext.PermanentClients.Add(client);
						dataBaseContext.SaveChanges();

						if (ClientManegmentForm.PermanentClientListForm != null)
						{
							ClientManegmentForm.PermanentClientListForm.PermanentClientListLoaded();
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = $"ثبت مشتری با کد {ClientID} و نام {ClientFullName}";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog
					}
				}
				else
				{
					return;
				}
				string successMessage =
					$"اطلاعات کاربر {ClientID} با موفقیت ذخیره گرید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

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

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult;
			string message = $"آیا اطلاعات پاک شود؟.";

			dialogResult = Mbb.Windows.Forms.MessageBox.Show
				(text: message,
					caption: "پاک شدن اطلاعات",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				AllClear();
			}
		}
		#endregion /ResetButton_Click

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

		#region AllClear
		private void AllClear()
		{
			ClientID = null;
			clientIDTextBox.Text = "کد شناسه";
			clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			clientIDTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			clientIDPanel.BackColor =
				Infrastructure.Utility.DarkGrayColor();

			ClientFullName = null;
			fullNameTextBox.Text = "نام کامل";
			fullNameTextBox.ForeColor =
				Infrastructure.Utility.DarkGrayColor();
			fullNamePanel.BackColor =
				Infrastructure.Utility.DarkGrayColor();

			saveButton.Enabled = false;
			resetButton.Enabled = false;

			RegisterDate = null;
			RegisterTime = null;
		}
		#endregion /AllClear
		//-----
		#endregion /Founctions

		
	}
}
