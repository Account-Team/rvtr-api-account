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
  public class AccountController : ControllerBase
  {
    private readonly HttpClient _http = new HttpClient();

    AccountDbContext dbContext;
    private static readonly UnitOfWork system; // DBMS hooks
    
    private readonly ILogger<AccountController> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private Repository<AccountModel> AccountModelRepository;

    public AccountController(ILogger<AccountController> logger, IUnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// HTTP 'Get' method for AccountModel service
    /// </summary>
    /// <returns>List of all AccountModel objects</returns>
    [HttpGet]
    public async Task<IEnumerable<AccountModel>> Get()
    {
      // TODO: fetch accounts from the database
      // return await Task.FromResult<AccountModel>(new AccountModel());
      return await Task.FromResult<IEnumerable<AccountModel>>(_unitOfWork.AccountModelRepository.Select());
      // return await Task.FromResult<IEnumerable<AccountModel>>(system.AccountModelRepository.Select());
    }
    /// <summary>
    /// HTTP 'Get' method for AccountModel lookup
    /// </summary>
    /// <param name="id"></param>
    /// <returns>AccountModel object/returns>
    [HttpGet("{id}")]
    public async Task<AccountModel> Get(int id)
    {
      return await Task.FromResult<AccountModel>(_unitOfWork.AccountModelRepository.Select(id));
    }

    // /// <summary>
    // /// HTTP 'Post' method for AccountModel service
    // /// </summary>
    // /// <returns>The AccountModel onject that was inserted into the database</returns>
    // [HttpPost]
    //  public async Task<AccountModel> Post(AccountModel model) 
    // {
    //   AccountModelRepository.Insert(model);
    //   return await Task.FromResult<AccountModel>(model);
    // }
    ///
    /// //////////////////
    /// <summary>
    /// HTTP 'Post' method for AccountModel service
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Returns an action result describing the post action</returns>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody]AccountModel model)
    {
      var success = await Task.FromResult<bool>(_unitOfWork.AccountModelRepository.Insert(model));
      if (success)
      {
        // System.Console.WriteLine("here1");
        return Ok();
      }
      return BadRequest();
    }
  }
}

//////////////////////////////////////////////////////////////////////////////////////

// namespace RVTR.Lodging.WebApi.Controllers
// {

//   /// <summary>
//   /// Api controller for interacting with Lodgings
//   /// </summary>
//   /// <returns>List of Lodgings</returns>
//   [ApiController]
//   [EnableCors()]
//   [Route("[controller]/[action]")]
//   public class LodgingController : ControllerBase
//   {
//     private readonly ILogger<LodgingController> _logger;
//     private readonly IUnitOfWork _unitOfWork;


//     /// <summary>
//     /// Post method for lodging
//     /// </summary>
//     /// <param name="model"></param>
//     /// <returns>Returns an action result describing the post action</returns>
//     [HttpPost]
//     public async Task<IActionResult> Post([FromBody]LodgingModel model)
//     {
//       var success = await Task.FromResult<bool>(_unitOfWork.LodgingRepository.Insert(model));
//       if (success)
//       {
//         return Ok();
//       }
//       return BadRequest();
//     }

//     /// <summary>
//     /// Put method for RentalUnit
//     /// </summary>
//     /// <param name="model"></param>
//     /// <returns>Request success or failure</returns>
//     [HttpPut]
//     public async Task<IActionResult> Put([FromBody]LodgingModel model)
//     {
//       var success = await Task.FromResult<bool>(_unitOfWork.LodgingRepository.Update(model));
//       if (success)
//       {
//         return Ok();
//       }
//       return BadRequest();
//     }

//     /// <summary>
//     /// Delete method for lodgings
//     /// </summary>
//     /// <param name="model"></param>
//     /// <returns>Request success or failure</returns>
//     [HttpDelete("{id}")]
//     public async Task<IActionResult> Delete(int model)
//     {
//       var success = await Task.FromResult<bool>(_unitOfWork.LodgingRepository.Delete(model));
//       if (success)
//       {
//         return Ok();
//       }
//       return BadRequest();
//     }
//   }
// }