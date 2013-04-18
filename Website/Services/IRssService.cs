using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Vug.Services
{
    public interface IRssService
    {
        IEnumerable<SyndicationItem> GetArticles(string url);
    }
}