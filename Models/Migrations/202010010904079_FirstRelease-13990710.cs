namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstRelease13990710 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Telephone" });
            AddColumn("dbo.Financials", "Date_Settlement", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.PermanentClientStatus", "Date_Settlement", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 35));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "User_Image", c => c.Binary());
            AlterColumn("dbo.Users", "Telephone", c => c.String(maxLength: 11));
            CreateIndex("dbo.Users", "Username", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
            CreateIndex("dbo.Users", "Telephone", unique: true);
            DropTable("dbo.YearLyFinancials");
        }
        
        public override void Down()
        {
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
            
            DropIndex("dbo.Users", new[] { "Telephone" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            AlterColumn("dbo.Users", "Telephone", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Users", "User_Image", c => c.Binary(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 35));
            DropColumn("dbo.PermanentClientStatus", "Date_Settlement");
            DropColumn("dbo.Financials", "Date_Settlement");
            CreateIndex("dbo.Users", "Telephone", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
            CreateIndex("dbo.Users", "Username", unique: true);
        }
    }
}
