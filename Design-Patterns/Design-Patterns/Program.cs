using Design_Patterns.Data_Repository;
using Design_Patterns.Observer_Pattern.CustomObserver.Observer;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject;
using Design_Patterns.Observer_Pattern.EventObserver.Observer;
using Design_Patterns.Observer_Pattern.EventObserver.Subject;

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

            #region Event Observer example

            var newsEventSubject = new NewsEventSubject();

            var shortNewsEventWidget = new ShortNewsEventWidget();
            var fullNewsEventWidget = new FullNewsEventWidget();
            var shortCommentedNewsEventWidget = new ShortCommentedNewsEventWidget();

            newsEventSubject.NewsAdded += shortNewsEventWidget.Update;
            newsEventSubject.NewsAdded += fullNewsEventWidget.Update;
            newsEventSubject.NewsAdded += shortCommentedNewsEventWidget.Update;

            newsEventSubject.SetNews(newsRepository.GetNews());
            newsEventSubject.SetNews(newsRepository.GetNews());

            newsEventSubject.NewsAdded -= fullNewsEventWidget.Update;
            newsEventSubject.NewsAdded -= shortCommentedNewsEventWidget.Update;

            newsEventSubject.SetNews(newsRepository.GetNews());
            newsEventSubject.SetNews(newsRepository.GetNews());

            #endregion


        }
    }
}
