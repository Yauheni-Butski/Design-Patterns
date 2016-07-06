using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Design_Patterns.Observer_Pattern.CustomObserver.Observer.Interface
{
    public interface INewsWidgetObserver
    {
        void Update(INewsSubject observable,News latestNews);
    }
}
