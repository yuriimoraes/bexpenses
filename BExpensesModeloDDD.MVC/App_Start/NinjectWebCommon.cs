using BExpensesDDD.Application;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Application.Service;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;
using BExpensesDDD.Domain.Services;
using BExpensesDDD.Infra.Data.Repositories;
using Ninject.Web.Mvc.FilterBindingSyntax;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BExpensesModeloDDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BExpensesModeloDDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace BExpensesModeloDDD.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ICentroCustoAppService>().To<CentroCustoAppService>();
            kernel.Bind<IClasseViagemAppService>().To<ClasseViagemAppService>();
            kernel.Bind<IDespesaAcomodacaoAppService>().To<DespesaAcomodacaoAppService>();
            kernel.Bind<IDespesaCarroAluguelAppService>().To<DespesaCarroAluguelAppService>();
            kernel.Bind<IDespesaCarroAppService>().To<DespesaCarroAppService>();
            kernel.Bind<IDespesaOutroAppService>().To<DespesaOutroAppService>();
            kernel.Bind<IDespesaPerDiemAppService>().To<DespesaPerDiemAppService>();
            kernel.Bind<IDespesaPrincipalAppService>().To<DespesaPrincipalAppService>();
            kernel.Bind<IDespesaTransporteAppService>().To<DespesaTransporteAppService>();
            kernel.Bind<IDespesaViagemAppService>().To<DespesaViagemAppService>();
            kernel.Bind<IMoedaAppService>().To<MoedaAppService>();
            kernel.Bind<IPaisAppService>().To<PaisAppService>();
            kernel.Bind<IParametrosSistemaAppService>().To<ParametrosSistemaAppService>();
            kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
            kernel.Bind<IRespostaSolicitacaoAppService>().To<RespostaSolicitacaoAppService>();
            kernel.Bind<ISolicitacaoReembolsoAppService>().To<SolicitacaoReembolsoAppService>();
            kernel.Bind<ISolicitacaoViagemAppService>().To<SolicitacaoViagemAppService>();
            kernel.Bind<ITaxaCambioAppService>().To<TaxaCambioAppService>();
            kernel.Bind<ITipoAcomodacaoAppService>().To<TipoAcomodacaoAppService>();
            kernel.Bind<ITipoDespesaCarroAppService>().To<TipoDespesaCarroAppService>();
            kernel.Bind<ITipoViagemAppService>().To<TipoViagemAppService>();

            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICentroCustoService>().To<CentroCustoService>();
            kernel.Bind<IClasseViagemService>().To<ClasseViagemService>();
            kernel.Bind<IDespesaAcomodacaoService>().To<DespesaAcomodacaoService>();
            kernel.Bind<IDespesaCarroAluguelService>().To<DespesaCarroAluguelService>();
            kernel.Bind<IDespesaCarroService>().To<DespesaCarroService>();
            kernel.Bind<IDespesaOutroService>().To<DespesaOutroService>();
            kernel.Bind<IDespesaPerDiemService>().To<DespesaPerDiemService>();
            kernel.Bind<IDespesaPrincipalService>().To<DespesaPrincipalService>();
            kernel.Bind<IDespesaTransporteService>().To<DespesaTransporteService>();
            kernel.Bind<IDespesaViagemService>().To<DespesaViagemService>();
            kernel.Bind<IMoedaService>().To<MoedaService>();
            kernel.Bind<IPaisService>().To<PaisService>();
            kernel.Bind<IPessoaService>().To<PessoaService>();
            kernel.Bind<IParametrosSistemaService>().To<ParametrosSistemaService>();
            kernel.Bind<IRespostaSolicitacaoService>().To<RespostaSolicitacaoService>();
            kernel.Bind<ISolicitacaoReembolsoService>().To<SolicitacaoReembolsoService>();
            kernel.Bind<ISolicitacaoViagemService>().To<SolicitacaoViagemService>();
            kernel.Bind<ITaxaCambioService>().To<TaxaCambioService>();
            kernel.Bind<ITipoAcomodacaoService>().To<TipoAcomodacaoService>();
            kernel.Bind<ITipoDespesaCarroService>().To<TipoDespesaCarroService>();
            kernel.Bind<ITipoViagemService>().To<TipoViagemService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(IRepositoryBase<>));
            kernel.Bind<IRepositoryCentroCusto>().To<RepositoryCentroCusto>();
            kernel.Bind<IRepositoryClasseViagem>().To<RepositoryClasseViagem>();
            kernel.Bind<IRepositoryDespesaAcomodacao>().To<RepositoryDespesaAcomodacao>();
            kernel.Bind<IRepositoryDespesaCarroAluguel>().To<RepositoryDespesaCarroAluguel>();
            kernel.Bind<IRepositoryDespesaCarro>().To<RepositoryDespesaCarro>();
            kernel.Bind<IRepositoryDespesaOutro>().To<RepositoryDespesaOutro>();
            kernel.Bind<IRepositoryDespesaPerDiem>().To<RepositoryDespesaPerDiem>();
            kernel.Bind<IRepositoryDespesaPrincipal>().To<RepositoryDespesaPrincipal>();
            kernel.Bind<IRepositoryDespesaTransporte>().To<RepositoryDespesaTransporte>();
            kernel.Bind<IRepositoryDespesaViagem>().To<RepositoryDespesaViagem>();
            kernel.Bind<IRepositoryMoeda>().To<RepositoryMoeda>();
            kernel.Bind<IRepositoryPais>().To<RepositoryPais>();
            kernel.Bind<IRepositoryPessoa>().To<RepositoryPessoa>();
            kernel.Bind<IRepositoryParametrosSistema>().To<RepositoryParametrosSistema>();
            kernel.Bind<IRepositoryRespostaSolicitacao>().To<RepositoryRespostaSolicitacao>();
            kernel.Bind<IRepositorySolicitacaoReembolso>().To<RepositorySolicitacaoReembolso>();
            kernel.Bind<IRepositorySolicitacaoViagem>().To<RepositorySolicitacaoViagem>();
            kernel.Bind<IRepositoryTaxaCambio>().To<RepositoryTaxaCambio>();
            kernel.Bind<IRepositoryTipoAcomodacao>().To<RepositoryTipoAcomodacao>();
            kernel.Bind<IRepositoryTipoDespesaCarro>().To<RepositoryTipoDespesaCarro>();
            kernel.Bind<IRepositoryTipoViagem>().To<RepositoryTipoViagem>();
        }        
    }
}
