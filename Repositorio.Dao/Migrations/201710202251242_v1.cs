namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 50),
                        Codigo = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.Ukey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pais");
        }
    }
}
