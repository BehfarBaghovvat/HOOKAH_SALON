using LiveCharts;
using LiveCharts.Wpf;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HOOKAH_SALON.Report
{
	public partial class FinancialStatusForm : Infrastructure.BaseForm
	{
		#region Properties
		public string Day { get; private set; }
		public string Day_string { get; private set; }
		public int Day_Int { get; private set; }
		public int Month_Int { get; private set; }
		public string Month_String { get; private set; }
		public string Year_String { get; private set; }
		public int Year_Int { get; private set; }
		#endregion /Properties

		public FinancialStatusForm()
		{
			InitializeComponent();
		}

		#region FinancialStatusForm_Load
		private void FinancialStatusForm_Load(object sender, EventArgs e)
		{
		}
		#endregion /FinancialStatusForm_Load

		#region FinancialChartButton_Click
		private void FinancialChartButton_Click(object sender, System.EventArgs e)
		{
			financialChartPanel.Visible = true;
			financialListPanel.Visible = false;
		}
		#endregion /FinancialChartButton_Click

		#region FinancialListButton_Click
		private void FinancialListButton_Click(object sender, System.EventArgs e)
		{
			financialChartPanel.Visible = false;
			financialListPanel.Visible = true;

			FinancialList();
			DailyFinancialList();
			MonthlyFinancialList();
		}
		#endregion /FinancialListButton_Click

		#region MonthlyChart
		//-----
		#region ViewMonthlyChartRadioButton_CheckedChanged
		private void ViewMonthlyChartRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (viewMonthlyChartRadioButton.Checked == true)
			{
				return;
			}
			else
			{
				Month_Int = 0;
				monthForMonthlyChartComboBox.Text = "ماه";

				Year_String = null;
				Year_Int = 0;
				yearForMonthlyChartTextBox.Text = "سال";

				viewDailyReportGroupBox.Visible = true;
				viewMonthlyChartGroupBox.Visible = false;

				viewYearlyFinancialPanel.Visible = true;
				viewMonthlyFinancialPanel.Visible = false;

				ViewDailyChart();
			}
		}
		#endregion /ViewMonthlyChartRadioButton_CheckedChanged

		#region MonthForMonthlyChartComboBox_SelectedIndexChanged
		private void MonthForMonthlyChartComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Month_Int = monthForMonthlyChartComboBox.SelectedIndex + 1;
		}
		#endregion /MonthForMonthlyChartComboBox_SelectedIndexChanged

		#region YearForMonthlyChartTextBox
		//-----
		#region YearForMonthlyChartTextBox_Enter
		private void YearForMonthlyChartTextBox_Enter(object sender, System.EventArgs e)
		{
			if (string.Compare(yearForMonthlyChartTextBox.Text, "سال") == 0)
			{
				yearForMonthlyChartTextBox.Clear();
			}
			else
			{
				yearForMonthlyChartTextBox.Select(0, yearForMonthlyChartTextBox.Text.Length);
			}
		}
		#endregion /YearForMonthlyChartTextBox_Enter

		#region YearForMonthlyChartTextBox_KeyPress
		private void YearForMonthlyChartTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /YearForMonthlyChartTextBox_KeyPress

		#region YearForMonthlyChartTextBox_Leave
		private void YearForMonthlyChartTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(yearForMonthlyChartTextBox.Text, "سال") == 0 || string.IsNullOrWhiteSpace(yearForMonthlyChartTextBox.Text))
			{
				yearForMonthlyChartTextBox.Text = "سال";
				Year_Int = 0;
			}
		}
		#endregion /YearForMonthlyChartTextBox_Leave

		#region YearForMonthlyChartTextBox_TextChanged
		private void YearForMonthlyChartTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(yearForMonthlyChartTextBox.Text, "سال") == 0 || string.IsNullOrWhiteSpace(yearForMonthlyChartTextBox.Text))
			{
				return;
			}
			else
			{
				Year_Int = int.Parse(yearForMonthlyChartTextBox.Text);
			}
		}
		#endregion /YearForMonthlyChartTextBox_TextChanged
		//-----
		#endregion /YearForMonthlyChartTextBox

		#region CheckMonthlyFinancialButton_Click
		private void CheckMonthlyFinancialButton_Click(object sender, System.EventArgs e)
		{

			string errorMessage = null;

			if (Month_Int == 0)
			{
				errorMessage = "لطفا ماه مورد نظر را وارد نمایید!";
				Mbb.Windows.Forms.MessageBox.Show(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				monthForMonthlyChartComboBox.Focus();
				return;
			}
			else if (Year_Int == 0)
			{
				errorMessage = "لطفا سال مورد نظر را وارد نمایید!";
				Mbb.Windows.Forms.MessageBox.Show(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				yearForDailyChartTextBox.Focus();
				return;
			}
			else
			{
				errorMessage = null;
				string checkDate = $"{Year_Int}/{Month_Int.ToString().PadLeft(2, '0')}";

				DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new DataBaseContext();

					List<DailyFinancial> dailyFinancials = null;

					dailyFinancials =
						dataBaseContext.DailyFinancials
						.Where(current => current.Register_Date.Contains(checkDate))
						.OrderBy(current => current.Month)
						.ToList();

					if (dailyFinancials.Count == 0)
					{
						Mbb.Windows.Forms.MessageBox.Show(
							text: "اطلاعاتی برای تاریخ مورد نظر یافت نگردید!",
							caption: "جستجوی ناموفق",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						checkMonthlyFinancialButton.Enabled = true;
						return;
					}
					else
					{
						dailyFinancialDataGridView.DataSource = dailyFinancials;
						checkMonthlyFinancialButton.Enabled = true;
					}
				}
				catch (Exception ex)
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

			#region ViewMonthlyFinancial
			viewMonthlyFinancialCartesianChart.Series.Clear();
			SeriesCollection series = new SeriesCollection();

			var months = (from o in dailyFinancialDataGridView.DataSource as List<DailyFinancial>
						  select new { Month = o.Month, }).Distinct();

			#region Sum Total Price Of Day
			foreach (var month in months)
			{
				List<int> values = new List<int>();

				for (int day = 1; day <= 31; day++)
				{
					int totalPrice = 0;

					var data = from o in dailyFinancialDataGridView.DataSource as List<DailyFinancial>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Total_Price_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						totalPrice = int.Parse(data.FirstOrDefault().Sum_Total_Price_Of_Day);
					}
					values.Add(totalPrice);
				}
				series.Add(new LineSeries() { Title = $"جمع کل حساب روز", Values = new ChartValues<int>(values) });
				viewMonthlyFinancialCartesianChart.Series = series;

			}
			#endregion /Sum Total Price Of Day

			#region Sum Payment Amount Of Day
			foreach (var month in months)
			{
				List<int> values = new List<int>();

				for (int day = 1; day <= 31; day++)
				{
					int paymentAmount = 0;

					var data = from o in dailyFinancialDataGridView.DataSource as List<DailyFinancial>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Payment_Amount_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						paymentAmount = int.Parse(data.FirstOrDefault().Sum_Payment_Amount_Of_Day);
					}
					values.Add(paymentAmount);

				}
				series.Add(new LineSeries() { Title = "جمع کل پرداختی روز", Values = new ChartValues<int>(values) });
				viewMonthlyFinancialCartesianChart.Series = series;
			}
			#endregion /Sum Payment Amount Of Day

			#region Sum Remaining Amount Of Day
			foreach (var month in months)
			{
				List<int> values = new List<int>();

				for (int day = 1; day <= 31; day++)
				{
					int remainingAmount = 0;

					var data = from o in dailyFinancialDataGridView.DataSource as List<DailyFinancial>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Remaining_Amount_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						remainingAmount = int.Parse(data.FirstOrDefault().Sum_Remaining_Amount_Of_Day);
					}
					values.Add(remainingAmount);

				}
				series.Add(new LineSeries() { Title = "جمع کل بدهی روز", Values = new ChartValues<int>(values) });
				viewMonthlyFinancialCartesianChart.Series = series;
			}
			#endregion /Sum Remaining Amount Of Day
			#endregion /ViewMonthlyFinancial
		}
		#endregion /CheckMonthlyFinancialButton_Click
		//-----
		#endregion /MonthlyChart

		#region YearlyChart
		//-----
		#region ViewYearChartRadioButton_CheckedChanged
		private void ViewYearChartRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (viewYearChartRadioButton.Checked == true)
			{
				return;
			}
			else
			{
				Day = null;
				Day_string = null;
				Day_Int = 0;

				Month_Int = 0;
				Month_String = null;

				Year_String = null;
				Year_Int = 0;
				yearForDailyChartTextBox.Text = "سال";

				viewDailyReportGroupBox.Visible = false;
				viewMonthlyChartGroupBox.Visible = true;

				viewYearlyFinancialPanel.Visible = false;
				viewMonthlyFinancialPanel.Visible = true;

				ViewMonthlyChart();
			}
		}
		#endregion /ViewYearChartRadioButton_CheckedChanged

		#region YearForDailyChartTextBox
		//-----
		#region YearForDailyChartTextBox_Enter
		private void YearForDailyChartTextBox_Enter(object sender, EventArgs e)
		{
			yearForDailyChartPanel.BackColor =
				Infrastructure.Utility.WhiteColor();
			if (string.Compare(yearForDailyChartTextBox.Text, "سال") == 0)
			{
				yearForDailyChartTextBox.Clear();
			}
		}
		#endregion /YearForDailyChartTextBox_Enter

		#region YearForDailyChartTextBox_KeyPress
		private void YearForDailyChartTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /YearForDailyChartTextBox_KeyPress

		#region YearForDailyChartTextBox_Leave
		private void YearForDailyChartTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(yearForDailyChartTextBox.Text) || string.Compare(yearForDailyChartTextBox.Text, "سال") == 0)
			{
				yearForDailyChartPanel.BackColor =
					Infrastructure.Utility.GrayColor();
				yearForDailyChartTextBox.Text = "سال";
			}
			else
			{
				if (Year_Int < 1399)
				{
					Mbb.Windows.Forms.MessageBox.Show(text: "مقدار ورودی از سال 1399 کمتر می باشد! \n لطفا مجدد تلاش کنید", caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					yearForDailyChartTextBox.Focus();
				}
				else
				{
					yearForDailyChartPanel.BackColor =
					Infrastructure.Utility.GrayColor();
					return;
				}
			}
		}
		#endregion /YearForDailyChartTextBox_Leave

		#region YearForDailyChartTextBox_TextChanged
		private void YearForDailyChartTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(yearForDailyChartTextBox.Text) || string.Compare(yearForDailyChartTextBox.Text, "سال") == 0)
			{
				return;
			}
			else
			{
				Year_String = yearForDailyChartTextBox.Text;
				Year_Int = int.Parse(yearForDailyChartTextBox.Text);
			}
		}
		#endregion /YearForDailyChartTextBox_TextChanged
		//-----
		#endregion /YearForDailyChartTextBox

		#region CheckYearlyFinancialButton_Click
		private void CheckYearlyFinancialButton_Click(object sender, EventArgs e)
		{
			string errorMessage;

			if (Year_Int == 0)
			{
				errorMessage = "لطفا سال مورد نظر را وارد نمایید!";
				Mbb.Windows.Forms.MessageBox.Show(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				yearForDailyChartTextBox.Focus();
				return;
			}
			else
			{
				errorMessage = null;
				string checkDate = $"{Year_Int}";

				DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new DataBaseContext();

					List<MonthlyFinancial> monthlyFinancials = null;

					monthlyFinancials =
						dataBaseContext.MonthlyFinancials
						.Where(current => current.Register_Date.Contains(checkDate))
						.OrderBy(current => current.Month)
						.ToList();

					if (monthlyFinancials.Count == 0)
					{
						Mbb.Windows.Forms.MessageBox.Show(
							text: "اطلاعاتی برای تاریخ مورد نظر یافت نگردید!",
							caption: "جستجوی ناموفق",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						checkYearlyFinancialButton.Enabled = true;
						return;
					}
					else
					{
						monthlyFinancialDataGridView.DataSource = monthlyFinancials;
						checkYearlyFinancialButton.Enabled = true;
					}
				}
				catch (Exception ex)
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

			viewMonthlyFinancialCartesianChart.Series.Clear();
			SeriesCollection series = new SeriesCollection();

			var years = (from o in monthlyFinancialDataGridView.DataSource as List<MonthlyFinancial>
						 select new { Year = o.Year, }).Distinct();

			#region Sum Total Price Of Month
			foreach (var year in years)
			{
				List<int> values = new List<int>();

				for (int month = 1; month <= 12; month++)
				{
					int totalPrice = 0;

					var data = from o in monthlyFinancialDataGridView.DataSource as List<MonthlyFinancial>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Total_Price_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						totalPrice = int.Parse(data.FirstOrDefault().Sum_Total_Price_Of_Month);
					}
					values.Add(totalPrice);
				}
				series.Add(new LineSeries() { Title = $"جمع کل حساب ماه", Values = new ChartValues<int>(values) });
				viewYearlyFinancialCartesianChart.Series = series;
			}
			#endregion /Sum Total Price Of Day

			#region Sum Payment Amount Of Month
			foreach (var year in years)
			{
				List<int> values = new List<int>();

				for (int month = 1; month <= 12; month++)
				{
					int paymentAmount = 0;

					var data = from o in monthlyFinancialDataGridView.DataSource as List<MonthlyFinancial>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Payment_Amount_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						paymentAmount = int.Parse(data.FirstOrDefault().Sum_Payment_Amount_Of_Month);
					}
					values.Add(paymentAmount);

				}
				series.Add(new LineSeries() { Title = "جمع کل پرداختی ماه", Values = new ChartValues<int>(values) });
				viewYearlyFinancialCartesianChart.Series = series;
			}
			#endregion /Sum Payment Amount Of Month

			#region Sum Remaining Amount Of Month
			foreach (var year in years)
			{
				List<int> values = new List<int>();

				for (int month = 1; month <= 12; month++)
				{
					int remainingAmount = 0;

					var data = from o in monthlyFinancialDataGridView.DataSource as List<MonthlyFinancial>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Remaining_Amount_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						remainingAmount = int.Parse(data.FirstOrDefault().Sum_Remaining_Amount_Of_Month);
					}
					values.Add(remainingAmount);

				}
				series.Add(new LineSeries() { Title = "جمع کل بدهی ماه", Values = new ChartValues<int>(values) });
				viewYearlyFinancialCartesianChart.Series = series;
			}
			#endregion /Sum Remaining Amount Of Month
		}
		#endregion /CheckYearlyFinancialButton_Click 
		//-----
		#endregion /YearlyChart

		//-----End of the codes!

		#region Founction
		//-----
		#region DailyFinancialList
		public void DailyFinancialList()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new DataBaseContext();

				List<DailyFinancial> dailyFinancials =
					dataBaseContext.DailyFinancials
					.OrderBy(current => current.Register_Date)
					.ToList();

				dailyFinancialListDataGridView.DataSource = dailyFinancials;
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
		#endregion /DailyFinancialList

		#region FinancialList
		public void FinancialList()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new DataBaseContext();

				List<Financial> financials =
					dataBaseContext.Financials
					.OrderBy(current => current.Register_Date)
					.ToList();

				financialListDataGridView.DataSource = financials;
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
		#endregion /FinancialList

		#region MonthlyFinancialList
		public void MonthlyFinancialList()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new DataBaseContext();

				List<MonthlyFinancial> monthlyFinancials =
					dataBaseContext.MonthlyFinancials
					.OrderBy(current => current.Register_Date)
					.ToList();

				monthlyFinancialListDataGridView.DataSource = monthlyFinancials;

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


		#endregion /MonthlyFinancialList

		#region ViewDailyChart
		private void ViewDailyChart()
		{
			dailyFinancialBindingSource.DataSource = new List<DailyFinancial>();
			viewMonthlyFinancialCartesianChart.Series.Clear();
			viewMonthlyFinancialCartesianChart.AxisX.Clear();
			viewMonthlyFinancialCartesianChart.AxisX.Add(new Axis
			{
				Title = "روز های ماه",
				Labels = new[]
				{ "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
					"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
					"21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31",}
			});
			viewMonthlyFinancialCartesianChart.AxisY.Clear();
			viewMonthlyFinancialCartesianChart.AxisY.Add(new Axis
			{
				Title = "درآمد",
				LabelFormatter = value => value.ToString()
			});

			viewMonthlyFinancialCartesianChart.LegendLocation = LegendLocation.Right;
		}
		#endregion /ViewDailyChart

		#region ViewMonthlyChart
		private void ViewMonthlyChart()
		{
			viewYearlyFinancialCartesianChart.Series.Clear();
			viewYearlyFinancialCartesianChart.AxisX.Clear();
			viewYearlyFinancialCartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
			{
				Title = "Month Days",
				Labels = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", }
			});

			viewYearlyFinancialCartesianChart.AxisY.Clear();
			viewYearlyFinancialCartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
			{
				Title = "Amount",
				LabelFormatter = value => value.ToString("C"),
			});
			viewYearlyFinancialCartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;
		}
		#endregion /ViewMonthlyChart
		//-----
		#endregion
	}
}
