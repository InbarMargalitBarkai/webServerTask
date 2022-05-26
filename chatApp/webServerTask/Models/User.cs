namespace webServerTask.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public List<Conversation> Conversations { get; set; }
        public List<User> Contacts { get; set; }
    }
}