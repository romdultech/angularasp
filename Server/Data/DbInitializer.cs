using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspCoreServer.Models;
using AspCoreServer;

namespace AspCoreServer.Data
{
    public static class DbInitializer
    {
        //public static void Initialize(SpaDbContext context)
        //{
        //    context.Database.EnsureCreated();

        //    if (context.User.Any())
        //    {
        //        return;   // DB has been seeded
        //    }
        //    var users = new Blog[]
        //    {
        //       new Blog(){Name = "Mark Pieszak"},
        //       new Blog(){Name = "Abrar Jahin"},
        //       new Blog(){Name = "hakonamatata"},
        //       new Blog(){Name = "LiverpoolOwen"},
        //       new Blog(){Name = "Ketrex"},
        //       new Blog(){Name = "markwhitfeld"},
        //       new Blog(){Name = "daveo1001"},
        //       new Blog(){Name = "paonath"},
        //       new Blog(){Name = "nalex095"},
        //       new Blog(){Name = "ORuban"},
        //       new Blog(){Name = "Gaulomatic"}
        //    };

        //    foreach (Blog s in users)
        //    {
        //        context.User.Add(s);
        //    }
        //    context.SaveChanges();
        //}
    }
}
