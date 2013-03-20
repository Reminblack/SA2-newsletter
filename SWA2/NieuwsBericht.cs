using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2
{
    public class NieuwsBericht
    {
        private String type;
        private IHeader header;
        private IContent content;
        private IFooter footer;

        public void setType(String type)
        {
            this.type = type;
        }

        public String getType()
        {
            return type;
        }

        public void setHeader(IHeader header)
        {
            this.header = header;
        }

        public IHeader getHeader()
        {
            return header;
        }

        public void setContent(IContent content)
        {
            this.content = content;
        }

        public IContent getContent()
        {
            return content;
        }

        public void setFooter(IFooter footer)
        {
            this.footer = footer;
        }

        public IFooter getFooter()
        {
            return footer;
        }
    }
}
