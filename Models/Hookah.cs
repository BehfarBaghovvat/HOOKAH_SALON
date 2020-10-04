using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Hookah : BaseEntity
	{
		public Hookah() : base()
		{

		}

		#region HookahName
		[System.ComponentModel.DisplayName(displayName: "نام قلیان")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string HookahName { get; set; }
		#endregion /HookahName
		
		#region HookahPrice
		[System.ComponentModel.DisplayName(displayName: "مبلغ قلیان")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]
		public string HookahPrice { get; set; }
		#endregion /HookahPrice
		
		#region HookahDescription
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string HookahDescription { get; set; }
		#endregion /HookahDescription
		
		#region HookahImage
		[System.ComponentModel.DisplayName(displayName: "تصویر قلیان")]
		public byte[] HookahImage { get; set; }
		#endregion /HookahImage
		
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
