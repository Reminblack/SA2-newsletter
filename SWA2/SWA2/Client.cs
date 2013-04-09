using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    class Client
    {
        private NieuwsBericht bericht;
        private SWA2.subjects.Uitgever uitgever = new SWA2.subjects.Uitgever();
        private SWA2.observers.Lezer lezer = new SWA2.observers.Lezer();
        NieuwsberichtWrapper wrapper;

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
            bericht.publish();
            if (bericht.getState().GetType() == typeof(SWA2.States.PublishState))
            {
                wrapper = new NieuwsberichtWrapper();
                wrapper.fillWrapper(bericht);
                lezer.registerToSubject(uitgever);

            }
        }

        public void notitify()
        {
            uitgever.setWrapper(wrapper);
            uitgever.notifyObservers();
        }

        public void edit()
        {
            bericht.edit();
        }

        public void archive()
        {
            bericht.archive();
        }

        public void concept()
        {
            bericht.concept();
        }
    }
}
