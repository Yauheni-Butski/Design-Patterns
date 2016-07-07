using System;

using Observer.Model;
using Observer.Observer_Pattern.CustomObserver.Observer.Interface;
using Observer.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Observer.Observer_Pattern.CustomObserver.Observer
{
    public class FullNewsWidget : INewsWidgetObserver, IWidget
    {
        private News _fullNews;

        public void Update(INewsSubject observable, News news)
        {
            _fullNews = news;

            //Just for demo solution we call Display from Update function.
            Display();
        }

        public void Display()
        {
            var formattedNews = string.Format("FullNewsWidget: \n Header: {0} \n Photo: {1} \n Text: {2} \n Date: {3}",
                                                 _fullNews.Header,
                                                 _fullNews.MainPhoto,
                                                 _fullNews.Text,
                                                 _fullNews.Date);
            Console.WriteLine(formattedNews);
        }
    }
}
