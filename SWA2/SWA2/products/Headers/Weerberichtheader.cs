using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Headers
{
<<<<<<< HEAD
    class Weerberichtheader : IHeader
=======
    class WeerberichtHeader : Header
>>>>>>> 1faad18d4100d6a4a0f1bfc102a390a82a8679e3
    {
        private String titel;
        private int lettergrootte = 16;
        private String lettertype = "New Times Roman";
        private DateTime datum = DateTime.Now;

        protected void setTitel(String _title)
        {
            titel = _title;
        }
    }
}
