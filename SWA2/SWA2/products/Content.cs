using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
   
    public interface Content
    {
        private int lettergrootte;
        private String lettertype;
        private String text;
        private String image;

        protected void setText(String _nieuwsText);
        protected void setImage(String _image);
    }
}
