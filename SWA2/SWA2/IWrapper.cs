using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public interface IWrapper<T>
    {
        public void fillWrapper(IWrapper<T> wrappedProduct);
        public IWrapper<T> readWrapper();
    }
}
