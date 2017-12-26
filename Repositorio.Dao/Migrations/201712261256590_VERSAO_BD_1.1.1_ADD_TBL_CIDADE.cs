namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_BD_111_ADD_TBL_CIDADE : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pais", newName: "tblPais");
            RenameTable(name: "dbo.Estado", newName: "tblEstado");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblEstado", newName: "Estado");
            RenameTable(name: "dbo.tblPais", newName: "Pais");
        }
    }
}
