using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Vug.Services;

namespace Vug.Models
{
    public class RssLanding
    {
        private readonly IRssService _service;

        public virtual string RssUrl { get; set; }

        public virtual int Number { get; set; }

        public virtual string Title { get; set; }

        public RssLanding(IRssService service)
        {
            _service = service;
        }

        public IEnumerable<SyndicationItem> GetArticles()
        {
            var result = _service.GetArticles(RssUrl);
            return result.Take(Number);
        }
    }
}