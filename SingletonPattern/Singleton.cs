using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        public static Singleton Instance => instance;

        public int Counter { get; set; }

        private static readonly Singleton instance = new Singleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton() { }

        private Singleton() { }
    }
}