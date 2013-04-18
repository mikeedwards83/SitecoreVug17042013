using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Vug.Services
{
    public class RssService : IRssService
    {
        public IEnumerable<SyndicationItem> GetArticles(string url)
        {
            var xml = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(xml);
            return feed.Items;
        }
    }
}