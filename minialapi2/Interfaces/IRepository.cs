using System;

namespace minialapi2.Interfaces
{
    public interface IEntity<ID> where ID :struct
    {
         ID Id { get; set; }
    }
    public interface IRepository<T,ID> where T : class, new() where ID:  struct
    {
        Task<T> Create(T t);
        Task<T> Update(T t);
        Task Delete(ID id);
        Task<List<T>> getAll();

    }
}

