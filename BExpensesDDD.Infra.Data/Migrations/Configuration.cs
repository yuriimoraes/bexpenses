using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Infra.Data.Repositories;

namespace BExpensesDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.BExpensesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.BExpensesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Pessoas.AddOrUpdate(
                p => p.Nome,
                new Pessoa { Nome = "Thiago", Aprovador = true, Email = "thiago.paiva@bimprove.com", Administrador = true, CentroCustoID = 4, Login = "thiago", Senha = "bimprove", CodigoFornecedorSAP = "12345", NumeroConta = "123456", AgenciaConta = "1234", Aprovador1ID = 0, Aprovador2ID = 0, DataAtualizacao = new DateTime(), NomeBanco = "Itau", Telefone1 = "12988293348", Telefone2 = "12983445566" },
                new Pessoa { Nome = "Fábio", Aprovador = true, Email = "fabio@bimprove.com", Administrador = false, CentroCustoID = 4, Login = "fabio", Senha = "bimprove", CodigoFornecedorSAP = "67890", NumeroConta = "123456", AgenciaConta = "1236", Aprovador1ID = 0, Aprovador2ID = 0, DataAtualizacao = new DateTime(), NomeBanco = "Bradesco", Telefone1 = "12988293346", Telefone2 = "12983445523" },
                new Pessoa { Nome = "Marcelo", Aprovador = false, Email = "marcelo@bimprove.com", Administrador = false, CentroCustoID = 4, Login = "marcelo", Senha = "bimprove", CodigoFornecedorSAP = "54321", NumeroConta = "123456", AgenciaConta = "1235", Aprovador1ID = 0, Aprovador2ID = 0, DataAtualizacao = new DateTime(), NomeBanco = "Santander", Telefone1 = "12988293390", Telefone2 = "12983445512" }
               
               );

        }
    }
}
