using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWA2.observers;

namespace SWA2.subjects
{
    public interface ISubject
    {
        public void registerObserver(IObserver observer);
        public void removeObserver(IObserver observer);
        public void notifyObserver(NieuwsBericht nieuwsbericht);        
    }
}
