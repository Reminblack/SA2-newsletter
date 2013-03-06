using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public abstract class NieuwsBericht
    {
        String author;
        DateTime date;

        Header header;
        Content content;
        Footer footer;
    }
}
