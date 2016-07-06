using Design_Patterns.Observer_Pattern.CustomObserver.Observer.Interface;

namespace Design_Patterns.Observer_Pattern.CustomObserver.Subject.Interface
{
    public interface INewsSubject
    {
        void Subscribe(INewsWidgetObserver observer);
        void Unsubscribe(INewsWidgetObserver observer);
        void NotifyObservers();
    }
}
