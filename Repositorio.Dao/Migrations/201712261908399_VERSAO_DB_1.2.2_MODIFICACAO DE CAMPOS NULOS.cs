namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_122_MODIFICACAODECAMPOSNULOS : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblEstado", "Nome", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.tblEstado", "Sigla", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.tblPais", "Nome", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.tblPais", "Codigo", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblPais", "Codigo", c => c.String(maxLength: 4));
            AlterColumn("dbo.tblPais", "Nome", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblEstado", "Sigla", c => c.String(maxLength: 2));
            AlterColumn("dbo.tblEstado", "Nome", c => c.String(maxLength: 50));
        }
    }
}
