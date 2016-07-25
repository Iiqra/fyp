using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        int Create(T entity);
        int Delete(int id);
        int Update(T entity);
        T FindById(int Id);
    }
}
