namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_131_ADD_TABLE_EMPRESA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmpresa",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        IdCep = c.Guid(nullable: false),
                        CodigoEmpresa = c.String(nullable: false, maxLength: 20),
                        FantasiaEmpresa = c.String(nullable: false, maxLength: 50),
                        RazaoEmpresa = c.String(nullable: false, maxLength: 80),
                        Endereco = c.String(nullable: false, maxLength: 80),
                        NumeroEndereco = c.String(maxLength: 20),
                        ComplementoEnd = c.String(maxLength: 30),
                        BairroEndereco = c.String(nullable: false, maxLength: 50),
                        Cnpj = c.String(nullable: false, maxLength: 14),
                        Inscricao = c.String(maxLength: 14),
                        Telefone = c.String(maxLength: 11),
                        Celular = c.String(maxLength: 11),
                        Fax = c.String(maxLength: 11),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.tblCep", t => t.IdCep, cascadeDelete: true)
                .Index(t => t.IdCep);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblEmpresa", "IdCep", "dbo.tblCep");
            DropIndex("dbo.tblEmpresa", new[] { "IdCep" });
            DropTable("dbo.tblEmpresa");
        }
    }
}
