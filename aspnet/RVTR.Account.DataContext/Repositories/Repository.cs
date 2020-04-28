using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using RVTR.Account.ObjectModel.Abstracts;

namespace RVTR.Account.DataContext.Repositories
{
  public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    private readonly DbContext _db;

    public Repository() { }
    public Repository(DbContext db)
    {
      _db = db;
    }

    // Class Methods

    public IEnumerable<TEntity> Select()  // Return All Records
    {
      return (IEnumerable<TEntity>)_db.Set<TEntity>();
    }

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
  }
}
