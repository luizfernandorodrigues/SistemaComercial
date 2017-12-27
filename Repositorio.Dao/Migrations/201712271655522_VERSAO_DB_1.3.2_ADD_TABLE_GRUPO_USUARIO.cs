namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_132_ADD_TABLE_GRUPO_USUARIO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGrupoUsuario",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        CodigoGrupo = c.String(nullable: false, maxLength: 10),
                        NomeGrupo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Ukey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblGrupoUsuario");
        }
    }
}
