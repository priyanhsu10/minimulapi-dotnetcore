using minialapi2.Interfaces;

namespace minialapi2.Requests
{
    public class Todo :IEntity<int>
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int Minutes { get; set; }
        public string Decrption { get; set; }

    }
}

