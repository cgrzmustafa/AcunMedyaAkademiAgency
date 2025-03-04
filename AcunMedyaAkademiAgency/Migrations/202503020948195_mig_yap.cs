namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_yap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Gender", c => c.String());
            AddColumn("dbo.Teams", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "City");
            DropColumn("dbo.Teams", "Gender");
        }
    }
}
