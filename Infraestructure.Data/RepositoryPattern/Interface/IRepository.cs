using System.Collections.Generic;
using Domain.Entities.Models.Base;

namespace Infraestructure.RepositoryPattern.Interface
{
    public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
