using System;
using System.Collections.Generic;

using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.CustomObserver.Observer.Interface;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Design_Patterns.Observer_Pattern.CustomObserver.Observer
{
    public class FullNewsWidget : INewsWidgetObserver
    {
        private readonly List<News> _fullNews;

        public FullNewsWidget()
        {
            _fullNews = new List<News>();
        }

        public void Update(INewsSubject observable, News news)
        {
            if (!_fullNews.Contains(news))
            {
                _fullNews.Add(news);
            }

            //Just for demo solution we call Display from Update function.
            Display(news);
        }

        public void Display(News news)
        {
            string formattedNews = string.Format("FullNewsWidget: \n Header: {0} \n Photo: {1} \n Text: {2} \n Date: {3}",
                                                 news.Header,
                                                 news.MainPhoto,
                                                 news.Text,
                                                 news.Date);
            Console.WriteLine(formattedNews);
        }
    }
}
