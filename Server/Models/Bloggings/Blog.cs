using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspCoreServer.Models.Bloggings
{
    public class Blog
    {
    public int BlogId { get; set; }
    public string Url { get; set; }
    public List<Post> Posts { get; set; }
  }
}
