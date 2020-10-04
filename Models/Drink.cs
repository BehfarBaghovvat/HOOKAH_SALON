namespace Models
{
	public class Drink : BaseEntity
	{
		public Drink() : base()
		{

		}

		#region DrinkName
		//-----DisplayName of Name
		[System.ComponentModel.DisplayName(displayName: "نام نوشیدنی")]
		//-----AllowEmptyStrings of Name
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength of Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		//-----IsUnique of Name
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string DrinkName { get; set; }
		#endregion /DessertName

		#region DrinkPrice
		//-----DisplayName of Price
		[System.ComponentModel.DisplayName(displayName: " مبلغ نوشیدنی")]
		//-----AllowEmptyStrings of Price
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength of Price
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]
		public string DrinkPrice { get; set; }
		#endregion /DrinkPrice

		#region DrinkDescription
		//-----DisplayName of Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//-----StringLength of Description
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 1000)]
		public string DrinkDescription { get; set; }
		#endregion /DrinkDescription

		#region DrinkImage
		//-----DisplayName of Drink Image
		[System.ComponentModel.DisplayName(displayName: "تصویر نوشیدنی")]
		public byte[] DrinkImage { get; set; }
		#endregion /DrinkImage
		
		#region UpdateTime

		[System.ComponentModel.DisplayName(displayName: "اخرین به روز رسانی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string UpdateTime { get; set; }
		#endregion /UpdateTime
		
		#region NumberUpdate
		//-----DisplayName of Number Update.
		[System.ComponentModel.DisplayName(displayName: "تعداد به روز رسانی")]
		//-----AllowEmptyStrings of Number Update.
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]
		public int NumberUpdate { get; set; }
		#endregion /NumberUpdate
		
		#region RegisterTime
		//-----DisplayName of Regiter Time
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//-----AllowEmptyStrings of Regiter Time
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength of Regiter Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string RegisterTime { get; set; }
		#endregion /RegisterTime
	}
}
