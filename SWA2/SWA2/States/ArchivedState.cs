
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.States
{
    public class ArchivedState : IState
    {
        private NieuwsBericht bericht;

        public ArchivedState(NieuwsBericht bericht)
        {
            this.bericht = bericht;
        }

        public IState edit()
        {
            Console.WriteLine("Kan het bestand niet aanpassen. /n Publiceer het bericht eerst.");
            return this;
        }

        public IState review()
        {
            Console.WriteLine("Dit bericht is al succesvol door de review heen gegaan.");
            return this;
        }

        public IState publish()
        {
            Console.WriteLine("Bericht wordt gepublisheerd.");
            return bericht.getPublishedState();
        }

        public IState archive()
        {
            Console.WriteLine("Dit bericht is al gearchiveerd.");
            return this;
        }
    }
}
