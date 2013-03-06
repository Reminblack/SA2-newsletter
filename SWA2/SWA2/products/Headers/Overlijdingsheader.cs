using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Headers
{
    class Overlijdingsheader : Header
    {
        private String titel;
        private int lettergrootte = 20;
        private String lettertype = "Arial";
        private DateTime datum = DateTime.Now;

        protected void setTitel(String _title)
        {
            titel = _title;
        }
    }
}
