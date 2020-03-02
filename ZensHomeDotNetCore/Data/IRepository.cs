using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZensHomeDotNetCore.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
