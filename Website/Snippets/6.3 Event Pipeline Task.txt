using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Pipelines.ConfigurationResolver;
using Glass.Mapper.Pipelines.ConfigurationResolver.Tasks.OnDemandResolver;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Configuration;
using Vug.Models;

namespace Vug.Pipelines.ConfigurationResolver
{
    public class EventConfigurationTask : Glass.Mapper.Pipelines.ConfigurationResolver.IConfigurationResolverTask
    {
        public static readonly Type _largeType = typeof(LargeEvent);
        public static readonly Type _smallType = typeof(SmallEvent);
        public void Execute(ConfigurationResolverArgs args)
        {
            if (args.AbstractTypeCreationContext.RequestedType.IsAssignableFrom(typeof (EventBase)))
            {
                if (!args.Context.TypeConfigurations.ContainsKey(_largeType))
                {
                    var loader = new OnDemandLoader<SitecoreTypeConfiguration>(_largeType);
                    args.Context.Load(loader);
                }
                if (!args.Context.TypeConfigurations.ContainsKey(_smallType))
                {
                    var loader = new OnDemandLoader<SitecoreTypeConfiguration>(_smallType);
                    args.Context.Load(loader);
                }

                var scContext = args.AbstractTypeCreationContext as SitecoreTypeCreationContext;

                switch (scContext.Item["Type"])
                {
                    case "Large":
                        args.Result = args.Context.TypeConfigurations[_largeType];
                        break;
                    case "Small":
                        args.Result = args.Context.TypeConfigurations[_smallType];
                        break;
                }
            }
        }
    }
}