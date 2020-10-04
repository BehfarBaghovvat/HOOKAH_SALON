using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	class DataBaseContextInitializerBeforTheFirstRelease :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>
	{
		public DataBaseContextInitializerBeforTheFirstRelease()
		{

		}

		protected override void Seed (DataBaseContext dataBaseContext)
		{
			base.Seed(dataBaseContext);

			try
			{
				DataBaseContextInitializer.Seed(dataBaseContext);
			}
			catch
			{

			}
		}
	}
}
