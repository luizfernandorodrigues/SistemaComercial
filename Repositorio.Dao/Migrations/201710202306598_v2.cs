namespace Repositorio.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 50),
                        Sigla = c.String(maxLength: 2),
                        IdPais = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.Pais", t => t.IdPais, cascadeDelete: true)
                .Index(t => t.IdPais);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estadoes", "IdPais", "dbo.Pais");
            DropIndex("dbo.Estadoes", new[] { "IdPais" });
            DropTable("dbo.Estadoes");
        }
    }
}
