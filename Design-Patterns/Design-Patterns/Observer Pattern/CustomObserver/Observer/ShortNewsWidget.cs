using System;
using System.Collections.Generic;
using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.CustomObserver.Observer.Interface;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Design_Patterns.Observer_Pattern.CustomObserver.Observer
{
    public class ShortNewsWidget : INewsWidgetObserver
    {
        private readonly List<News> _shortNews;

        public ShortNewsWidget()
        {
            _shortNews = new List<News>();
        }

        public void Update(INewsSubject observable, News news)
        {
            if (!_shortNews.Contains(news))
            {
                _shortNews.Add(news);
            }

            //Just for demo solution we call Display from Update function.
            Display(news);
        }

        public void Display(News news)
        {
            string formattedNews = string.Format("ShortNewsWidget: \n Header: {0}", news.Header);
            Console.WriteLine(formattedNews);
        }
    }
}
