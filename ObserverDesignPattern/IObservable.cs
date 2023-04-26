using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IObservable
    {
        public List<IObserver> Observers { get; }

        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
    }
}
