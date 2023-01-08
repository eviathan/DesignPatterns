using ObserverPattern.Interfaces;

namespace ObserverPattern.Observables
{
    public class NewsObservable : INewsObservable
    {
        private Dictionary<Guid, IObserver> _observers { get; set; } = new Dictionary<Guid, IObserver>();

        private List<Article> _articles { get; set; } = new List<Article>();

        public void Add(IObserver observer)
        {
            observer.Observable = this;
            _observers.Add(observer.Id, observer);
        }

        public void Remove(IObserver observer)
        {
            observer.Observable = default;
            _observers.Remove(observer.Id);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Value.Update();
        }

        public IEnumerable<Article> GetArticlesSince(DateTime dateTime)
        {
            return _articles.Where(x => x.DateTime >= dateTime);
        }

        public void PublishArticle(string news)
        {
            _articles.Add(new Article(news));
            Notify();
        }
    }
}