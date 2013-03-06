using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Footers
{
    class Sportfooter : Footer
    {
        private int lettergrootte = 13;
        private String lettertype = "Arial Black";
        private String naamAuteur = null;

        protected void setAuteurNaam(String _naamAuteur)
        {
            naamAuteur = _naamAuteur;
        }
    }
}
