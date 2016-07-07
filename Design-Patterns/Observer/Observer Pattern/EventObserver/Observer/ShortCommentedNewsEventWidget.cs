using System;
using System.Collections.Generic;

using Observer.Model;
using Observer.Observer_Pattern.EventObserver.EventArgs;
using Observer.Observer_Pattern.EventObserver.Observer.Interface;
using Observer.Observer_Pattern.EventObserver.Subject;

namespace Observer.Observer_Pattern.EventObserver.Observer
{
    public class ShortCommentedNewsEventWidget : IWidget
    {
        private News _shortCommentedNews;
        private List<Comment> _newsComments;

        public ShortCommentedNewsEventWidget()
        {
            _newsComments = new List<Comment>();
        }

        public void Update(object sender, NewsEventArgs e)
        {
            _shortCommentedNews = e.News;

            var subject = sender as NewsEventSubject;
            if (subject != null)
            {
                _newsComments = subject.GetNewsComments(e.News.Id);
            }

            //Just for demo solution we call Display from Update function.
            Display();
        }

        public void Display()
        {
            string formattedNews = string.Format("ShortCommentedNewsWidget: \n Header: {0}", _shortCommentedNews.Header);
            Console.WriteLine(formattedNews);

            Console.WriteLine("\t\t Comments:");
            if (_newsComments == null || _newsComments.Count == 0)
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
