using System;

using Observer.Model;
using Observer.Observer_Pattern.EventObserver.EventArgs;
using Observer.Observer_Pattern.EventObserver.Observer.Interface;

namespace Observer.Observer_Pattern.EventObserver.Observer
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
