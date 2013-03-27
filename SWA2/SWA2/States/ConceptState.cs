using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.States
{
    public class ConceptState : IState
    {
        private NieuwsBericht bericht;

        public ConceptState(NieuwsBericht bericht)
        {
            this.bericht = bericht;
        }

        public IState edit()
        {
            Console.WriteLine("Het bericht wordt al aangepast.");
            return this;
        }

        public IState review()
        {
            Console.WriteLine("Het bericht wordt in review geplaatst.");
            return bericht.getInReviewState();
        }

        public IState publish()
        {
            Console.WriteLine("Bericht kan niet worden gepublisheerd. Plaats bericht eerst in review.");
            return this;
        }

        public IState archive()
        {
            Console.WriteLine("Dit bericht kan niet worden gearchiveerd, publiceer het eerst.");
            return this;
        }
    }
}
