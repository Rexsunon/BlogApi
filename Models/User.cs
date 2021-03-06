using System.Collections.Generic;

namespace Blog_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Post> Posts { get; set; }
    }
}