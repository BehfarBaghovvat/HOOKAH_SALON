using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class TemporaryClientStatus : BaseEntity
	{
		public TemporaryClientStatus() : base()
		{

		}
		
		#region ClientName
		//-----Display Name ClientName
		[System.ComponentModel.DisplayName(displayName: "نام مشترک")]
		//-----Allow Empty ClientName
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		//-----String Length ClientName
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 50)]

		public string ClientName { get; set; }
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
		public string OrderDate { get; set; }
		//-----
		#endregion /OrderData
		
		#region TotalPrice
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "جمع کل حساب")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Is Unique TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]
		//-----
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string TotalPrice { get; set; }
		//-----
		#endregion /TotalPrice
		
		#region AccountStatus
		//-----AllowEmpty Account Status
		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		//-----String Length Account Status
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 50)]

		public string AccountStatus { get; set; }
		#endregion /AccountStatus
	}
}
