using System;
using System.Collections.Generic;

using Design_Patterns.Model;
using Design_Patterns.Observer_Pattern.CustomObserver.Observer.Interface;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject;
using Design_Patterns.Observer_Pattern.CustomObserver.Subject.Interface;

namespace Design_Patterns.Observer_Pattern.CustomObserver.Observer
{
    public class ShortCommentedNewsWidget : INewsWidgetObserver
    {
        private readonly List<News> _shortCommentedNews;

        public ShortCommentedNewsWidget()
        {
            _shortCommentedNews = new List<News>();
        }

        public void Update(INewsSubject observable, News news)
        {
            if (!_shortCommentedNews.Contains(news))
            {
                _shortCommentedNews.Add(news);
            }

            var subject = observable as NewsSubject;
            var comments = new List<Comment>();
            if (subject != null)
            {
                comments = subject.GetNewsComments(news.Id);
            }

            //Just for demo solution we call Display from Update function.
            Display(news, comments);
        }

        public void Display(News news, List<Comment> comments)
        {
            string formattedNews = string.Format("ShortCommentedNewsWidget: \n Header: {0}", news.Header);
            Console.WriteLine(formattedNews);

            Console.WriteLine("\t\t Comments:");
            if (comments.Count == 0)
            {
                Console.WriteLine("\t\t No comments for this news");
                return;
            }

            foreach (var comment in comments)
            {
                string formattedComment = string.Format("\t\t Author: {0} \n\t\t Text: {1} \n\t\t Date: {2}",
                                                        comment.Author,
                                                        comment.Text,
                                                        comment.Date);
                Console.WriteLine(formattedComment);
            }
        }
    }
}
