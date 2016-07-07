using System;

namespace Observer.Model
{
    public class Comment
    {
        public int Id { get; private set; }
        public int NewsId { get; private set; }
        public string Author { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }

        public Comment(int id, int newsId, string author, string text, DateTime date)
        {
            //Just for demo solution we allow insert Id from constructor.
            Id = id;
            NewsId = newsId;
            Author = author;
            Text = text;
            Date = date;
        }
    }
}
