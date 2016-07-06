using Design_Patterns.Data_Repository;
using Design_Patterns.Observer_Pattern.CustomObserver.Observer;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsRepository = new NewsRepository();

            #region Custom Observer example

            var newsSubject = new NewsSubject();

            var shortNewsWidget = new ShortNewsWidget();
            var fullNewsWidget = new FullNewsWidget();
            var shortCommentedNewsWidget = new ShortCommentedNewsWidget();

            newsSubject.Subscribe(shortNewsWidget);
            newsSubject.Subscribe(fullNewsWidget);
            newsSubject.Subscribe(shortCommentedNewsWidget);

            newsSubject.SetNews(newsRepository.GetNews());
            newsSubject.SetNews(newsRepository.GetNews());

            newsSubject.Unsubscribe(fullNewsWidget);
            newsSubject.Unsubscribe(shortCommentedNewsWidget);

            newsSubject.SetNews(newsRepository.GetNews());
            newsSubject.SetNews(newsRepository.GetNews());

            #endregion
        }
    }
}
