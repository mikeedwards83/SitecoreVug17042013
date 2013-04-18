using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Glass.Mapper.Pipelines.ConfigurationResolver;
using Glass.Mapper.Sc.CastleWindsor;
using Vug.Pipelines.ConfigurationResolver;

namespace Vug.App_Start
{
    public class CustomConfigurationResolverTaskInstaller : ConfigurationResolverTaskInstaller
    {
        public CustomConfigurationResolverTaskInstaller(Config config):base(config)
        {
        }

        public override void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IConfigurationResolverTask>()
                         .ImplementedBy<EventConfigurationTask>()
                         .LifestyleTransient()
                );
            base.Install(container, store);
        }
    }
}