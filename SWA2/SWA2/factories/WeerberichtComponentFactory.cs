using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.factories
{
    class WeerberichtComponentFactory : AbstractComponentFactory
    {
        public Header createHeader()
        {
            IHeader header = new SWA2.products.Headers.Weerberichtheader();


            return IHeader;
        }

        public Content createContent();

        public Footer createFooter();
    }
}
