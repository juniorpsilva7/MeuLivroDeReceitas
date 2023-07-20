using FluentMigrator;

namespace MeuLivroDeReceitas.Infrastructure.Migrations.Versoes;

//Versao 1 e comentario pro FluentMigrator
[Migration((long)NumeroVersoes.CriarTabelaUsuario, "Criar tabela usuario")]
public class Versao0000001 : Migration
{
    public override void Down()
    {
    }

    public override void Up()
    {
        var tabela = VersaoBase.InserirColunasPadrao(Create.Table("Usuario"));

        tabela
            .WithColumn("Nome").AsString(100).NotNullable()
            .WithColumn("Email").AsString().NotNullable()
            .WithColumn("Senha").AsString(2000).NotNullable()
            .WithColumn("Telefone").AsString(14).NotNullable();
    }
}
