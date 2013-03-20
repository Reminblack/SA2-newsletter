using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.factories
{
    class NieuwsberichtComponentFactory : AbstractComponentFactory
    {
        public IHeader createHeader()
        {
            IHeader header = new SWA2.products.Headers.Nieuwsheader();
            header.setTitel("Ik ben een nieuwsheader");

            return header;
        }

        public IContent createContent()
        {
            IContent content = new SWA2.products.Contents.NieuwsContent();
            content.setText("Ik ben een NieuwsContent");
            return content;
        }

        public IFooter createFooter()
        {
            IFooter footer = new SWA2.products.Footers.Nieuwsfooter();
            footer.setAuteurNaam("Ik ben een nieuwsfooter");

            return footer;
        }
    }
}
