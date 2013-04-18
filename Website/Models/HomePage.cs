using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Vug.Models
{
    [SitecoreType(AutoMap=true)]
    public class HomePage
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string MainBody { get; set; }

        [SitecoreQuery("./News/*/*/*[@@templatename='NewsArticle']", IsRelative = true)]
        public virtual IEnumerable<NewsArticle> News { get; set; }

        [SitecoreQuery("./Events/*/*/*[@@templatename='Event']", IsRelative = true)]
        public virtual IEnumerable<EventBase> Events { get; set; }


    }

}