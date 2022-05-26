using Microsoft.AspNetCore.Identity;

namespace webServerTask.Models
{
    public class User
    {
        private int Id;
        private string Username;
        private string Nickname;
        private string Password;
        private List<Conversation> Conversations;
        private List<User> Contacts;

        public User() { }

        public User(int Id, string Username, string Nickname, string Password,
            List<Conversation>? Conversations = null, List<User>? Contacts = null)
        {
            this.Id = Id;
            this.Username = Username;
            this.Nickname = Nickname;
            this.Password = Password;
            this.Conversations = Conversations;
            this.Contacts = Contacts;

            if (this.Id <= 0)
            {
                throw new ArgumentException(
                    "The Id has to be positive real number.");
            }

            if (Conversations == null)
            {
                Conversations = "No description.";
            }

            this.description = description;

            if (imagePath == null)
            {
                imagePath = "default.png";
            }

            this.imagePath = imagePath;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

    }
}
