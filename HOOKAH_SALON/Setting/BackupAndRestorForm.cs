using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HOOKAH_SALON.Setting
{
	public partial class BackupAndRestorForm : Infrastructure.BaseForm
	{
		public BackupAndRestorForm()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection(HOOKAH_SALON.Properties.Settings.Default.HOOKAHSALONConnectionString);

		string dateSet = $"{Infrastructure.Utility.ShowTime()}-{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";

		public string EventLog_Username { get; private set; }
		public string EventLog_FullName { get; private set; }
		public string EventLog_EventDate { get; private set; }
		public string EventLog_EventTime { get; private set; }
		public string EventLog_EventTitle { get; private set; }

		#region SelectSavePathButton_Click
		private void SelectSavePathButton_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				savePathTextBox.Text = folderBrowserDialog.SelectedPath;
				savePathTextBox.ForeColor = Infrastructure.Utility.WhiteColor();
			}
			else
			{
				savePathTextBox.Text = "Save Path...";
				savePathTextBox.ForeColor = Infrastructure.Utility.GrayColor();
			}
		}
		#endregion /SelectSavePathButton_Click

		#region BackupButton_Click
		private void BackupButton_Click(object sender, System.EventArgs e)
		{
			string dataBase = sqlConnection.Database.ToString();
			try
			{
				if (string.IsNullOrWhiteSpace(savePathTextBox.Text) || string.Compare(savePathTextBox.Text, "Save Path...") == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "لطفا برای ذخیره یک مسیر انتخاب نمایید.",
						caption: "",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					selectSavePathButton.Focus();
				}
				else
				{
					string command = $"Backup Database [{dataBase}] To Disk='{savePathTextBox.Text}\\Database-{System.DateTime.Now:yyyy-MM-dd--HH-mm-ss}.bak'";
					this.Cursor = Cursors.WaitCursor;
					SqlConnection sqlConnection = null;
					SqlCommand sqlCommand = null;

					sqlConnection = new SqlConnection($"Data Source=.;Initial Catalog={dataBase}; Integrated Security=True");

					if (sqlConnection.State != System.Data.ConnectionState.Open)
					{
						sqlConnection.Open();
					}

					sqlCommand = new SqlCommand(command, sqlConnection);
					sqlCommand.ExecuteNonQuery();
					this.Cursor = Cursors.Default;
					Mbb.Windows.Forms.MessageBox.Show(text: "پشتیبان گیری انجام شد.", caption: "تکمیل عملیات", icon: Mbb.Windows.Forms.MessageBoxIcon.Success, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					savePathTextBox.Text = "Save Path...";
					savePathTextBox.ForeColor = Infrastructure.Utility.GrayColor();

					#region EventLog
					EventLog_Username = Program.AuthenticatedUser.Username;
					EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
					EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
					EventLog_EventTitle = $"تهیه نسخه پشتیبان";

					Infrastructure.Utility.EventLog
						(username: EventLog_Username,
						fullName: EventLog_FullName,
						eventDate: EventLog_EventDate,
						eventTime: EventLog_EventTime,
						eventTitle: EventLog_EventTitle);
					#endregion /EventLog
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /BackupButton_Click

		#region SelectLoadPathButton_Click
		private void SelectLoadPathButton_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "SQL SERVER database backup files | *.bak";
			openFileDialog.Title = "SQL SERVER Backup Restor";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				loadPathTextBox.Text = openFileDialog.FileName;
				loadPathTextBox.ForeColor = Infrastructure.Utility.WhiteColor();
			}
			else
			{
				loadPathTextBox.Text = "Load Path...";
				loadPathTextBox.ForeColor = Infrastructure.Utility.GrayColor();
			}
		}
		#endregion /SelectLoadPathButton_Click

		#region LoadBackupButton_Click
		private void LoadBackupButton_Click(object sender, System.EventArgs e)
		{
			string dataBase = sqlConnection.Database.ToString();
			try
			{
				string command = $"ALTER DATABASE {dataBase}  SET SINGLE_USER with ROLLBACK IMMEDIATE  USE master RESTORE DATABASE {dataBase} FROM DISK='{loadPathTextBox.Text}' WITH REPLACE";

				this.Cursor = Cursors.WaitCursor;
				SqlCommand ocommand = null;
				SqlConnection oconnection = null;
				oconnection = new SqlConnection($"Data Source=.;Initial Catalog={dataBase}; Integrated Security=True");

				if (oconnection.State != ConnectionState.Open)

					oconnection.Open();

				ocommand = new SqlCommand(command, oconnection);

				ocommand.ExecuteNonQuery();

				Mbb.Windows.Forms.MessageBox.Show(text: "!بازیابی اطلاعات انجام شد", caption: "تکمیل اعملیات", icon: Mbb.Windows.Forms.MessageBoxIcon.Success, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				loadPathTextBox.Text = "Load Path...";
				loadPathTextBox.ForeColor = Infrastructure.Utility.GrayColor();
				sqlConnection.Close();
				this.Cursor = Cursors.Default;

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"بازگردانی نسخه {loadPathTextBox.Text}";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /LoadBackupButton_Click
	}
}
