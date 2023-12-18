// BlogInfoController.cs
using BlogTracker.DAL.Repositories;
using BlogTracker.DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;

[Route("api/[controller]")]
[ApiController]
public class BlogInfoController : ControllerBase
{
    private readonly BlogInfoRepository _blogInfoRepository;

    public BlogInfoController(BlogInfoRepository blogInfoRepository)
    {
        _blogInfoRepository = blogInfoRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<BlogInfo>> Get()
    {
        var blogs = _blogInfoRepository.GetAllBlogInfo();
        return Ok(blogs);
    }

    
}
