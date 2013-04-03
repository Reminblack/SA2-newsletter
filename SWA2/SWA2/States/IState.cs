using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public interface IState
    {

        IState edit();

        IState review();

        IState publish();

        IState archive();
        
    }
}
