using System;
namespace minialapi2.Requests
{
    public class TestRequest:IAppRequest
    {
        public int Age { get; set; }
        public string? Name { get; set; }
    }
}

