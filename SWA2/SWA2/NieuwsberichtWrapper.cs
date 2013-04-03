using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public class NieuwsberichtWrapper : IWrapper<NieuwsBericht>
    {
        NieuwsBericht wrappedProduct = null;

        public NieuwsberichtWrapper()
        {

        }

        public NieuwsberichtWrapper(NieuwsBericht toBeWrappedNieuwsbericht)
        {
            wrappedProduct = toBeWrappedNieuwsbericht;
        }

        public void fillWrapper(NieuwsBericht toBeWrappedNieuwsbericht)
        {

        }

        public NieuwsBericht readWrapper()
        {
            return wrappedProduct;
        }
    }
}
