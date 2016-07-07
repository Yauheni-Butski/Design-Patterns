using System;

using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.EventObserver.EventArgs;
using Design_Patterns.Observer_Pattern.EventObserver.Observer.Interface;

namespace Design_Patterns.Observer_Pattern.EventObserver.Observer
{
    public class FullNewsEventWidget : IWidget
    {
        private News _fullNews;

        public void Update(object sender, NewsEventArgs e)
        {
            _fullNews = e.News;

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
