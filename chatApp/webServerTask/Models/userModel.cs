namespace webServerTask.Models
{
    public class userModel
    {

        public static void addUser(string name, string nick, string pass) {
            using (var db = new webServerTaskContext()) {
                List<Contact> optionList = new List<Contact>();
                User u = new User(1, name, nick, pass, optionList);
                db.User.Add(u);
                db.SaveChanges();
            }
        }
    }
}
