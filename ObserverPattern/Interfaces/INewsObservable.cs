using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface INewsObservable : IObservable
    {
        void PublishArticle(string news);
        
        IEnumerable<Article> GetArticlesSince(DateTime dateTime);
    }
}