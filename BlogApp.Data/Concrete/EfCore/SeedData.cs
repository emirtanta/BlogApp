﻿using BlogApp.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            BlogContext context = app.ApplicationServices.GetRequiredService<BlogContext>();

            context.Database.Migrate();


            if (!context.Categories.Any())
            {
                context.Categories.AddRange(

                    new Category() { Name="Category 1"},
                    new Category() { Name = "Category 2" },
                    new Category() { Name = "Category 3" }
                    );

                context.SaveChanges();
            }

            if (!context.Blogs.Any())
            {
                context.Blogs.AddRange(
                    new Blog() { Title="Blog title 1",Description="Blog Description 1",Body="Blog Body 1",Image="1.jpg",Date=DateTime.Now.AddDays(-5),isApproved=true,CategoryId=1},

                    new Blog() { Title = "Blog title 2", Description = "Blog Description 2", Body = "Blog Body 2", Image = "1.jpg", Date = DateTime.Now.AddDays(-5), isApproved = true, CategoryId = 1 },

                    new Blog() { Title = "Blog title 3", Description = "Blog Description 3", Body = "Blog Body 3", Image = "3.jpg", Date = DateTime.Now.AddDays(-5), isApproved = true, CategoryId = 1 }
                    );

                context.SaveChanges();
            }
        }
    }
}
