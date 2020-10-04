
using System.Linq;

namespace HOOKAH_SALON.Setting.User
{
	public partial class LoginControlForm : Infrastructure.BaseForm
	{
		public LoginControlForm()
		{
			InitializeComponent();
		}

		#region Peroperties
		public string Search { get; set; }
		#endregion /Properties

		//-----The beginning of the coding line.

		#region LoginControlForm_Load
		private void LoginControlForm_Load(object sender, System.EventArgs e)
		{
			LogHistoryLoaded();
		}
		#endregion /LoginControlForm_Load

		#region UserSearchTextBox_Enter
		private void UserSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			userSearchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			userSearchTextBox.Select(0, 0);
		}
		#endregion /UserSearchTextBox_Enter

		#region UserSearchTextBox_KeyPress
		private void UserSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(userSearchTextBox.Text, "جستجو...") == 0)
			{
				userSearchTextBox.Clear();
			}
		}
		#endregion /UserSearchTextBox_KeyPress

		#region UserSearchTextBox_Leave
		private void UserSearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(userSearchTextBox.Text, "جستجو...") == 0 || string.IsNullOrWhiteSpace(userSearchTextBox.Text))
			{
				userSearchTextBox.ForeColor =
					Infrastructure.Utility.DarkDimGary();
				Search = null;
				userSearchTextBox.Text = "جستجو...";
				return;
			}
			else
			{
				userSearchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /UserSearchTextBox_Leave

		#region UserSearchTextBox_TextChanged
		private void UserSearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(userSearchTextBox.Text) || string.Compare(userSearchTextBox.Text, "جستجو...") == 0)
			{
				Search = null;
				return;
			}
			else
			{
				Search = userSearchTextBox.Text;
				UsernameSearch(Search);
			}
		}
		#endregion /UserSearchTextBox_TextChanged

		#region PrintButton_Click
		private void PrintButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /PrintButton_Click

		//-----End of coding line

		#region Founctions
		//-----
		#region UsernameSearch
		private void UsernameSearch(string text)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				if (string.IsNullOrWhiteSpace(text))
				{
					logHistories =
						dataBaseContext.LogHistories
						.OrderByDescending(current => current.Logout_Time)
						.ToList();
				}
				else
				{
					logHistories =
						dataBaseContext.LogHistories
						.Where(current => current.Username.Contains(text))
						.OrderByDescending(current => current.Logout_Time)
						.ToList();
				}

				loginControlDataGridView.DataSource = logHistories;
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
			return;
		}
		#endregion /UsernameSearch
		
		#region LogHistoryLoaded
		public void LogHistoryLoaded()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				logHistories =
					dataBaseContext.LogHistories
					.OrderByDescending(current => current.Logout_Time)
					.ToList();

				loginControlDataGridView.DataSource = logHistories;

				if (loginControlDataGridView.Rows.Count <= 9)
				{
					userSearchTextBox.Enabled = false;
					printButton.Enabled = false;
					return;
				}
				if (loginControlDataGridView.Rows.Count >= 10 && loginControlDataGridView.Rows.Count < 15)
				{
					userSearchTextBox.Enabled = true;
					printButton.Enabled = false;
					return;
				}
				if (loginControlDataGridView.Rows.Count >= 15)
				{
					userSearchTextBox.Enabled = true;
					printButton.Enabled = true;
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
		#endregion /LogHistoryLoaded
		//-----
		#endregion /Founctions
	}
}
