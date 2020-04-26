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
    private static readonly UnitOfWork system; // DBMS hooks
    
    private readonly ILogger<AccountDetailsController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public AccountDetailsController(ILogger<AccountDetailsController> logger, IUnitOfWork unitOfWork)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<AccountDetails> Get()
    {
      return await Task.FromResult<AccountDetails>(new AccountDetails());
    }
    [HttpPost]
    public async Task<AccountModel> Post(AccountModel account) // TODO: Change to async task.await
    {
      // return await Task.FromResult<AccountModel>(new AccountModel());
      return await Task.FromResult<AccountModel>(account);
    }
  }
}
