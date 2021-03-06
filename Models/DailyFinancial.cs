﻿namespace Models
{
	public class DailyFinancial : BaseEntity
	{
		public DailyFinancial(): base()
		{

		}

		#region Sum_Total_Price_Of_Day
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "جمع کل حساب")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Sum_Total_Price_Of_Day { get; set; }
		#endregion /Sum_Total_Price_Of_Day

		#region Sum_Payment_Amount_Of_Day
		//----- Display Name Payment
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ پرداختی")]
		//-----Allow Empty Payment
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Payment
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Sum_Payment_Amount_Of_Day { get; set; }
		//-----
		#endregion /Sum_Payment_Amount_Of_Day

		#region Sum_Remaining_Amount_Of_Day
		//----- Display Name Remaining Amount
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ بدهی")]
		//-----Allow Empty Remaining Amount
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Remaining Amount
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Sum_Remaining_Amount_Of_Day { get; set; }
		#endregion /Sum_Remaining_Amount_Of_Day

		#region Register_Date
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Register_Date { get; set; }
		#endregion /Register_Date

		#region Date
		public int Year { get; set; }
		public int Month { get; set; }
		public int Day { get; set; }
		#endregion /Date

		
	}
}
