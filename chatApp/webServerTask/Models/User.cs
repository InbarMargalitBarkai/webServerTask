using Microsoft.AspNetCore.Identity;

namespace webServerTask.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Message = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
