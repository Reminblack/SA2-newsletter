using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public interface AbstractComponentFactory
    {
        public Header createHeader();

        public Content createContent();

        public Footer createFooter();
    }
}
