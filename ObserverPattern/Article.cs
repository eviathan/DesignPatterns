using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Article
    {
        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public string News { get; private set; }

        public Article(string news)
        {
            News = news;
        }
    }
}