using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Vug.Models
{
    [SitecoreType(AutoMap = true)]
    public class NewsLanding : ContentBase
    {
        [SitecoreQuery("./*/*/*[@@templatename='NewsArticle']", IsRelative = true)]
        public virtual IEnumerable<NewsArticle> Articles { get; set; }
    }
}