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


            return header;
        }

        public IContent createContent();

        public IFooter createFooter();
    }
}
