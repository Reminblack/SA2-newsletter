using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public interface Footer
    {
        private int lettergrootte;
        private String lettertype;
        private String naamAuteur;

        protected void setAuteurNaam(String _naamAuteur);
    }
}
