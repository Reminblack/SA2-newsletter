using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    class Client
    {
        private NieuwsBericht bericht;

        public static void Main(String[] args)
        {

        }

        private void selectMessage(String message)
        {
            SWA2.Stores.ANewsStore store = new SWA2.Stores.ANewsStore();
            bericht = store.createNieuwsbericht(message);
        }

        public void publish()
        {
            if (bericht.getState().getType() == typeof(SWA2.States.PublishState))
            {
                NieuwsBerichtWrapper wrapper = new NieuwsBerichtWrapper();
                wrapper.fillWrapper(bericht);

            }
        }
    }
}
