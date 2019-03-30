namespace Sovamo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class run : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadCliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Cpf = c.String(unicode: false),
                        Rg = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Estado = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        Rua = c.String(unicode: false),
                        Numero = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.CadEstabelecimento",
                c => new
                    {
                        EstabelecimentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Razao = c.String(unicode: false),
                        CpfCliente = c.String(unicode: false),
                        Cnpj = c.String(unicode: false),
                        Endereço = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Descricão = c.String(unicode: false),
                        horario = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EstabelecimentoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CadEstabelecimento");
            DropTable("dbo.CadCliente");
        }
    }
}
