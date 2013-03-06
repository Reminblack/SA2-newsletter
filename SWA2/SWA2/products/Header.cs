using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public interface Header
    {
        private String titel;
        private int lettergrootte;
        private String lettertype;
        private DateTime datum;

        protected void setTitel(String _title);
    }
}
