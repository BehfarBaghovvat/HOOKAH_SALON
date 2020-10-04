namespace Models
{
	public class TemporaryClient : BaseEntity
	{
		public TemporaryClient() : base()
		{

		}

		#region FullName
		//-----Show field name LastVisit
		[System.ComponentModel.DisplayName(displayName: "نام کامل")]
		//--Allow to be empty at the time of Full_Name
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Text length at Full_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Full_Name { get; set; }
		#endregion /FullName

		#region NumberVisits
		//-----Show field name LastVisit
		[System.ComponentModel.DisplayName(displayName: "تعداد مراجعه")]
		//-----Allow to be empty at the time of LastVisit
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public int Number_Visits { get; set; }
		#endregion /NumberVisits

		#region LastVisit
		//-----Show field name LastVisit
		[System.ComponentModel.DisplayName(displayName: "اخرین مراجعه")]
		//-----Allow to be empty at the time of LastVisit
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Text length at LastVisit
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 22)]
		public string Last_Visit { get; set; }
		#endregion /LastVisit

		#region RegisterTime
		//-----Show field name RegisterTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//-----Allow to be empty at the time of RegisterTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Text length at RegisterTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string Register_Time { get; set; }
		#endregion /RegisterTime
	}
}
