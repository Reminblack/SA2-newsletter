using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public abstract class AbstractComponentFactory
    {
        public IHeader createHeader();

        public IContent createContent();

        public IFooter createFooter();
    }
}
