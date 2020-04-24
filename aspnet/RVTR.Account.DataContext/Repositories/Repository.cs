using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using RVTR.Account.ObjectModel.Abstracts;
// using System.Web.ModelBinding;

namespace RVTR.Account.DataContext.Repositories
{
  public class Repository<TEntity> : IRepository<TEntity> where TEntity : class //, ApiController
  {
    private readonly DbContext _db;

    //  IEnumerable<TEntity> IRepository<TEntity>.Select => throw new System.NotImplementedException(); // wtf let's get rid of this

    public Repository(DbContext db)
    {
      _db = db;
    }
    public bool Delete(int id)
    {
      var entity = this.Select(id);
      var context = new ValidationContext(entity, null, null);
      var results = new List<ValidationResult>();

      if (Validator.TryValidateObject(entity, context, results, true))
      {
        _db.Set<TEntity>().Remove(entity);
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool Insert(TEntity entity)
    {
      var context = new ValidationContext(entity, null, null);
      var results = new List<ValidationResult>();
      
      if (Validator.TryValidateObject(entity, context, results, true))
      {
        _db.Set<TEntity>().Add(entity);
        return true;
      }
      else
      {
        return false;
      }
    }

    public IEnumerable<TEntity> Select() => (IEnumerable<TEntity>)_db.Set<TEntity>().ToListAsync(); // Return All Records

    public TEntity Select(int id)
    {
      return _db.Set<TEntity>().Find(id); // id is the PK on the table
    }

    public bool Update(TEntity entity)
    {
      var context = new ValidationContext(entity, null, null);
      var results = new List<ValidationResult>();
      
      if (Validator.TryValidateObject(entity, context, results, true))
      {
        _db.Set<TEntity>().Update(entity);
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
