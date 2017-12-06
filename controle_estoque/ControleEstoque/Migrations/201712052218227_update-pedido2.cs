namespace ControleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepedido2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        TransportadoraId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Transportadores", t => t.TransportadoraId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.TransportadoraId)
                .Index(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidos", "TransportadoraId", "dbo.Transportadores");
            DropForeignKey("dbo.Pedidos", "ProdutoId", "dbo.Produtos");
            DropForeignKey("dbo.Pedidos", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Pedidos", new[] { "ProdutoId" });
            DropIndex("dbo.Pedidos", new[] { "TransportadoraId" });
            DropIndex("dbo.Pedidos", new[] { "ClienteId" });
            DropTable("dbo.Pedidos");
        }
    }
}
