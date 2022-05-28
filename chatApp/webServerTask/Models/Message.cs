namespace webServerTask.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string SentBy { get; set; }
        public string Content { get; set; }
        public DateTime SendingTime { get; set; }

    }
}
