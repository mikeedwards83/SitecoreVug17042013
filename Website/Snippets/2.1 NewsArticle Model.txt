using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Vug.Models
{
    public class NewsArticle : ContentBase
    {
        public virtual string Abstract { get; set; }

        public virtual string MainBody { get; set; }

        public virtual Image FeaturedImage { get; set; }

        public virtual DateTime Date { get; set; }
    }

    public class ContentBase
    {
        public virtual string Title { get; set; }

        public virtual Guid Id { get; set; }

        public virtual string Url { get; set; }
    }
}