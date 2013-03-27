using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.States
{
    public class PublishState : IState
    {
        private NieuwsBericht bericht;

        public PublishState(NieuwsBericht bericht)
        {
            this.bericht = bericht;
        }

        public IState edit()
        {
            Console.WriteLine("Het bericht wordt aangepast.");
            return bericht.getPublishedState();
        }

        public IState review()
        {
            Console.WriteLine("Dit bericht is al succesvol door de review heengegaan.");
            return this;
        }

        public IState publish()
        {
            Console.WriteLine("Dit bericht is al gepublisheerd.");
            return this;
        }

        public IState archive()
        {
            Console.WriteLine("Het Bericht wordt gearchiveerd.");
            return bericht.getArchivedState();
        }
    }
}
