using Observer.Model;
using Observer.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Observer.Observer_Pattern.CustomObserver.Observer.Interface
{
    public interface INewsWidgetObserver
    {
        void Update(INewsSubject observable,News latestNews);
    }
}
