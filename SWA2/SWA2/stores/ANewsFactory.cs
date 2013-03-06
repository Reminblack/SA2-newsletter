using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public abstract class ANewsFactory
    {
        public abstract NieuwBericht createNieuwsbericht(String type)
        {
            NieuwsBericht news = writeNieuwsBericht(type);

            news.maak();
            news.verifieer();
            news.post();

            return news;
        }

        protected abstract NieuwsBericht writeNieuwsBericht(String type)
        {

        }

    }
}
