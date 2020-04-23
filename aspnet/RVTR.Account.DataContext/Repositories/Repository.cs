using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RVTR.Account.ObjectModel.Abstracts;
// using System.Web.ModelBinding;

namespace RVTR.Account.DataContext.Repositories
{
  public class Repository<TEntity> : IRepository<TEntity> where TEntity : class //, ApiController
  {
    private readonly DbContext _db;
    
    public bool Delete(int id)
    {
      if (true)
      {
        //do something
      }
      //do something else
      return true;
    }


    public bool Insert(TEntity entity) // validatable
    {
      // if(ModelState.IsValid()) // TODO: validate
      // {
        _db.Set<TEntity>().Add(entity);
        return true;
      // }
      // else
      // {
      //   // throw new System.ArgumentException("Parameter cannot be null", "original");
      //   return false;
      // }
    }

    public IEnumerable<TEntity> Select() => throw new System.NotImplementedException();

    // public IEnumerable<TEntity> Select<TEntity>(int id) where TEntity : class
    // {
    //   return _db.Set<TEntity>().SingleOrDefault();   
    // }

    public TEntity Select(int id)
    {
      throw new System.NotImplementedException();
    }

    public bool Update(TEntity entity) => throw new System.NotImplementedException();
  }
}
