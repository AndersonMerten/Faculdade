namespace Dojo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarDadosTabelaDefault : DbMigration
    {
        public override void Up()
        {


            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Branca', '6k')");
            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Amarela', '5k')");
            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Roxa', '4k')");
            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Verde', '3k')");
            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Azul', '2k')");
            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Marrom', '1k')");
            Sql("INSERT INTO Faixas (Nome, Grau) VALUES('Preta', '1d')");

            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Mensal', '1', '140')");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Trimestral', '3', '400')");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Semestral', '6', '600')");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Anual', '12', '1400')");

            Sql("INSERT INTO Alunoes (Nome, CPF, Faixa_id, TipoDeAssociacao_id) VALUES ('Martim Castro Ribeiro', '158.778.735-04', '22', '7')");
            Sql("INSERT INTO Alunoes (Nome, CPF, Faixa_id, TipoDeAssociacao_id) VALUES ('Lucas Alves Melo', '916.749.332-74', '23', '8')");
            Sql("INSERT INTO Alunoes (Nome, CPF, Faixa_id, TipoDeAssociacao_id) VALUES ('Breno Castro Carvalho', '454.019.800-94', '24', '9')");
            Sql("INSERT INTO Alunoes (Nome, CPF, Faixa_id, TipoDeAssociacao_id) VALUES ('Laura Cardoso Rocha', '361.089.665-56', '25', '10')");


        }
        
        public override void Down()
        {
        }
    }
}
