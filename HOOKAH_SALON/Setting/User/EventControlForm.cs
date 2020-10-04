using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HOOKAH_SALON.Setting.User
{
	public partial class EventControlForm : Infrastructure.BaseForm
	{
		public EventControlForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Search { get; set; }

		#region EventList
		public class EventList
		{
			public string UserName { get; set; }
			public string FullName { get; set; }
			public string EventDate { get; set; }
			public string Event { get; set; }
		}
		#endregion /EventList

		#endregion /Properties

		//-----The beginning of the coding line.

		#region EventControlForm_Load
		private void EventControlForm_Load(object sender, System.EventArgs e)
		{
			EventHistoryLoaded();
		}
		#endregion /EventControlForm_Load

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
					Infrastructure.Utility.DimGrayColor();
				userSearchPanel.BackColor =
					Infrastructure.Utility.BlackColor();
				Search = null;
				userSearchTextBox.Text = "جستجو...";
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
			if (string.IsNullOrWhiteSpace(userSearchTextBox.Text) || string.Compare(userSearchTextBox.Text, "جستجو...") == 0)
			{
				Search = null;
				return;
			}
			else
			{
				Search = userSearchTextBox.Text;
				UsernameSearch(Search);
				return;
			}
		}
		#endregion /UserSearchTextBox_TextChanged

		#region PrintButton_Click
		private void PrintButton_Click(object sender, System.EventArgs e)
		{
			List<EventList> listEventLists = new List<EventList>();

			foreach (DataGridViewRow rows in eventControlDataGridView.Rows)
			{
				EventList eventList = new EventList
				{
					UserName = rows.Cells[0].Value.ToString(),
					FullName = rows.Cells[1].Value.ToString(),
					EventDate = rows.Cells[2].Value.ToString(),
					Event = rows.Cells[3].Value.ToString(),
				};

				listEventLists.Add(eventList);
			}

			string orderDate = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
			StiReport eventHistoryReport = new StiReport();

			eventHistoryReport.Load("EventReport.mrt");
			eventHistoryReport.RegBusinessObject("EventLog", listEventLists);

			(eventHistoryReport.GetComponentByName("datePublicationReportTextBox") as StiText).Text = orderDate;

			eventHistoryReport.Show(false);
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

				System.Collections.Generic.List<Models.EventLog> eventLogs = null;

				if (string.IsNullOrWhiteSpace(text))
				{
					eventLogs =
						dataBaseContext.EventLogs
						.OrderByDescending(current => current.Event_Date)
						.ToList();
				}
				else
				{
					eventLogs =
						dataBaseContext.EventLogs
						.Where(current => current.Username.Contains(text))
						.OrderByDescending(current => current.Event_Date)
						.ToList();
				}

				eventControlDataGridView.DataSource = eventLogs;
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

		#region EventHistoryLoaded
		public void EventHistoryLoaded()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.EventLog> eventLogs = null;

				eventLogs =
					dataBaseContext.EventLogs
					.OrderByDescending(current => current.Event_Date)
					.ToList();

				eventControlDataGridView.DataSource = eventLogs;

				if (eventControlDataGridView.Rows.Count <= 9)
				{
					userSearchTextBox.Enabled = false;
					printButton.Enabled = false;
					return;
				}
				else if (eventControlDataGridView.Rows.Count >= 10 && eventControlDataGridView.Rows.Count < 15 )
				{
					userSearchTextBox.Enabled = true;
					printButton.Enabled = false;
					return;
				}
				else if (eventControlDataGridView.Rows.Count >= 15)
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
		#endregion /EventHistoryLoaded
		//-----
		#endregion /Founctions
	}
}