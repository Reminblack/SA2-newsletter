using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.States
{
    class InReviewState : IState
    {
        private NieuwsBericht bericht;

        public InReviewState(NieuwsBericht bericht)
        {
            this.bericht = bericht;
        }

        public IState edit()
        {
            Console.WriteLine("Bestand is niet goed, pas de fouten aan en stuur hem weer in review.");
            return bericht.getConceptState();
        }

        public IState review()
        {
            Console.WriteLine("Het bestand is al in review.");
            return this;
        }

        public IState publish()
        {
            Console.WriteLine("Bericht wordt gepublisheerd.");
            return bericht.getPublishedState();
        }

        public IState archive()
        {
            Console.WriteLine("Dit bericht mag niet worden gearchiveerd vanuit review. Publish het bericht eerst.");
            return this;
        }
    }
}
