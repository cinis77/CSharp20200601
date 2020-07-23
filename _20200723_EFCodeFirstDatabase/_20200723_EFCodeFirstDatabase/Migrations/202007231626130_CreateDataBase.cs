namespace _20200723_EFCodeFirstDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Klientas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vardas = c.String(),
                        Pavarde = c.String(),
                        GimimoMetai = c.DateTime(nullable: false),
                        Ugis = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Klientas");
        }
    }
}
