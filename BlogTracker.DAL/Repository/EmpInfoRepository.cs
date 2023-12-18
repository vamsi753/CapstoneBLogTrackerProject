// EmpInfoRepository.cs
using System.Collections.Generic;
using System.Linq;
using BlogTracker.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogTracker.DAL.Repositories
{
    public class EmpInfoRepository
    {
        private readonly BlogTrackerDbContext _dbContext;

        public EmpInfoRepository(BlogTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEmpInfo(EmpInfo empInfo)
        {
            _dbContext.Employees.Add(empInfo);
            _dbContext.SaveChanges();
        }

        public IEnumerable<EmpInfo> GetAllEmpInfo()
        {
            return _dbContext.Employees.ToList();
        }

        // Add other repository methods as needed
    }
}
