using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWA2.factories;
namespace SWA2
{
    public class ANewsStore
    {
        public abstract NieuwsBericht createNieuwsbericht(String type)
        {
            NieuwsBericht news = new NieuwsBericht();

            if (type.Equals("weerbericht"))
            {
                AbstractComponentFactory factory = new factories.WeerberichtComponentFactory();
                news.setType("Weerbericht");
                news.setHeader(factory.createHeader());
                news.setContent(factory.createContent());
                news.setFooter(factory.createFooter());
            }
            else if (type.Equals("Nieuwsbericht"))
            {
                AbstractComponentFactory factory = new factories.NieuwsberichtComponentFactory();
                news.setType("Nieuwsbericht");
                news.setHeader(factory.createHeader());
                news.setContent(factory.createContent());
                news.setFooter(factory.createFooter());
            }
            else if (type.Equals("Sportbericht"))
            {
                AbstractComponentFactory factory = new factories.SportberichtComponentFactory();
                news.setType("Sportbericht");
                news.setHeader(factory.createHeader());
                news.setContent(factory.createContent());
                news.setFooter(factory.createFooter());
            }
            else if (type.Equals("Overlijdingsbericht"))
            {
                AbstractComponentFactory factory = new factories.OverlijdingsberichtComponentFactory();
                news.setType("Overlijdingsbericht");
                news.setHeader(factory.createHeader());
                news.setContent(factory.createContent());
                news.setFooter(factory.createFooter());
            }
            return news;
        }

        protected abstract NieuwsBericht writeNieuwsBericht(String type)
        {
            return null;
        }

    }
}
