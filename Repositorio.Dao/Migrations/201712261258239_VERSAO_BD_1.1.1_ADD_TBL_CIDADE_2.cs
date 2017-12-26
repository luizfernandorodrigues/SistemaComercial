namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_BD_111_ADD_TBL_CIDADE_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCidade",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        NomeCidade = c.String(nullable: false, maxLength: 100),
                        CodigoIbge = c.String(nullable: false, maxLength: 10),
                        IdEstado = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.tblEstado", t => t.IdEstado, cascadeDelete: true)
                .Index(t => t.IdEstado);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblCidade", "IdEstado", "dbo.tblEstado");
            DropIndex("dbo.tblCidade", new[] { "IdEstado" });
            DropTable("dbo.tblCidade");
        }
    }
}
