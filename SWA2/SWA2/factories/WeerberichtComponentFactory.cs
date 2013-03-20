using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.factories
{
    class WeerberichtComponentFactory : AbstractComponentFactory
    {
        public IHeader createHeader()
        {
            IHeader header = new SWA2.products.Headers.Weerberichtheader();
            header.setTitel("Ik ben een weerberichtheader");

            return header;
        }

        public IContent createContent()
        {
            IContent content = new SWA2.products.Contents.WeerberichtContent();
            content.setText("Ik ben een weerberichtheader");

            return content;
        }

        public IFooter createFooter()
        {
            IFooter footer = new SWA2.products.Footers.Weerberichtfooter();
            footer.setAuteurNaam("Ik ben een weerberichtFooter");

            return footer;
        }
    }
}
