using System;
using System.Xml.Linq;

namespace ObserverDesignPattern
{
    // The ConcreteSubject class extends the Subject class and defines its own state
    public class MailingList : IObservable
    {
        private List<string> _emails;

        public string Name { get; set; }
        public List<IObserver> Observers { get; private set; }


        public MailingList(string name)
        {
            Name = name;
            Observers = new List<IObserver>();
            _emails = new List<string>();
        }


        // Adds new email to the list and notify the list of all observers
        public void AddEmail(string email)
        {
            _emails.Add(email);
            Notify(); // Notify all the observers when a new email is added
        }

        public List<string> GetEmails()
        {
            return _emails;
        }

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update();
            }
        }

    }
}