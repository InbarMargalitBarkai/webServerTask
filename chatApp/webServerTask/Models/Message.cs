namespace webServerTask.Models
{
    public class Message
    {
        public int Id { get; set; }
        public User SentBy { get; set; }
        public User SentTo { get; set; }
        public string Content { get; set; }
        public DateTime SendingTime { get; set; }

    }
}
