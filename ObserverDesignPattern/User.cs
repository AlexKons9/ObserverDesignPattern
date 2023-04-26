using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverDesignPattern
{
    // The ConcreteObserver class implements the Observer interface
    // and defines its own behavior when it receives an update
    // from the subject
    public class User : IObserver
    {
        private MailingList _mailingList;

 
        public string Name { get; set; }

        public User(string name, MailingList mailingList)
        {

            _mailingList = mailingList;
            Name = name;

        }

        public void Subscribe()
        {
            _mailingList.Add(this);
        }

        public void Unsubscribe()
        {
            _mailingList.Remove(this);
        }

        public void Update()
        {
            Console.WriteLine($"[{Name}] New email on mailing list {_mailingList.Name}: {_mailingList.GetEmails()[_mailingList.GetEmails().Count - 1]}");
            Console.WriteLine(" \n ------------------------------------------------------ \n");
        }
    }
}
