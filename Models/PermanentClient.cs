namespace Models
{
	public class PermanentClient : BaseEntity
	{
		public PermanentClient() : base()
		{

		}

		#region ClientID
		//--Text length at Client_ID
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 11)]
		//--Uniqueness of the Client_ID field
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Allow to be empty at the time of Client_ID
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public string Client_ID { get; set; }
		#endregion /ClientID

		#region FullName
		//--Allow to be empty at the time of Full_Name
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Text length at Full_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Full_Name { get; set; }
		#endregion /FullName

		#region Number_Order
		//-----Show field name NumberOrder
		[System.ComponentModel.DisplayName(displayName: "تعداد سفارش")]
		//-----Allow to be empty at the time of NumberOrder
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public int Number_Order { get; set; }
		#endregion /NumberVisits

		#region Last_Order
		//-----Show field name LastOrder
		[System.ComponentModel.DisplayName(displayName: "اخرین آخرین سفارش")]
		//-----Allow to be empty at the time of LastOrder
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Text length at LastOrder
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 22)]
		public string Last_Order { get; set; }
		#endregion /Last_Order

		#region Register_Date
		//-----Show field name RegisterDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//-----Allow to be empty at the time of RegisterDate
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Text length at RegisterDate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Register_Date { get; set; }
		#endregion /Register_Date

		#region Edit_Date
		//-----Show field name EditDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ویرایش")]
		//-----Allow to be empty at the time of EditDate
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Text length at EditDate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Edit_Date { get; set; }
		#endregion /Edit_Date
	}
}
