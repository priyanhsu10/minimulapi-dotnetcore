using System;
using minialapi2.Interfaces;
using minialapi2.Requests;
using minialapi2.Todos.Requests;

namespace minialapi2.Repositories
{
    //public class TodoRepository:IRepository<Todo,Guid>
    //{
    //    private static Dictionary<Guid, Todo> todos = new();
      
      
    //    public TodoRepository()
    //    {
    //    }

    //    public async Task<Todo> Create(Todo todo)
    //    {
            
    //        todos.Add(todo.Id, todo);
    //        return todo;
    //    }

    //    public async Task Delete(Guid id)
    //    {
    //        if (todos.ContainsKey(id))
    //        {
    //            todos.Remove(id);
    //            return;
    //        }
    //        throw new Exception("invalid todo item");
    //    }

    //    public async Task<List<Todo>> getAll()
    //    {
    //        return todos.Values.ToList();
    //    }

    //    public async Task<Todo> Update(Guid id, Todo todo)
    //    {
    //        if (todos.ContainsKey(id))
    //        {
    //            todos[id] = todo;
    //            return todo;
    //        }
    //        throw new Exception("invalid todo item");
    //    }
    //}
}

