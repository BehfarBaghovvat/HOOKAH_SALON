namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientOrders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Full_Name = c.String(maxLength: 45),
                        OrderName = c.String(nullable: false, maxLength: 30),
                        Price = c.String(nullable: false, maxLength: 25),
                        Number = c.Int(nullable: false),
                        SumPrice = c.String(nullable: false, maxLength: 30),
                        OderDate = c.String(nullable: false, maxLength: 25),
                        Register_Time = c.String(nullable: false, maxLength: 8),
                        Register_Date = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DailyFinancials",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sum_Total_Price_Of_Day = c.String(nullable: false, maxLength: 45),
                        Sum_Payment_Amount_Of_Day = c.String(nullable: false, maxLength: 45),
                        Sum_Remaining_Amount_Of_Day = c.String(nullable: false, maxLength: 55),
                        Register_Date = c.String(nullable: false, maxLength: 10),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DrinkName = c.String(nullable: false, maxLength: 30),
                        DrinkPrice = c.String(nullable: false, maxLength: 35),
                        DrinkDescription = c.String(maxLength: 1000),
                        DrinkImage = c.Binary(),
                        UpdateTime = c.String(nullable: false, maxLength: 25),
                        NumberUpdate = c.Int(nullable: false),
                        RegisterTime = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.DrinkName, unique: true);
            
            CreateTable(
                "dbo.EventLogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 35),
                        Full_Name = c.String(maxLength: 50),
                        Event_Title = c.String(nullable: false, maxLength: 250),
                        Event_Date = c.String(nullable: false, maxLength: 10),
                        Event_Time = c.String(nullable: false, maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Financials",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Client_ID = c.String(nullable: false, maxLength: 11),
                        Total_Price = c.String(nullable: false, maxLength: 45),
                        Payment_Amount = c.String(nullable: false, maxLength: 45),
                        Remaining_Amount = c.String(nullable: false, maxLength: 55),
                        Order_Date = c.String(nullable: false, maxLength: 25),
                        Register_Date = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FoodName = c.String(nullable: false, maxLength: 30),
                        FoodPrice = c.String(nullable: false, maxLength: 35),
                        FoodDescription = c.String(maxLength: 1000),
                        FoodImage = c.Binary(),
                        UpdateTime = c.String(nullable: false, maxLength: 25),
                        NumberUpdate = c.Int(nullable: false),
                        RegisterTime = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.FoodName, unique: true);
            
            CreateTable(
                "dbo.Hookahs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HookahName = c.String(nullable: false, maxLength: 30),
                        HookahPrice = c.String(nullable: false, maxLength: 35),
                        HookahDescription = c.String(maxLength: 1000),
                        HookahImage = c.Binary(),
                        UpdateTime = c.String(nullable: false, maxLength: 25),
                        NumberUpdate = c.Int(nullable: false),
                        RegisterTime = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.HookahName, unique: true);
            
            CreateTable(
                "dbo.LogHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Full_Name = c.String(nullable: false, maxLength: 55),
                        Username = c.String(nullable: false, maxLength: 25),
                        Login_Time = c.String(nullable: false, maxLength: 25),
                        Logout_Time = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Full_Name)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.MonthlyFinancials",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sum_Total_Price_Of_Month = c.String(nullable: false, maxLength: 45),
                        Sum_Payment_Amount_Of_Month = c.String(nullable: false, maxLength: 45),
                        Sum_Remaining_Amount_Of_Month = c.String(nullable: false, maxLength: 55),
                        Register_Date = c.String(nullable: false, maxLength: 10),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PermanentClients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Client_ID = c.String(nullable: false, maxLength: 11),
                        Full_Name = c.String(nullable: false, maxLength: 45),
                        Number_Order = c.Int(nullable: false),
                        Last_Order = c.String(nullable: false, maxLength: 22),
                        Register_Date = c.String(nullable: false, maxLength: 25),
                        Edit_Date = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Client_ID, unique: true);
            
            CreateTable(
                "dbo.PermanentClientStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Client_ID = c.String(nullable: false, maxLength: 11),
                        Client_Name = c.String(nullable: false, maxLength: 50),
                        Order_Date = c.String(nullable: false, maxLength: 25),
                        Total_Price = c.String(maxLength: 45),
                        Payment_Amount = c.String(maxLength: 45),
                        Remaining_Amount = c.String(maxLength: 55),
                        AccountStatus = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Client_ID);
            
            CreateTable(
                "dbo.TemporaryClients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Full_Name = c.String(nullable: false, maxLength: 45),
                        Number_Visits = c.Int(nullable: false),
                        Last_Visit = c.String(nullable: false, maxLength: 22),
                        Register_Time = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemporaryClientStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ClientName = c.String(nullable: false, maxLength: 50),
                        OrderDate = c.String(nullable: false, maxLength: 25),
                        TotalPrice = c.String(nullable: false, maxLength: 35),
                        AccountStatus = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.TotalPrice, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Access_Level = c.String(nullable: false, maxLength: 11),
                        Username = c.String(nullable: false, maxLength: 35),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        User_Image = c.Binary(nullable: false),
                        Description = c.String(maxLength: 3200),
                        First_Name = c.String(maxLength: 20),
                        Last_Name = c.String(maxLength: 25),
                        Telephone = c.String(nullable: false, maxLength: 11),
                        National_Code = c.String(maxLength: 12),
                        Marital_Status = c.String(maxLength: 5),
                        Address = c.String(maxLength: 500),
                        Registration_Time = c.String(nullable: false, maxLength: 8),
                        Registration_Date = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.Telephone, unique: true);
            
            CreateTable(
                "dbo.YearLyFinancials",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sum_Total_Price_Of_Year = c.String(nullable: false, maxLength: 45),
                        Sum_Payment_Amount_Of_Year = c.String(nullable: false, maxLength: 45),
                        Sum_Remaining_Amount_Of_Year = c.String(nullable: false, maxLength: 55),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Telephone" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.TemporaryClientStatus", new[] { "TotalPrice" });
            DropIndex("dbo.PermanentClientStatus", new[] { "Client_ID" });
            DropIndex("dbo.PermanentClients", new[] { "Client_ID" });
            DropIndex("dbo.LogHistories", new[] { "Username" });
            DropIndex("dbo.LogHistories", new[] { "Full_Name" });
            DropIndex("dbo.Hookahs", new[] { "HookahName" });
            DropIndex("dbo.Foods", new[] { "FoodName" });
            DropIndex("dbo.Drinks", new[] { "DrinkName" });
            DropTable("dbo.YearLyFinancials");
            DropTable("dbo.Users");
            DropTable("dbo.TemporaryClientStatus");
            DropTable("dbo.TemporaryClients");
            DropTable("dbo.PermanentClientStatus");
            DropTable("dbo.PermanentClients");
            DropTable("dbo.MonthlyFinancials");
            DropTable("dbo.LogHistories");
            DropTable("dbo.Hookahs");
            DropTable("dbo.Foods");
            DropTable("dbo.Financials");
            DropTable("dbo.EventLogs");
            DropTable("dbo.Drinks");
            DropTable("dbo.DailyFinancials");
            DropTable("dbo.ClientOrders");
        }
    }
}
