using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWA2.products.Headers;

namespace SWA2.factories
{
    class WeerBerichtFactory : AbstractComponentFactory
    {
        public Header createHeader()
        {
            Header header = new WeerberichtHeader();
            return header;
        }

        public Content createContent()
        {
            Content content = new WeerberichtContent();

            return content;
        }

        public Footer createFooter()
        {
            Footer footer = new WeerberichtFooter();

            return footer;
        }
    }
}
