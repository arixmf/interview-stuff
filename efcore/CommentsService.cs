using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace efcore
{
    public class CommentsService
    {
        const int COMMENTS_PER_PAGE = 20;

        public List<Comment> GetPagedComments(int postId, int page)
        {
            using (var context = new MyDbContext())
            {
                var post = context.Posts.Include(p => p.Comments).FirstOrDefault(p => p.PostId == postId);
                if (post == null)
                    throw new PostNotFoundException(postId);

                return post.Comments
                    .OrderByDescending(c => c.CreatedAt)
                    .Skip((page - 1) * COMMENTS_PER_PAGE)
                    .Take(COMMENTS_PER_PAGE)
                    .ToList();
            }
        }
    }
}