using System;
using minialapi2.Requests;

namespace minialapi2.Requests
{
    public class TodoRequest:IAppRequest
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int Minutes { get; set; }
        public string Decrption { get; set; }

    }
}

