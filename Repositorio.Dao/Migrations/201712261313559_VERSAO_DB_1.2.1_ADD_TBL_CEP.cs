namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_121_ADD_TBL_CEP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCep",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        Cepe = c.String(nullable: false, maxLength: 8),
                        IdCidade = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.tblCidade", t => t.IdCidade, cascadeDelete: true)
                .Index(t => t.IdCidade);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblCep", "IdCidade", "dbo.tblCidade");
            DropIndex("dbo.tblCep", new[] { "IdCidade" });
            DropTable("dbo.tblCep");
        }
    }
}
