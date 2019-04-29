namespace PeerTutor.Migrations.ContextB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tutors : DbMigration
    {
        public override void Up()
        {
          
            
            CreateTable(
                "dbo.Tutor",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 30),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Major = c.String(nullable: false, maxLength: 30),
                        Year = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tutor");
            DropTable("dbo.Course");
        }
    }
}
