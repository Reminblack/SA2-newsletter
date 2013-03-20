using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Footers
{
    class Overlijdingsfooter : IFooter
    {
        private int lettergrootte = 10;
        private String lettertype = "Times New Roman";
        private String naamAuteur = null;

        protected void setAuteurNaam(String _naamAuteur)
        {
            naamAuteur = _naamAuteur;
        }

        protected String getAuteurNaam()
        {
            return naamAuteur;
        }
    }
}
