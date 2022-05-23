using System.ComponentModel.DataAnnotations;

namespace webServerTask.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime when { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}
