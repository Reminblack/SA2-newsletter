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
        private IState state;
        private IState ArchivedState;
        private IState PublishedState;
        private IState InReviewState;
        private IState ConceptState;

        public NieuwsBericht()
        {
            ConceptState = new States.ConceptState(this);
            InReviewState = new States.InReviewState(this);
            PublishedState = new States.PublishState(this);
            ArchivedState = new States.ArchivedState(this);
        }

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

        public void setState(IState state)
        {
            this.state = state;
        }



        public void edit()
        {
            state = state.edit();
        }

        public void archive()
        {
            state = state.archive();
        }

        public void concept()
        {
            state = state.review();
        }

        public void publish()
        {
            state = state.publish();
        }




        public IState getConceptState()
        {
            return ConceptState;
        }

        public IState getInReviewState()
        {
            return InReviewState;
        }

        public IState getPublishedState()
        {
            return PublishedState;
        }
        
        public IState getArchivedState()
        {
            return ArchivedState;
        }
    }
}
