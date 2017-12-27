namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_133_ADD_TABLE_USUARIO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUsuario",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        Login = c.String(nullable: false, maxLength: 50),
                        Senha = c.String(nullable: false, maxLength: 50),
                        NomeUsuario = c.String(nullable: false, maxLength: 50),
                        EmailUsuario = c.String(maxLength: 80),
                        Adm = c.Decimal(nullable: false, precision: 1, scale: 0),
                        IdGrupo = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.tblGrupoUsuario", t => t.IdGrupo, cascadeDelete: true)
                .Index(t => t.IdGrupo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUsuario", "IdGrupo", "dbo.tblGrupoUsuario");
            DropIndex("dbo.tblUsuario", new[] { "IdGrupo" });
            DropTable("dbo.tblUsuario");
        }
    }
}
