using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IObserver
    {
        public string Name { get; set; }

        public void Update();
        public void Subscribe();
        public void Unsubscribe();

    }
}
