using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public abstract class AbstractComponentFactory
    {
        public abstract IHeader createHeader();

        public abstract IContent createContent();

        public abstract IFooter createFooter();
    }
}
