﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Footers
{
    class Nieuwsfooter : IFooter
    {
        private int lettergrootte = 12;
        private String lettertype = "Arial";
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
