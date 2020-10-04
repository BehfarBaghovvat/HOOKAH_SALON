using Models;
using System.Collections.Generic;
using System.Linq;

namespace HOOKAH_SALON.Report
{
	public partial class ClientAccountStatusForm : Infrastructure.BaseForm
	{
		public string SearchClientID { get; private set; }
		public string Remaining_string { get; private set; }
		public int Remaining { get; private set; }
		public string PaymentAmount_String { get; private set; }
		public int PaymentAmount_Int { get; private set; }
		public string AccountStatus { get; private set; }
		public string EventLog_Username { get; private set; }
		public string EventLog_FullName { get; private set; }
		public string EventLog_EventDate { get; private set; }
		public string EventLog_EventTime { get; private set; }
		public string EventLog_EventTitle { get; private set; }
		public string Payment_Type { get; set; }

		public ClientAccountStatusForm()
		{
			InitializeComponent();
		}

		#region  SearchClientIDTextBox
		//-----
		#region SearchClientIDTextBox_Enter
		private void SearchClientIDTextBox_Enter(object sender, System.EventArgs e)
		{
			searchClientIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

			if (string.Compare(searchClientIDTextBox.Text, "کد شناسه...") == 0)
			{
				searchClientIDTextBox.Clear();
			}
			else
			{
				return;
			}
		}
		#endregion /SearchClientIDTextBox_Enter

		#region SearchClientIDTextBox_KeyPress
		private void SearchClientIDTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /SearchClientIDTextBox_KeyPress

		#region SearchClientIDTextBox_Leave
		private void SearchClientIDTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(searchClientIDTextBox.Text, "کد شناسه...") == 0 || string.IsNullOrWhiteSpace(searchClientIDTextBox.Text))
			{
				searchClientIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				searchClientIDTextBox.Text = "کد شناسه...";
				SearchClientID = null;
			}
			else
			{
				if (searchClientIDTextBox.Text.Length < 11)
				{
					return;
				}
				else if (searchClientIDTextBox.Text.StartsWith("09"))
				{
					searchClientIDTextBox.Text = searchClientIDTextBox.Text.Insert(4, "-");
				}
			}
		}
		#endregion /SearchClientIDTextBox_Leave

		#region SearchClientIDTextBox_TextChanged
		private void SearchClientIDTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(searchClientIDTextBox.Text, "کد شناسه...") == 0 || string.IsNullOrWhiteSpace(searchClientIDTextBox.Text))
			{
				return;
			}
			else
			{
				if (searchClientIDTextBox.Text.Length < 11)
				{
					return;
				}
				else if (searchClientIDTextBox.Text.StartsWith("09"))
				{
					SearchClientID = searchClientIDTextBox.Text;
					ClientFinancialAccount(SearchClientID);
				}
			}
		}
		#endregion /SearchClientIDTextBox_TextChanged
		//-----
		#endregion / SearchClientIDTextBox

		#region AmountTextBox_TextChanged
		private void AmountTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(amountTextBox.Text, "مبلغ") != 0)
			{
				return;
			}
			else
			{
				Remaining_string = null;
				Remaining = 0;

				Remaining_string = amountTextBox.Text.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim();
				Remaining = int.Parse(Remaining_string);
			}
		}
		#endregion /AmountTextBox_TextChanged

		#region CashRradioButton_CheckedChanged
		private void CashRradioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = "نقد";
		}
		#endregion /CashRradioButton_CheckedChanged

		#region CardRadioButton_CheckedChanged
		private void CardRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = "کارت";
		}
		#endregion /CardRadioButton_CheckedChanged

		#region ChashAndCardRadioButton_CheckedChanged
		private void ChashAndCardRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			Payment_Type = null;
			Payment_Type = "نقد و کارت";
		}
		#endregion /ChashAndCardRadioButton_CheckedChanged

		#region PaymentAmountTextBox
		//-----
		#region PaymentAmountTextBox_Enter
		private void PaymentAmountTextBox_Enter(object sender, System.EventArgs e)
		{
			Remaining_string = amountTextBox.Text.Replace(",", string.Empty).Trim().Replace("تومان", string.Empty).Trim();
			Remaining = int.Parse(Remaining_string);

			if (string.Compare(paymentAmountTextBox.Text, "پرداخت مبلغ") == 0)
			{
				paymentAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				paymentAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				paymentAmountTextBox.Text = "0 تومان";
				//paymentAmountTextBox.Select(5, paymentAmountTextBox.Text.Length);
			}
			else if (paymentAmountTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /PaymentAmountTextBox_Enter

		#region PaymentAmountTextBox_KeyPress
		private void PaymentAmountTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PaymentAmountTextBox_KeyPress

		#region PaymentAmountTextBox_Leave
		private void PaymentAmountTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(paymentAmountTextBox.Text) || string.Compare(paymentAmountTextBox.Text, "پرداخت مبلغ") == 0 || string.Compare(paymentAmountTextBox.Text, "0 تومان") == 0)
			{
				paymentAmountTextBox.Text = "پرداخت مبلغ";
				PaymentAmount_String = null;
				PaymentAmount_Int = 0;
				return;
			}
			else if (string.Compare(paymentAmountTextBox.Text, "تومان") == 0 || string.Compare(paymentAmountTextBox.Text, " تومان") == 0 || string.Compare(paymentAmountTextBox.Text, "توما") == 0 || string.Compare(paymentAmountTextBox.Text, "توم") == 0 || string.Compare(paymentAmountTextBox.Text, "تو") == 0 || string.Compare(paymentAmountTextBox.Text, "ت") == 0)
			{
				PaymentAmount_Int = 0;
				PaymentAmount_String = null;
				return;
			}
			else
			{
				PaymentAmount_String = paymentAmountTextBox.Text.Replace("تومان", string.Empty).Trim();
				PaymentAmount_Int = int.Parse(PaymentAmount_String.Replace(",", string.Empty).Trim());
				paymentAmountTextBox.Text = $"{PaymentAmount_Int:#,0} تومان";
			}
		}
		#endregion /PaymentAmountTextBox_Leave

		#region PaymentAmountTextBox_TextChanged
		private void PaymentAmountTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(paymentAmountTextBox.Text, "پرداخت مبلغ") == 0 || string.IsNullOrWhiteSpace(paymentAmountTextBox.Text))
			{
				PaymentAmount_Int = 0;
				PaymentAmount_String = null;
				return;
			}
			else if (string.Compare(paymentAmountTextBox.Text, "تومان") == 0 || string.Compare(paymentAmountTextBox.Text, " تومان") == 0 || string.Compare(paymentAmountTextBox.Text, "توما") == 0 || string.Compare(paymentAmountTextBox.Text, "توم") == 0 || string.Compare(paymentAmountTextBox.Text, "تو") == 0 || string.Compare(paymentAmountTextBox.Text, "ت") == 0)
			{
				PaymentAmount_Int = 0;
				PaymentAmount_String = null;
				return;
			}
			else if (paymentAmountTextBox.Text.Contains("تومان"))
			{
				PaymentAmount_String = paymentAmountTextBox.Text.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim();
				PaymentAmount_Int = int.Parse(PaymentAmount_String);
				return;
			}
		}
		#endregion /PaymentAmountTextBox_TextChanged
		//-----
		#endregion /PaymentAmountTextBox

		#region PaymentAmountButton_Click
		private void PaymentAmountButton_Click(object sender, System.EventArgs e)
		{
			SearchClientID = SearchClientID.Replace("-", string.Empty).Trim();
			int resultRemaining = Remaining + PaymentAmount_Int;
			string orderDate, dateSettlement;

			dateSettlement = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
			if (resultRemaining < 0)
			{
				AccountStatus = "بدهکار";
				debtorStatusRadioButton.Checked = true;
				settlementStatusRadioButton.Checked = false;
				creditorStatusRadioButton.Checked = false;
			}
			else if (resultRemaining == 0)
			{
				AccountStatus = "تسویه";
				debtorStatusRadioButton.Checked = false;
				settlementStatusRadioButton.Checked = true;
				creditorStatusRadioButton.Checked = false;
			}
			else if (resultRemaining > 0)
			{
				AccountStatus = "طلبکار";
				debtorStatusRadioButton.Checked = false;
				settlementStatusRadioButton.Checked = false;
				creditorStatusRadioButton.Checked = true;
			}

			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new DataBaseContext();

				Models.PermanentClientStatus permanentClientStatus =
					dataBaseContext.PermanentClientStatuses
					.Where(current => string.Compare(current.Client_ID, SearchClientID) == 0)
					.FirstOrDefault();

				if (permanentClientStatus != null)//-----ثبت تسویه مالی مشتری
				{
					string paymentAmount_String = permanentClientStatus.Payment_Amount;
					int paymentAmount_Int = int.Parse(paymentAmount_String.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim());

					PaymentAmount_Int += paymentAmount_Int;
					orderDate = permanentClientStatus.Order_Date;

					permanentClientStatus.Payment_Amount = $"{PaymentAmount_Int:#,0} تومان";
					permanentClientStatus.Remaining_Amount = $"{resultRemaining:#,0} تومان";
					permanentClientStatus.Payment_Type = Payment_Type;
					permanentClientStatus.AccountStatus = AccountStatus;

					permanentClientStatus.Client_ID = SearchClientID;
					permanentClientStatus.Client_Name = clientNameTextBox.Text;
					permanentClientStatus.Order_Date = orderDate;
					permanentClientStatus.Date_Settlement = dateSettlement;

					dataBaseContext.SaveChanges();
				}

				Models.Financial financial =
								dataBaseContext.Financials
								.OrderBy(current => current.Order_Date)
								.FirstOrDefault();

				string date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				orderDate = $"00:00:00 - 0000/00/00";
				financial =
				   new Models.Financial()//-----بعد از صورت تعیین وضعیت تسویه حساب در بخش مالی ثبت میگردد!
				   {
					   Client_ID = SearchClientID,
					   Total_Price = "0",
					   Payment_Amount = $"{PaymentAmount_Int:#,0} تومان",
					   Remaining_Amount = $"{resultRemaining:#,0} تومان",
					   Payment_Type = Payment_Type,
					   Order_Date = orderDate,
					   Register_Date = date,
					   Date_Settlement = dateSettlement
				   };

				dataBaseContext.Financials.Add(financial);
				dataBaseContext.SaveChanges();

				#region EventLog
				EventLog_Username = Program.AuthenticatedUser.Username;
				EventLog_FullName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
				EventLog_EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog_EventTime = $"{Infrastructure.Utility.ShowTime()}";
				EventLog_EventTitle = $"پرداخت بدهی توسط {clientNameTextBox.Text} به مبلغ {PaymentAmount_Int:#,0} تومان. وضعیت حساب {AccountStatus} ";

				Infrastructure.Utility.EventLog
					(username: EventLog_Username,
					fullName: EventLog_FullName,
					eventDate: EventLog_EventDate,
					eventTime: EventLog_EventTime,
					eventTitle: EventLog_EventTitle);
				#endregion /EventLog

				if (resultRemaining < 0)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: $"{clientNameTextBox.Text} مبلغ {PaymentAmount_Int:#,0} تومان پرداخت و مبلغ \n {resultRemaining:#,0} تومان بدهکار میباشد.",
						caption: $"بدهکار",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					ClientFinancialAccount(SearchClientID);
					return;
				}
				else if (resultRemaining == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: $"{clientNameTextBox.Text} مبلغ {PaymentAmount_Int:#,0} تومان پرداخت و حساب تسویه گردید.",
						caption: "تسویه",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					ClientFinancialAccount(SearchClientID);
					return;
				}
				else if (resultRemaining > 0)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: $"{clientNameTextBox.Text} مبلغ {PaymentAmount_Int:#,0} تومان پرداخت و مبلغ \n {resultRemaining:#,0} تومان طلبکار میباشد.",
						caption: "طلبکار",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Alert,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					ClientFinancialAccount(SearchClientID);
					return;
				}
			}
			catch (System.Exception ex1)
			{
				Infrastructure.Utility.ExceptionShow(ex1);
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
		#endregion /PaymentAmountButton_Click 
		//-----

		#region Founction
		//-----
		#region ClientFinancialAccount
		private void ClientFinancialAccount(string clientID)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				int payment;
				dataBaseContext =
					new DataBaseContext();

				Models.PermanentClientStatus permanentClientStatus =
					dataBaseContext.PermanentClientStatuses
					.Where(current => string.Compare(current.Client_ID, clientID) == 0)
					.FirstOrDefault();
				if (permanentClientStatus == null)
				{
					return;
				}
				else
				{
					clientNameTextBox.Text = permanentClientStatus.Client_Name;

					if (string.Compare(amountTextBox.Text, "مبلغ") == 0)
					{
						amountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
						amountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
						payment = int.Parse(permanentClientStatus.Remaining_Amount.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim());
						amountTextBox.Text = $"{payment:#,0} تومان";
					}
					else
					{
						payment = int.Parse(permanentClientStatus.Remaining_Amount);
						payment = 0;
						amountTextBox.Text = $"تومان {payment}";
					}

					switch (permanentClientStatus.AccountStatus)
					{
						case "بدهکار":
							debtorStatusRadioButton.Checked = true;
							settlementStatusRadioButton.Checked = false;
							creditorStatusRadioButton.Checked = false;
							paymentAmountTextBox.Enabled = true;
							paymentAmountButton.Enabled = true;
							break;
						case "تسویه":
							debtorStatusRadioButton.Checked = false;
							settlementStatusRadioButton.Checked = true;
							creditorStatusRadioButton.Checked = false;
							paymentAmountTextBox.Enabled = false;
							paymentAmountButton.Enabled = false;
							break;
						case "طلبکار":
							debtorStatusRadioButton.Checked = false;
							settlementStatusRadioButton.Checked = false;
							creditorStatusRadioButton.Checked = true;
							paymentAmountTextBox.Enabled = false;
							paymentAmountButton.Enabled = false;
							break;
						default:
							break;
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






		#endregion /ClientFinancialAccount
		//-----
		#endregion /Founction

		private void ClientAccountStatusForm_Load(object sender, System.EventArgs e)
		{

		}
	}
}
