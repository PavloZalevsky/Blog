using JustBlog.Core;
using JustBlog.Core.Objects;
using System.Collections.Generic;

namespace JustBlog.Models
{
    public class ListViewModel
    {
        public IList<Post> Posts { get;  set; }
        public int TotalPosts { get;  set; }
    }
}