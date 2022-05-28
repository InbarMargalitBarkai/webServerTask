namespace webServerTask.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nickname { get; set; }
        public Conversation Conversation { get; set; }

    }
}
