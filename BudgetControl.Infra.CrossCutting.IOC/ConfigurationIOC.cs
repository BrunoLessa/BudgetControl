using Autofac;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Services;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BudgetControl.Infra.CrossCutting.Adapter.Mappers;
using BudgetControl.Infra.Repository;
using BugetControl.Application.Interfaces;
using BugetControl.Application.Services;

namespace BudgetControl.Infra.CrossCutting.IOC
{
    //classe ConfigurationIOC que será responsável por realizar a criação de um container IoC para registrar todas as instâncias das classes do nosso projeto.
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application

            builder.RegisterGeneric(typeof(ApplicationServiceBase<,,>)).As(typeof(IApplicationServiceBase<>));
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();


            #endregion IOC Application

            #region IOC Services
            builder.RegisterGeneric(typeof(DomainServiceBase<,>)).As(typeof(IDomainServiceBase<,>));
            builder.RegisterType<DomainServiceCliente>().As<IDomainServiceCliente>();
            builder.RegisterType<DomainServiceProduto>().As<IDomainServiceProduto>();
            builder.RegisterType<DomainServiceUsuario>().As<IDomainServiceUsuario>();

            #endregion IOC Services

            #region IOC Repositorys SQL

            builder.RegisterGeneric(typeof(RepositoryBase<>)).As(typeof(IRepositoryBase<>));
            builder.RegisterType<RepositoryUnitOfWork>().As<IRepositoryUnitOfWork>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();

            #endregion IOC Repositorys SQL

            #region IOC Mapper

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();

            #endregion IOC Mapper

            #endregion Registra IOC
        }
    }
}