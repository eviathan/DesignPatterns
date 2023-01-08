using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        Guid Id { get; set; }

        INewsObservable Observable { get; set; }

        void Update();
    }
}