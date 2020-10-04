using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Financial : BaseEntity
	{
		public Financial() : base()
		{

		}

		#region Client_ID
		//----- Display Name ClientID
		[System.ComponentModel.DisplayName(displayName: "کد شناسه")]
		//-----Allow Empty ClientID
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength ClientID
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 11)]
		public string Client_ID { get; set; }
		#endregion /Client_ID

		#region Total_Price
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "جمع کل حساب")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Total_Price { get; set; }
		#endregion /Total_Price

		#region Payment_Amount
		//----- Display Name Payment
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی")]
		//-----Allow Empty Payment
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Payment
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Payment_Amount { get; set; }
		//-----
		#endregion /Payment_Amount

		#region Remaining_Amount
		//----- Display Name Remaining Amount
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی")]
		//-----Allow Empty Remaining Amount
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Remaining Amount
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Remaining_Amount { get; set; }
		#endregion /Remaining_Amount

		#region Payment_Type
		//----- Display Name Payment Type
		[System.ComponentModel.DisplayName(displayName: "نوع پرداخت")]
		//-----Allow Empty Payment Type
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Payment Type
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 15)]
		public string Payment_Type { get; set; }
		#endregion /Payment_Type

		#region Order_Date
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "تاریخ سفارش")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Order_Date { get; set; }
		#endregion /Order_Date

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

		#region Date_Settlement
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "تاریخ تسویه حساب")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Date_Settlement { get; set; }
		#endregion /Date_Settlement


	}
}
