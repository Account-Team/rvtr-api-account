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
  public class AccountDetailsController : ControllerBase
  {
    private readonly HttpClient _http = new HttpClient();
    AccountDbContext dbContext;    
    private readonly ILogger<AccountDetailsController> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private Repository<AccountDetails> AccountDetailsRepository;

    public AccountDetailsController(ILogger<AccountDetailsController> logger, IUnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// HTTP 'Get' method for AccountModel service
    /// </summary>
    /// <returns>List of all AccountModel objects</returns>
    [HttpGet]
    public async Task<IEnumerable<AccountDetails>> Get()
    {
      return await Task.FromResult<IEnumerable<AccountDetails>>(_unitOfWork.AccountDetailsRepository.Select());
    }
    /// <summary>
    /// HTTP 'Get' method for AccountModel lookup
    /// </summary>
    /// <param name="id"></param>
    /// <returns>AccountModel object/returns>
    [HttpGet("{id}")]
    public async Task<AccountDetails> Get(int id)
    {
      return await Task.FromResult<AccountDetails>(_unitOfWork.AccountDetailsRepository.Select(id));
    }

    /// <summary>
    /// HTTP 'Post' method for AccountModel service
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Returns an action result describing the post action</returns>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody]AccountDetails model)
    {
      var success = await Task.FromResult<bool>(_unitOfWork.AccountDetailsRepository.Insert(model));
      if (success)
      {
        return Ok();
      }
      return BadRequest();
    }
  }
}
