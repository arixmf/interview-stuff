using System;

namespace efcore
{
    public class PostNotFoundException : Exception
    {
        public PostNotFoundException(int postId)
            : base($"Post '{postId}' was not found")
        {}
    }
}