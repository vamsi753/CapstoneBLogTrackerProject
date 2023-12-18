using Microsoft.EntityFrameworkCore;

public class BlogTrackerDbContext : DbContext
{
    public DbSet<AdminInfo> Admins { get; set; }
    public DbSet<EmpInfo> Employees { get; set; }
    public DbSet<BlogInfo> Blogs { get; set; }

    // Add constructor and other configurations as needed
}