// BlogInfoRepository.cs
using System.Collections.Generic;
using System.Linq;
using BlogTracker.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogTracker.DAL.Repositories
{
    public class BlogInfoRepository
    {
        private readonly BlogTrackerDbContext _dbContext;

        public BlogInfoRepository(BlogTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBlogInfo(BlogInfo blogInfo)
        {
            _dbContext.Blogs.Add(blogInfo);
            _dbContext.SaveChanges();
        }

        public IEnumerable<BlogInfo> GetAllBlogInfo()
        {
            return _dbContext.Blogs.ToList();
        }

        // Add other repository methods as needed
    }
}
