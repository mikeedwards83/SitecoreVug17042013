/*************************************

DO NTO CHANGE THIS FILE - UPDATE GlassMapperScCustom.cs

**************************************/




using System;
using System.Linq;
using Glass.Mapper.Configuration;
using Glass.Mapper.Sc.CastleWindsor;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration.Fluent;
using Vug.Models;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Vug.App_Start.GlassMapperScMobile), "Start")]

namespace Vug.App_Start
{
	public static class  GlassMapperScMobile
	{
		public static void Start()
		{
			//create the resolver
			var resolver = DependencyResolver.CreateStandardResolver();

			//install the custom services
			GlassMapperScCustom.CastleConfig(resolver.Container);

			//create a context
			var context = Glass.Mapper.Context.Create(resolver, "mobile");
			context.Load(      
				GlassLoaders()        				
				);
		}
        public static IConfigurationLoader[] GlassLoaders()
        {
            var attributes = new SitecoreAttributeConfigurationLoader("Vug");

            var fluent = new SitecoreFluentConfigurationLoader();
            
            var contentBase = fluent.Add<ContentBase>().AutoMap();
            contentBase.Field(x => x.Title).FieldName("MobileTitle");

            fluent.Add<NewsArticle>().Import(contentBase);

            return new IConfigurationLoader[] { attributes, fluent };
        }
	}
}