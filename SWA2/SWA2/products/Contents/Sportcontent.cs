﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.products.Contents
{
    class SportContent : IContent
    {
        private int lettergrootte = 12;
        private String lettertype = "Times New Roman";
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

        protected String getImage()
        {
            return image;
        }

        protected String getText()
        {
            return text;
        }
    }
}
