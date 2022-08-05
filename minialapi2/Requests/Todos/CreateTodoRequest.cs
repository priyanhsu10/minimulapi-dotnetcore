using System;
using minialapi2.Requests;

namespace minialapi2.Todos.Requests
{
    public class CreateTodoRequest:IAppRequest
    {
        public string title { get; set; }
        public int Minutes { get; set; }
        public string Decrption { get; set; }
    }
}

