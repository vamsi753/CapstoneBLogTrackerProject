// EmpInfoController.cs
using BlogTracker.DAL.Repositories;
using BlogTracker.DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;

[Route("api/[controller]")]
[ApiController]
public class EmpInfoController : ControllerBase
{
    private readonly EmpInfoRepository _empInfoRepository;

    public EmpInfoController(EmpInfoRepository empInfoRepository)
    {
        _empInfoRepository = empInfoRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<EmpInfo>> Get()
    {
        var employees = _empInfoRepository.GetAllEmpInfo();
        return Ok(employees);
    }

   
}
