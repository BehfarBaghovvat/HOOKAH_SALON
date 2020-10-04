using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class EventLog : BaseEntity
	{
		public EventLog() : base()
		{

		}

		#region Username
		//-----Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]
		public string Username { get; set; }
		#endregion /Username

		#region Full_Name
		//-----StringLength of FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Full_Name { get; set; }
		#endregion /Full_Name

		#region Event_Title
		//-----Not allowed to be empty Event
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght Event
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]
		public string Event_Title { get; set; }
		#endregion /Event_Title

		#region Event_Date
		//-----Not allowed to be empty EventDate
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght EventDate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Event_Date { get; set; }
		#endregion /Event_Date

		#region Event_Time
		//-----Not allowed to be empty EventTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght EventTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Event_Time { get; set; }
		#endregion /Event_Time


	}
}
