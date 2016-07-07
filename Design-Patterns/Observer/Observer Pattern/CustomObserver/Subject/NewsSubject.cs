using System.Collections.Generic;
using System.Linq;

using Observer.Data_Repository;
using Observer.Model;
using Observer.Observer_Pattern.CustomObserver.Observer.Interface;
using Observer.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Observer.Observer_Pattern.CustomObserver.Subject
{
    public class NewsSubject : INewsSubject
    {
        private readonly List<INewsWidgetObserver> _observers;
        private readonly CommentRepository _commentRepository;
        private News _latestNews;

        public NewsSubject()
        {
            _observers = new List<INewsWidgetObserver>();
            _commentRepository = new CommentRepository();
        }

        public void Subscribe(INewsWidgetObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unsubscribe(INewsWidgetObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this, _latestNews);
            }
        }

        //For demo solution our subject receive news from set method.
        public void SetNews(News news)
        {
            _latestNews = news;
            NotifyObservers();
        }

        public List<Comment> GetNewsComments(int newsId)
        {
            var comments = _commentRepository.GetCommentsByNewsId(newsId).ToList();

            return comments;
        }
    }
}
