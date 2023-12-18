// Startup.cs
using BlogTracker.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

public void ConfigureServices(IServiceCollection services)
{
    // Other configurations...

    services.AddScoped<EmpInfoRepository>();
    services.AddScoped<BlogInfoRepository>();
}
