using Models;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace HOOKAH_SALON.Setting.Client
{
	public partial class PermanentClientListForm : Infrastructure.BaseForm
	{
		public PermanentClientListForm()
		{
			InitializeComponent();
		}

		Models.PermanentClient permanentClient = new Models.PermanentClient();

		#region MainForm
		private static MainForm mainForm = null;

		public static MainForm MainForm
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
		}
		#endregion /MainForm

		#region PermanentClientAddForm
		private PermanentClientAddForm permanentClientAddForm;

		public PermanentClientAddForm PermanentClientAddForm
		{
			get
			{
				if (permanentClientAddForm == null || permanentClientAddForm.IsDisposed == true)
				{
					permanentClientAddForm =
						new PermanentClientAddForm();
				}
				return permanentClientAddForm;
			}
		}
		#endregion /RegularClientAddForm

		#region Properties
		public string Client_ID { get; set; }
		public string Search { get; private set; }

		public bool FoundClientID { get; set; }
		public bool FoundClientName { get; set; }

		public int SelectIndex { get; set; }
		public string Username { get; private set; }
		public string FullName { get; private set; }
		public string EventDate { get; private set; }
		public string EventTime { get; private set; }
		public string EventTitle { get; private set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region PermanentClientListForm_Load
		private void PermanentClientListForm_Load(object sender, System.EventArgs e)
		{
			PermanentClientListLoaded();
		}
		#endregion /PermanentClientListForm_Load

		#region ClientAddButton_Click
		private void ClientAddButton_Click(object sender, System.EventArgs e)
		{
			PermanentClientAddForm.ShowDialog();
		}
		#endregion /ClientAddButton_Click

		#region SearchClientIDRadioButton_CheckedChanged
		private void SearchClientIDRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			FoundClientID = true;
			FoundClientName = false;
		}
		#endregion /SearchClientIDRadioButton_CheckedChanged

		#region SeachClientNameRadioButton_CheckedChanged
		private void SeachClientNameRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			FoundClientID = false;
			FoundClientName = true;
		}
		#endregion /SeachClientNameRadioButton_CheckedChanged

		#region SearchClientTextBox
		//-----
		#region SearchClientTextBox_Enter
		private void SearchClientTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			searchClientTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			searchClientPanel.BackColor =
				Infrastructure.Utility.WhiteColor();

			searchClientTextBox.Select(27, 0);
		}
		#endregion /SearchClientTextBox_Enter

		#region SearchClientTextBox_KeyPress
		private void SearchClientTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);

			if (string.Compare(searchClientTextBox.Text, "جستجوی کد شناسه / نام مشتری...") == 0)
			{
				searchClientTextBox.Clear();
			}
		}
		#endregion /SearchClientTextBox_KeyPress

		#region SearchClientTextBox_Leave
		private void SearchClientTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchClientTextBox.Text) || string.Compare(searchClientTextBox.Text, "جستجوی کد شناسه / نام مشتری...") == 0)
			{
				searchClientTextBox.ForeColor =
					Infrastructure.Utility.GrayColor();
				searchClientPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				searchClientTextBox.Text = "جستجوی کد شناسه / نام مشتری...";
				Search = null;
				return;
			}
			else
			{
				searchClientTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				searchClientPanel.BackColor =
					Infrastructure.Utility.WhiteColor();
				Search = searchClientTextBox.Text;
			}
		}
		#endregion /SearchClientTextBox_Leave

		#region SearchClientTextBox_TextChanged
		private void SearchClientTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchClientTextBox.Text) || string.Compare(searchClientTextBox.Text, "جستجوی کد شناسه / نام مشتری...") == 0)
			{

				Search = null;
				return;
			}
			else
			{
				Search = searchClientTextBox.Text;

				if (FoundClientID == true)
				{
					SearchClientID(Search);
				}
				else if (FoundClientName == true)
				{
					SearchClientName(Search);
				}
				else
				{
					return;
				}
			}
		}
		#endregion /SearchClientTextBox_TextChanged 
		//-----
		#endregion /SearchClientTextBox

		#region DeletePermancentClientButton_Click
		private void DeletePermancentClientButton_Click(object sender, System.EventArgs e)
		{
			if (permanentClientDataGridView.Rows.Count>=1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"{permanentClientDataGridView.CurrentRow.Cells[0].Value} حذف گردد؟!",
					caption: "حذف رکورد",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف مشترک
				{
					string clientID = permanentClientDataGridView.CurrentRow.Cells[0].Value.ToString();
					string clientName = permanentClientDataGridView.CurrentRow.Cells[1].Value.ToString();

					using (DataBaseContext dataBaseContext = new DataBaseContext())
					{
						Models.PermanentClient permanentClient =
							dataBaseContext.PermanentClients
							.Where(current => string.Compare(current.Client_ID, clientID) == 0)
							.FirstOrDefault();
						if (permanentClient != null)
						{
							var entry = dataBaseContext.Entry(permanentClient);

							if (entry.State == EntityState.Detached)
							{
								dataBaseContext.PermanentClients.Attach(permanentClient);
							}
						}

						#region EventLog
						Username = Program.AuthenticatedUser.Username;
						FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventTitle = EventTitle = $"{clientName} حذف گردید.";

						Infrastructure.Utility.EventLog
							(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventTitle);
						#endregion /EventLog

						dataBaseContext.PermanentClients.Remove(permanentClient);
						dataBaseContext.SaveChanges();
						PermanentClientListLoaded();
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کد مورد نظر حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: $"موردی برای حذف وجود ندارد!",
					caption: "اخطار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return;
			}
		}
		#endregion /DeletePermancentClientButton_Click

		#region PermanentClientDataGridView_CellDoubleClick
		private void PermanentClientDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <=-1)
			{
				return;
			}
			if (e.ColumnIndex <= -1)
			{
				return;
			}

			string clientID = permanentClientDataGridView.CurrentRow.Cells[0].Value.ToString();

			PermanentClientEditForm permanentClientEditForm = new PermanentClientEditForm
			{
				MyPermanentClientListForm = this,
				ClientID_Load = clientID,
			};

			permanentClientEditForm.Show();
		}
		#endregion /PermanentClientDataGridView_CellDoubleClick

		//-----End of coding line

		#region Founction
		//-----
		#region ApprovalClientID
		private bool ApprovalClientID(string search)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.PermanentClient permanentClient =
				dataBaseContext.PermanentClients
				.Where(current => string.Compare(current.Client_ID, search) == 0)
				.FirstOrDefault();

			if (permanentClient != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion /ApprovalClientID

		#region ApprovalClientName
		private bool ApprovalClientName(string search)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.PermanentClient permanentClient =
				dataBaseContext.PermanentClients
				.Where(current => string.Compare(current.Full_Name, search) == 0)
				.FirstOrDefault();

			if (permanentClient != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion /ApprovalClientName

		#region SearchClientID
		private void SearchClientID(string seach)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.PermanentClient> permanentClients = null;

				if (string.IsNullOrEmpty(seach))
				{
					permanentClients =
						dataBaseContext.PermanentClients
						.OrderBy(current => current.Full_Name)
						.ToList();
				}
				else
				{
					permanentClients =
						dataBaseContext.PermanentClients
						.Where(current => current.Client_ID.Contains(seach))
						.OrderBy(current => current.Client_ID)
						.ToList();
				}

				permanentClientDataGridView.DataSource = permanentClients;
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
		#endregion /SearchClientID

		#region SearchClientName
		private void SearchClientName(string seach)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.PermanentClient> permanentClients = null;

				if (string.IsNullOrEmpty(seach))
				{
					permanentClients =
						dataBaseContext.PermanentClients
						.OrderBy(current => current.Full_Name)
						.ToList();
				}
				else
				{
					permanentClients =
						dataBaseContext.PermanentClients
						.Where(current => current.Full_Name.Contains(seach))
						.OrderBy(current => current.Full_Name)
						.ToList();
				}

				permanentClientDataGridView.DataSource = permanentClients;
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
		#endregion /SearchClientName

		#region PermanentClientListLoaded
		public void PermanentClientListLoaded()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.PermanentClient> permanentClients = null;

				permanentClients =
					dataBaseContext.PermanentClients
					.OrderBy(current => current.Full_Name)
					.ToList();

				permanentClientDataGridView.DataSource = permanentClients;
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
		#endregion /PermanentClientListLoaded
		//-----
		#endregion /Founction

		
	}
}
