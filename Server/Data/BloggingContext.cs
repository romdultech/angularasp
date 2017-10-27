using AspCoreServer.Models.Bloggings;
using Microsoft.EntityFrameworkCore;

namespace AspCoreServer.Data
{
    public class BloggingContext : DbContext
    {
    public BloggingContext(DbContextOptions<BloggingContext> options)
       : base(options)
    { }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> User { get; set; }
  }
}
