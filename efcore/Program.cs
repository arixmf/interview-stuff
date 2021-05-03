using System;
using System.Collections.Generic;

namespace efcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var commentsServide = new CommentsService();
            var comments = commentsServide.GetPagedComments(1, 1);

            foreach (var comment in comments)
            {
                Console.WriteLine($"Comment {comment.CommentId}: {comment.Contents}");
            }
        }
    }
}
