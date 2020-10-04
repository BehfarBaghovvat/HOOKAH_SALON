using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
	public partial class PermanentClientStatus : BaseEntity
	{
		public PermanentClientStatus() 
		{
			
		}

		#region ClientID
		//-----Display Name ClientlID
		[System.ComponentModel.DisplayName(displayName: "کد مشتری")]
		//-----Allow Empty ClientlID
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Is Unique ClientlID
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		//-----String Length ClientlID
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 11)]
		public string Client_ID { get; set; }
		//-----
		#endregion /ClientID

		#region ClientName
		//-----Display Name ClientName
		[System.ComponentModel.DisplayName(displayName: "نام مشترک")]
		//-----Allow Empty ClientName
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		//-----String Length ClientName
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 50)]

		public string Client_Name { get; set; }
		//-----
		#endregion /ClientName
		
		#region OrderData
		//-----Display Name OrderDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ سفارش")]
		//-----Allow Empty OrderDate
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//----- String Length OrderDate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Order_Date { get; set; }
		//-----
		#endregion /OrderData
		
		#region TotalPrice
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "جمع کل حساب")]
		//-----Allow Empty TotalPrice
		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Total_Price { get; set; }
		#endregion /TotalPrice

		#region PaymentAmount
		//----- Display Name Payment
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی")]
		//-----Allow Empty Payment
		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false)]
		//-----StringLength Payment
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Payment_Amount { get; set; }
		//-----
		#endregion /PaymentAmount

		#region Remaining_Amount
		//----- Display Name Remaining Amount
		[System.ComponentModel.DisplayName(displayName: "مبلغ بدهی")]
		//-----Allow Empty Remaining Amount
		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false)]
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

		#region AccountStatus
		//-----AllowEmpty Account Status
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		//-----String Length Account Status
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 50)]

		public string AccountStatus { get; set; }
		#endregion /AccountStatus

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
