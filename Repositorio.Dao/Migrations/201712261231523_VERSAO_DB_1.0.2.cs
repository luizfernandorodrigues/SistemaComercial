namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_102 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Estadoes", newName: "Estado");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Estado", newName: "Estadoes");
        }
    }
}
