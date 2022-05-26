using Microsoft.AspNetCore.Identity;

namespace webServerTask.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        List<Conversation> Conversations { get; set; }
        List<User> Contacts { get; set; }
            
    }
}
