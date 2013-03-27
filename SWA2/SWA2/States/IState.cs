using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public interface IState
    {

        public IState edit();

        public IState review();

        public IState publish();

        public IState archive();
        
    }
}
