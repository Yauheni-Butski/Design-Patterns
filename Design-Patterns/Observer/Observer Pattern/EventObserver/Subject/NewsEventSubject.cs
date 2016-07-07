using System.Collections.Generic;
using System.Linq;

using Observer.Data_Repository;
using Observer.Model;
using Observer.Observer_Pattern.EventObserver.EventArgs;

namespace Observer.Observer_Pattern.EventObserver.Subject
{
    public delegate void NewsAddedEventHandler(object sender, NewsEventArgs args);
    public class NewsEventSubject
    {
        public event NewsAddedEventHandler NewsAdded;

        private readonly CommentRepository _commentRepository;
        private News _latestNews;

        public NewsEventSubject()
        {
            _commentRepository = new CommentRepository();
        }

        //For demo solution our subject receive news from set method.
        public void SetNews(News news)
        {
            _latestNews = news;
            NewsAdded?.Invoke(this, new NewsEventArgs(news));
        }

        public List<Comment> GetNewsComments(int newsId)
        {
            var comments = _commentRepository.GetCommentsByNewsId(newsId).ToList();

            return comments;
        }
    }
}
