echo "
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
  [Route(\"[controller]\")]
  public class $1Controller : ControllerBase
  {
    private readonly HttpClient _http = new HttpClient();
    AccountDbContext dbContext;    
    private readonly ILogger<$1Controller> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private Repository<$1> $1Repository;

    public $1Controller(ILogger<$1Controller> logger, IUnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// HTTP 'Get' method for $1 service
    /// </summary>
    /// <returns>List of all $1 objects</returns>
    [HttpGet]
    public async Task<IEnumerable<$1>> Get()
    {
      return await Task.FromResult<IEnumerable<$1>>(_unitOfWork.$1Repository.Select());
    }
    /// <summary>
    /// HTTP 'Get' method for $1 lookup
    /// </summary>
    /// <param name="id"></param>
    /// <returns>$1 object/returns>
    [HttpGet("{id}")]
    public async Task<$1> Get(int id)
    {
      return await Task.FromResult<$1>(_unitOfWork.AccountModelRepository.Select(id));
    }

    /// <summary>
    /// HTTP 'Post' method for $1 service
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Returns an action result describing the post action</returns>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody]$1 model)
    {
      var success = await Task.FromResult<bool>(_unitOfWork.$1Repository.Insert(model));
      if (success)
      {
        return Ok();
      }
      return BadRequest();
    }
  }
}
"