using System;
using System.Collections.Generic;
using System.Linq;

using Observer.Model;

namespace Observer.Data_Repository
{
    public class CommentRepository
    {
        private readonly List<Comment> _comments;

        public CommentRepository()
        {
            _comments = new List<Comment>
            {
                new Comment(1, 1, "Andrey", "Awesome!", DateTime.Now),
                new Comment(2, 1, "Misha", "Greate news!", DateTime.Now),

                new Comment(3, 2, "Slava", "Fuck!", DateTime.Now),
                new Comment(4, 2, "Yauheni", "It is strange", DateTime.Now),

                new Comment(5, 3, "Nikita", "Bad news...", DateTime.Now),
                new Comment(6, 3, "Alex", "Super!", DateTime.Now)
            };
        }

        public IEnumerable<Comment> GetCommentsByNewsId(int newsId)
        {
            var comments = _comments.Where(c => c.NewsId == newsId);

            return comments;
        }
    }
}
