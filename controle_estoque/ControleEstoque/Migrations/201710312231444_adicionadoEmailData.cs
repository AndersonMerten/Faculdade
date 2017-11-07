namespace ControleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionadoEmailData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Clientes", "Nascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Nascimento");
            DropColumn("dbo.Clientes", "Email");
        }
    }
}
