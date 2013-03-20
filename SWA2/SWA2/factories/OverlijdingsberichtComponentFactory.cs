using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.factories
{
    class OverlijdingsberichtComponentFactory :AbstractComponentFactory
    {
        public IHeader createHeader()
        {
            IHeader header = new SWA2.products.Headers.Overlijdingsheader();


            return header;
        }

        public IContent createContent()
        {
            IContent content = new SWA2.products.Contents.OverlijdingsContent();

            return content;
        }

        public IFooter createFooter()
        {
            IFooter footer = new SWA2.products.Footers.Overlijdingsfooter();

            return footer;
        }
    }
}
