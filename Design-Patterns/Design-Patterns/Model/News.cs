using System;

namespace Design_Patterns.Model
{
    public class News
    {
        public int Id { get; private set; }
        public string Header { get; private set; }
        public string MainPhoto { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }

        public News(int id, string header, string mainPhoto, string text, DateTime date)
        {
            //Just for demo solution we allow insert Id from constructor.
            Id = id;
            Header = header;
            MainPhoto = mainPhoto;
            Text = text;
            Date = date;
        }
    }
}
