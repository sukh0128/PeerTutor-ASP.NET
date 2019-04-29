namespace PeerTutor.Migrations.ContextB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEvent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        text = c.String(),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
