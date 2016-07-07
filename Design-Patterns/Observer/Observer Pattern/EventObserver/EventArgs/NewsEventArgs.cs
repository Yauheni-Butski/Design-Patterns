using Observer.Model;

namespace Observer.Observer_Pattern.EventObserver.EventArgs
{
    public class NewsEventArgs
    {
        public News News { get; private set; }

        public NewsEventArgs(News news)
        {
            News = news;
        }
    }
}
