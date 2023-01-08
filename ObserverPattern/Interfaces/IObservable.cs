using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface IObservable 
    {
        void Register(IObserver observer);
        void Deregister(IObserver observer);
        void Notify();
    }
}