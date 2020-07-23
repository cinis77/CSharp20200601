namespace _20200723_EFCodeFirstDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PridetasAdresas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gatve = c.String(),
                        NamoNr = c.Int(nullable: false),
                        Miestas = c.String(),
                        Valstybe = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Klientas", "Adresas_Id", c => c.Int());
            CreateIndex("dbo.Klientas", "Adresas_Id");
            AddForeignKey("dbo.Klientas", "Adresas_Id", "dbo.Adresas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Klientas", "Adresas_Id", "dbo.Adresas");
            DropIndex("dbo.Klientas", new[] { "Adresas_Id" });
            DropColumn("dbo.Klientas", "Adresas_Id");
            DropTable("dbo.Adresas");
        }
    }
}
