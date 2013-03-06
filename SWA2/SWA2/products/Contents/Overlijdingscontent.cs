using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Contents
{
    class OverlijdingsContent : Content
    {
        private int lettergrootte = 10;
        private String lettertype = "Arial";
        private String text = null;
        private String image = null;

        protected void setText(String _nieuwsText)
        {
            text = _nieuwsText;
        }

        protected void setImage(String _image)
        {
            image = _image;
        }
    }
}
