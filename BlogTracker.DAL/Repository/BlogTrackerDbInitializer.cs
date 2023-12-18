// BlogTrackerDbInitializer.cs
using System;
using System.Data.Entity;
using BlogTracker.DAL.Entity;

namespace BlogTracker.DAL.Context
{
    public class BlogTrackerDbInitializer : DropCreateDatabaseIfModelChanges<BlogTrackerDbContext>
    {
        protected override void Seed(BlogTrackerDbContext context)
        {
            // Seed default data into AdminInfo table (if needed)
            context.Admins.Add(new AdminInfo { EmailId = "admin@example.com", Password = "adminPassword" });

            // Add other seed data as needed

            context.SaveChanges();
        }
    }
}

