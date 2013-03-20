using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Footers
{
    class Weerberichtfooter : IFooter
    {
        private int lettergrootte = 14;
        private String lettertype = "Arial Black";
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
