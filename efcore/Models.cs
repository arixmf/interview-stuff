using System;
using System.Collections.Generic;

namespace efcore
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedAt { get; set; }

        public Post Post { get; set; }
    }
}