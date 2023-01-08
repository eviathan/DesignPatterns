namespace ObserverPattern.Interfaces
{
    public interface INewsObservable : IObservable
    {
        void PublishArticle(string news);
        
        IEnumerable<Article> GetArticlesSince(DateTime dateTime);
    }
}