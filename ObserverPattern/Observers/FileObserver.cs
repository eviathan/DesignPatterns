using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    public class FileObserver : IObserver
    {
        private const string FILE_PATH = @"NewsLog.txt";

        public Guid Id { get; set; } = Guid.NewGuid();

        public INewsObservable Observable  { get; set; }

        private DateTime _lastUpdate { get; set; }  = DateTime.UtcNow;

        public void Update()
        {
            var articles = Observable.GetArticlesSince(_lastUpdate);

            foreach (var article in articles)
                File.AppendAllText(FILE_PATH, $"{article.DateTime}: {article.News}{Environment.NewLine}");

            _lastUpdate = DateTime.UtcNow;
            
        }
    }
}