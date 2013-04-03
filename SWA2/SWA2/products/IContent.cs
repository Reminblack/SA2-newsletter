using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
   
    public interface IContent
    {
        void setText(String _nieuwsText);
        String getText();
        void setImage(String _image);
        String getImage();
    }
}
