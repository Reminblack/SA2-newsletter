﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Headers
{
    class Nieuwsheader : IHeader
    {
        private String titel;
        private int lettergrootte = 16;
        private String lettertype = "Arial black";
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
