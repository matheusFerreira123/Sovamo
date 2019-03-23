namespace Sovamo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class run : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CadEstabelecimento", "horario", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CadEstabelecimento", "horario");
        }
    }
}
