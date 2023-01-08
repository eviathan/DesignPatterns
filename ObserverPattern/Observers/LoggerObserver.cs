using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    public class LoggerObserver : IObserver
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public INewsObservable Observable { get; set; }

        private DateTime _lastUpdate { get; set; } = DateTime.UtcNow;

        public void Update()
        {
            var articles = Observable.GetArticlesSince(_lastUpdate);

            foreach (var article in articles)
                Console.WriteLine($"{article.DateTime}: {article.News}");

            _lastUpdate = DateTime.UtcNow;
        }
    }
}