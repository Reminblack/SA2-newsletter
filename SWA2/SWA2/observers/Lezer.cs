using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWA2.observers
{
    public class Lezer : IObserver
    {
        List<subjects.ISubject> subject = null;

        public Lezer()
        {
            
        }

        public Lezer(subjects.ISubject subjectToRegisterTo)
        {
            subject.Add(subjectToRegisterTo);
        }

        public void addSubject(subjects.ISubject subject)
        {
            this.subject.Add(subject);
            registerToSubject(subject);
        }

        public void removeSubject(subjects.ISubject subject)
        {
            unregisterFromSubject(subject);
            this.subject.Remove(subject);
        }

        public void registerToSubject(subjects.ISubject subject)
        {
            subject.registerObserver(this);
        }

        public void unregisterFromSubject(subjects.ISubject subject)
        {
            try
            {
                this.subject.Find((searchSubject => { return (searchSubject == subject); })).removeObserver(this);
            }
            catch (Exception e)
            {
                Console.WriteLine("subject not found for this reader: " + e);
            }
        }

        public void update(NieuwsberichtWrapper nieuwsberichtWrapper)
        {
            NieuwsBericht nieuwsbericht = nieuwsberichtWrapper.readWrapper();
            Console.WriteLine("Update ontvangen voor lezer["+this+"] over het onderwerp" + nieuwsbericht.getHeader().getTitel());
        }
    }
}
