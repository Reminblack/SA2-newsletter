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
            AbstractComponentFactory factory = null;

            if (type.Equals("weerbericht"))
            {
                factory = new factories.WeerberichtComponentFactory();
            }
            else if (type.Equals("Nieuwsbericht"))
            {
                factory = new factories.NieuwsberichtComponentFactory();
            }
            else if (type.Equals(type))
            {
                factory = new factories.SportberichtComponentFactory();
            }
            else if (type.Equals("Overlijdingsbericht"))
            {
                factory = new factories.OverlijdingsberichtComponentFactory();
            }

            news.setType(type);
            news.setHeader(factory.createHeader());
            news.setContent(factory.createContent());
            news.setFooter(factory.createFooter());

            Console.WriteLine(news.getType());
            Console.WriteLine(news.getHeader());
            Console.WriteLine(news.getContent());
            Console.WriteLine(news.getFooter());
            
            return news;
            }

        protected abstract NieuwsBericht writeNieuwsBericht(String type)
        {
            return null;
        }

    }
}
