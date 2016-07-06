﻿using System;

using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.CustomObserver.Observer.Interface;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Design_Patterns.Observer_Pattern.CustomObserver.Observer
{
    public class ShortNewsWidget : INewsWidgetObserver, IWidget
    {
        private News _shortNews;

        public void Update(INewsSubject observable, News news)
        {
            _shortNews = news;

            //Just for demo solution we call Display from Update function.
            Display();
        }

        public void Display()
        {
            var formattedNews = string.Format("ShortNewsWidget: \n Header: {0}", _shortNews.Header);
            Console.WriteLine(formattedNews);
        }
    }
}
