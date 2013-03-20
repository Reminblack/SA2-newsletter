using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.factories
{
    class SportberichtComponentFactory : AbstractComponentFactory
    {
        public IHeader createHeader()
        {
            IHeader header = new SWA2.products.Headers.Sportheader();
            header.setTitel("Ik ben een sportheader");

            return header;
        }

        public IContent createContent()
        {
            IContent content = new SWA2.products.Contents.SportContent();
            content.setText("Ik ben een sportcontent");

            return content;
        }

        public IFooter createFooter()
        {
            IFooter footer = new SWA2.products.Footers.Sportfooter();
            footer.setAuteurNaam("Ik ben een sportfooter");

            return footer;
        }
    }
}
