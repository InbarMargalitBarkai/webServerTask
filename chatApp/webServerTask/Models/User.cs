namespace webServerTask.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

        public List<Contact?>? Contacts { get; set; }

        //public User() { }


        //public User(int id, string Uname, string Nname, string password)
        //{
        //    this.Id = id;
        //    this.Username = Uname;
        //    this.Nickname = Nname;
        //    this.Password = password;
        //    if (this.Id <= 0)
        //    {
        //        throw new ArgumentException(
        //            "The Id has to be positive real number.");
        //    }
        //}
        //public User(int id, string Uname, string Nname, string password, List<Contact?>? contacts) {
        //    this.Id = id;
        //    this.Username = Uname;
        //    this.Nickname = Nname;
        //    this.Password = password;
        //    this.Contacts = contacts;

        //    if (this.Id <= 0) {
        //        throw new ArgumentException(
        //            "The Id has to be positive real number.");
        //    }
        //}
    }
}