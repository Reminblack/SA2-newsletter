using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWA2.factories;
namespace SWA2
{
    public class ANewsStore
    {
        public NieuwsBericht createBericht(String type)
        {
            NieuwsBericht news = writeBericht(type);

            news.maak();
            news.verifieer();
            news.post();

            return news;
        }

        private NieuwsBericht writeBericht(String type)
        {
            NieuwsBericht bericht;
            if (type.Equals("Weerbericht"))
            {
                bericht = new WeerberichtComponentFactory();
                //weerbericht.
            } 
            else if(type.Equals("Overlijdingsbericht"))
            {
                //bericht = new OverlijdingsberichtComponentFactory();
            }
            else if (type.Equals("Sportbericht"))
            {
                //bericht = new SportberichtComponentFactory();
            }
            else if (type.Equals("Nieuwsbericht"))
            {
                //bericht = new NieuwsberichtComponentFactory();
            }
            else
            {
                return null;
            }
            return null;
        }

    }
}
