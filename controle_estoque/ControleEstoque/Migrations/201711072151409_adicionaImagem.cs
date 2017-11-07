namespace ControleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionaImagem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Imagem", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Imagem");
        }
    }
}
