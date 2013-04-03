using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.observers
{
    public interface IObserver
    {
        public void update(NieuwsberichtWrapper updateBericht); 
    }
}
