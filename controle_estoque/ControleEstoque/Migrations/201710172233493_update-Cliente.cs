namespace ControleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Fone", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Clientes", "Cpf", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Cpf", c => c.String());
            AlterColumn("dbo.Clientes", "Fone", c => c.String());
        }
    }
}
