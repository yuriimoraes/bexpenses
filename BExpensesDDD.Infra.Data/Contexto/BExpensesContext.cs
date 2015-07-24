using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using BExpensesDDD.Infra.Data.EntityConfig;
using System.Linq;
using System;

namespace BExpensesDDD.Infra.Data.Contexto
{
    public class BExpensesContext: DbContext 
    {
        public BExpensesContext()
            : base("BExpensesDDD")
        {
        
        }
        public DbSet<Moeda> Moedas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<TipoAcomodacao> TiposAcomodacoes { get; set; }
        public DbSet<TipoDespesaCarro> TiposDespesasCarro { get; set; }
        public DbSet<TipoViagem> TiposViagens { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<CentroCusto> CentroCustos { get; set; }
        public DbSet<RespostaSolicitacaoReembolso> RespostasSolicitacoes { get; set; }
        public DbSet<SolicitacaoViagem> SolicitacoesViagens { get; set; }
        public DbSet<DespesaPrincipal> DespesasPrincipai { get; set; }
        public DbSet<TaxaCambio> TaxasCambio { get; set; }
        public DbSet<SolicitacaoReembolso> SolicitacoesReembolsos { get; set; }
        public DbSet<ClasseViagem> ClasseViagens { get; set; }
        public DbSet<DespesaAcomodacao> DespesasAcomodacoes { get; set; }
        public DbSet<DespesaCarro> DespesasCarros { get; set; }
        public DbSet<DespesaCarroAluguel> DespesasCarrosAlugueis { get; set; }
        public DbSet<DespesaOutro> DespesasOutros { get; set; }
        public DbSet<DespesaPerDiem> DespesasPorDias { get; set; }
        public DbSet<DespesaTransporte> DespesasTransportes { get; set; }
        public DbSet<DespesaViagem> DespesasViagens { get; set; }
        public DbSet<ParametrosSistema> ParametrosSistemas  { get; set; }
        
       
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(255));

            modelBuilder.Configurations.Add(new CentroCustoConfiguration());
            modelBuilder.Configurations.Add(new ClasseViagemConfiguration());
            modelBuilder.Configurations.Add(new DespesaAcomodacaoConfiguration());
            modelBuilder.Configurations.Add(new DespesaCarroAluguelConfiguration());
            modelBuilder.Configurations.Add(new DespesaCarroConfiguration());
            modelBuilder.Configurations.Add(new DespesaOutroConfiguration());
            modelBuilder.Configurations.Add(new DespesaPerDiemConfiguration());
            modelBuilder.Configurations.Add(new DespesaPrincipalConfiguration());
            modelBuilder.Configurations.Add(new DespesaTransporteConfiguration());
            modelBuilder.Configurations.Add(new DespesaViagemConfiguration());
            modelBuilder.Configurations.Add(new MoedaConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new ParametrosSistemaConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new RespostaSolicitacaoReembolsoConfiguration());
            modelBuilder.Configurations.Add(new RespostaSolicitacaoViagemConfiguration());
            modelBuilder.Configurations.Add(new SolicitacaoReembolsoConfiguration());
            modelBuilder.Configurations.Add(new SolicitacaoViagemConfiguration());
            modelBuilder.Configurations.Add(new TaxaCambioConfiguration());
            modelBuilder.Configurations.Add(new TipoAcomodacaoConfiguration());
            modelBuilder.Configurations.Add(new TipoDespesaCarroConfiguration());
            modelBuilder.Configurations.Add(new TipoViagemConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataAtualizacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAtualizacao").IsModified = true;
                }

                entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
            }
            
            return base.SaveChanges();
        }

    }
}
