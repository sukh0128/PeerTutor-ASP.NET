namespace PeerTutor.Migrations
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
                   Email = c.String(maxLength: 30),
                   FirstName = c.String(maxLength: 30),
                   LastName = c.String(maxLength: 30),
                   Major = c.String(maxLength: 30),
                   Year = c.String(maxLength: 30),


               })
               .PrimaryKey(t => t.Id)
               .Index(t => t.Id, unique: true, name: "Id");
        }
        
        public override void Down()
        {

            DropTable("dbo.Tutor");
        }
    }
}
