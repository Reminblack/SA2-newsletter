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
            header.setTitel("ik ben een overlijdingsheader");

            return header;
        }

        public IContent createContent()
        {
            IContent content = new SWA2.products.Contents.OverlijdingsContent();
            content.setText("Ik ben een overlijdingscontent");

            return content;
        }

        public IFooter createFooter()
        {
            IFooter footer = new SWA2.products.Footers.Overlijdingsfooter();
            footer.setAuteurNaam("Ik ben een overlijdingsfooter");

            return footer;
        }
    }
}
