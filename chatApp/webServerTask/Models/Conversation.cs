namespace webServerTask.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        List<Message> Messages { get; set; }
        List<User> Participants { get; set; }
        public Message LastMessage { get; set; }
    }
}
