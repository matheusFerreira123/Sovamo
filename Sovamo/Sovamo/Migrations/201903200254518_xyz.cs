namespace Sovamo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xyz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadCliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Email = c.String(unicode: false),
                        Cnpj = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CadCliente");
        }
    }
}
