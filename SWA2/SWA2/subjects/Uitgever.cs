using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWA2.observers;

namespace SWA2.subjects
{
    public class Uitgever : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        NieuwsberichtWrapper wrapper;

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                Console.WriteLine("observer["+observer+"] got an update");
                observer.update(wrapper);
            }
        }

        public void setWrapper(NieuwsberichtWrapper newWrapper)
        {
            wrapper = newWrapper;
        }
    }
}
