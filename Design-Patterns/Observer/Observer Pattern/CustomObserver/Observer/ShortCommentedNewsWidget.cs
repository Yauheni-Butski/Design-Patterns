using System;
using System.Collections.Generic;

using Observer.Model;
using Observer.Observer_Pattern.CustomObserver.Observer.Interface;
using Observer.Observer_Pattern.CustomObserver.Subject;
using Observer.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Observer.Observer_Pattern.CustomObserver.Observer
{
    public class ShortCommentedNewsWidget : INewsWidgetObserver, IWidget
    {
        private News _shortCommentedNews;
        private List<Comment> _newsComments;

        public ShortCommentedNewsWidget()
        {
            _newsComments = new List<Comment>();
        }

        public void Update(INewsSubject observable, News news)
        {
            _shortCommentedNews = news;

            var subject = observable as NewsSubject;
            if (subject != null)
            {
                _newsComments = subject.GetNewsComments(news.Id);
            }

            //Just for demo solution we call Display from Update function.
            Display();
        }

        public void Display()
        {
            var formattedNews = string.Format("ShortCommentedNewsWidget: \n Header: {0}", _shortCommentedNews.Header);
            Console.WriteLine(formattedNews);

            Console.WriteLine("\t\t Comments:");
            if (_newsComments.Count == 0)
            {
                Console.WriteLine("\t\t No comments for this news");
                return;
            }

            foreach (var comment in _newsComments)
            {
                var formattedComment = string.Format("\t\t Author: {0} \n\t\t Text: {1} \n\t\t Date: {2}",
                                                        comment.Author,
                                                        comment.Text,
                                                        comment.Date);
                Console.WriteLine(formattedComment);
            }
        }
    }
}
