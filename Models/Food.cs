namespace Models
{
	public class Food : BaseEntity
	{
		public Food() : base()
		{

		}

		#region FoodName
		//-----DisplayName of Name
		[System.ComponentModel.DisplayName(displayName: "نام غذا")]
		//-----AllowEmptyStrings of Name
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength of Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		//-----IsUnique of Name
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string FoodName { get; set; }
		#endregion /FoodName

		#region FoodPrice
		//-----DisplayName of Price
		[System.ComponentModel.DisplayName(displayName: "مبلغ غذا")]
		//-----AllowEmptyStrings of Price
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength of Price
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]
		public string FoodPrice { get; set; }
		#endregion /FoodPrice

		#region FoodDescription
		//-----DisplayName of Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//-----StringLength of Description
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 1000)]
		public string FoodDescription { get; set; }
		#endregion /FoodDescription

		#region FoodImage
		//-----DisplayName of Drink Image
		public byte[] FoodImage { get; set; }
		#endregion /FoodImage
		
		#region UpdateTime
		[System.ComponentModel.DisplayName(displayName: "اخرین به روز رسانی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string UpdateTime { get; set; }
		#endregion /UpdateTime
		
		#region NumberUpdate
		[System.ComponentModel.DisplayName(displayName: "تعداد به روز رسانی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		public int NumberUpdate { get; set; }
		#endregion /NumberUpdate
		
		#region RegisterTime

		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string RegisterTime { get; set; }
		#endregion /RegisterTime
	}
}
