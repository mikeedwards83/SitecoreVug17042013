using System;
using System.Web.UI;
using Glass.Mapper.Sc.Web.Ui;
using Glass.Mapper.Sc;

namespace Vug.layouts.Site.Misc
{
    public partial class TopNavigationSublayout : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new SitecoreContext();
            Model = context.GetHomeItem<dynamic>();
        }
        public dynamic Model { get; set; }
    }
}
    