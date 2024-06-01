using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}