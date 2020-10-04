using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
	public partial class ClientOrder :BaseEntity
	{
		public ClientOrder()
		{

		}

		#region Full_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Full_Name { get; set; }
		#endregion /Full_Name

		#region OrderName
		//-----
		[System.ComponentModel.DisplayName(displayName: "نام سفارش")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string OrderName { get; set; }
		//-----
		#endregion /OrderName
		
		#region Price
		//-----
		[System.ComponentModel.DisplayName(displayName: "مبلغ")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Price { get; set; }
		//-----
		#endregion /Price
		
		#region Number
		//-----
		[System.ComponentModel.DisplayName(displayName: "تعداد")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		public int Number { get; set; }
		//-----
		#endregion /Number
		
		#region SumPrice
		//-----
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string SumPrice { get; set; }
		//-----
		#endregion /SumPrice

		#region OderDate
		//----- Display Name  Oder Date
		[System.ComponentModel.DisplayName(displayName: "تاریخ سفارش")]
		//-----Allow Empty Oder Date
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Oder Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string OderDate { get; set; }
		#endregion /OderDate

		#region Register_Time
		//----- Display Name Register Time
		[System.ComponentModel.DisplayName(displayName: "ساعت ثبت")]
		//-----Allow Empty Register Time
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Register Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Register_Time { get; set; }
		#endregion /Register_Time

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
	}
}
