using Autofac;

namespace BudgetControl.Infra.CrossCutting.IOC
{
    //classe ModuleIOC que será responsável por realizar a criação de um módulo que realizará leitura do meu container IoC para ler todas as instâncias das classes do nosso projeto.
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIOC.Load(builder);

            #endregion Carrega IOC
        }
    }
}