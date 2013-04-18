using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Glass.Mapper.Configuration;
using Glass.Mapper.Sc.CastleWindsor;
using Glass.Mapper.Sc.Configuration.Attributes;
using Vug.Services;

namespace Vug.App_Start
{
    public static  class GlassMapperScCustom
    {
		public static void CastleConfig(IWindsorContainer container){
			var config =  new Config(){UseWindsorContructor = true};

		    var installer = new SitecoreInstaller(config);
            installer.ConfigurationResolverTaskInstaller = new CustomConfigurationResolverTaskInstaller(config);

		    container.Install(installer);

            container.Register(
                Component.For<IRssService>().ImplementedBy<RssService>().LifestyleTransient()
                );
		}

		public static IConfigurationLoader[] GlassLoaders(){
			var attributes = new SitecoreAttributeConfigurationLoader("Vug");
			
			return new IConfigurationLoader[]{attributes};
		}
    }
}
