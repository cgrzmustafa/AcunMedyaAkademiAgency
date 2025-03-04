namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectDetails", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectDetails", "Title");
        }
    }
}
