using System;

using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.EventObserver.EventArgs;
using Design_Patterns.Observer_Pattern.EventObserver.Observer.Interface;

namespace Design_Patterns.Observer_Pattern.EventObserver.Observer
{
    public class ShortNewsEventWidget : IWidget
    {
        private News _shortNews;

        public void Update(object sender, NewsEventArgs e)
        {
            _shortNews = e.News;

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
