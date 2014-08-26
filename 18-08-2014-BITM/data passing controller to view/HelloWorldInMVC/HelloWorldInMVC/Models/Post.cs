using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorldInMVC.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }

        public int Type { get; set; }
    }

    public class MyPost : DbContext
    {
        public DbSet<Post> db { get; set; }
    }
}