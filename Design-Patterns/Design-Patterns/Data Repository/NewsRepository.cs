using System;
using System.Collections.Generic;

using Design_Patterns.Model;

namespace Design_Patterns.Data_Repository
{
    public class NewsRepository
    {
        private readonly List<News> _news;
        private readonly Random _randomizer;

        public NewsRepository()
        {
            _randomizer = new Random();
            _news = new List<News>
            {
                new News(1, "Smurfs live!", "smurfs.jpg", "Few people from Poland saw live smurfs in a garden!",DateTime.Now),
                new News(2, "Titanfall 2 has been announced", "titanfall2.jpg", "Respawn int. has announced Titanfall 2 on E3 2016!", DateTime.Now),
                new News(3, "Denomination in Belarus", "money.jpg", "On the 1 of July in Belarus happend denomination. All people happy", DateTime.Now),
                new News(4, "New trailer of Deadpool was shown", "deadpool.jpg", "New trailer of Deadpool movie was shown on Comicon 2016!", DateTime.Now)
            };
        }

        public News GetNews()
        {
            var newsCount = _news.Count;
            var newsIndex = _randomizer.Next(newsCount);

            return _news[newsIndex];
        }
    }
}
