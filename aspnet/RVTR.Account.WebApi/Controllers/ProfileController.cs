using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RVTR.Account.DataContext.Repositories;
using RVTR.Account.ObjectModel.Models;
using System.Net.Http;
using RVTR.Account.DataContext;

namespace RVTR.Account.WebApi.Controllers
{
  [ApiController]
  [EnableCors()]
  [Route("[controller]")]
  public class ProfileController : ControllerBase
  {
    private readonly HttpClient _http = new HttpClient();

    AccountDbContext dbContext;
    private static readonly UnitOfWork system; // DBMS hooks
    
    private readonly ILogger<ProfileController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public ProfileController(ILogger<ProfileController> logger, IUnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<Profile> Get()
    {
      return await Task.FromResult<Profile>(new Profile());
    }
    [HttpPost]
    public async Task<Profile> Post(Profile profile) 
    {
      return await Task.FromResult<Profile>(profile);
    }
  }
}
