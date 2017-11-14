namespace Wubbalubbadubzork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedOlveraStats : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "Mana_Cost", c => c.Int(nullable: false));
            DropColumn("dbo.Characters", "Damage");
            DropColumn("dbo.Characters", "Power");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "Power", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Damage", c => c.Int(nullable: false));
            DropColumn("dbo.Skills", "Mana_Cost");
        }
    }
}
