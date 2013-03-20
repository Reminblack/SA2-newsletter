using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Headers
{
    class Sportheader : IHeader
    {
        private String titel;
        private int lettergrootte = 24;
        private String lettertype = "New Times Roman";
        private DateTime datum = DateTime.Now;

        protected void setTitel(String _title)
        {
            titel = _title;
        }

        protected String getTitel()
        {
            return titel;
        }
    }
}
