using System.Data.Entity.Migrations.Infrastructure;

namespace Models
{
	public class DataBaseContext : System.Data.Entity.DbContext
	{
		static DataBaseContext()
		{
			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>());


			//System.Data.Entity.Database.SetInitializer
			//	(new DataBaseContextInitializerBeforTheFirstRelease());


			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.MigrateDatabaseToLatestVersion<DataBaseContext, Migrations.Configuration>());
		}
		public DataBaseContext() : base()
		{

		}

		public System.Data.Entity.DbSet<ClientOrder> ClientOrders { get; set; }
		public System.Data.Entity.DbSet<DailyFinancial> DailyFinancials { get; set; }
		public System.Data.Entity.DbSet<Drink> Drinks { get; set; }
		public System.Data.Entity.DbSet<EventLog> EventLogs { get; set; }
		public System.Data.Entity.DbSet<Financial> Financials { get; set; }
		public System.Data.Entity.DbSet<Food> Foods { get; set; }
		public System.Data.Entity.DbSet<Hookah> Hookahs { get; set; }
		public System.Data.Entity.DbSet<LogHistory> LogHistories { get; set; }
		public System.Data.Entity.DbSet<MonthlyFinancial> MonthlyFinancials { get; set; }
		public System.Data.Entity.DbSet<PermanentClient> PermanentClients { get; set; }
		public System.Data.Entity.DbSet<PermanentClientStatus> PermanentClientStatuses { get; set; }
		public System.Data.Entity.DbSet<TemporaryClient> TemporaryClients { get; set; }
		public System.Data.Entity.DbSet<TemporaryClientStatus> TemporaryClientStatuses { get; set; }
		public System.Data.Entity.DbSet<User> Users { get; set; }
	}
}
