﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Footers
{
    class Sportfooter : IFooter
    {
        private int lettergrootte = 13;
        private String lettertype = "Arial Black";
        private String naamAuteur = null;

        public void setAuteurNaam(String _naamAuteur)
        {
            naamAuteur = _naamAuteur;
        }

        public String getAuteurNaam()
        {
            return naamAuteur;
        }
    }
}
