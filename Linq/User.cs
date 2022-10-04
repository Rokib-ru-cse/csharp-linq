using Newtonsoft.Json;

namespace Linq
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            string path = Environment.CurrentDirectory;
            var relation = @"..\..\..\..\JsonFiles\";
            StreamReader r = new StreamReader(Path.Combine(path + relation + "users.json"));
            var jsonusers = r.ReadToEnd();
            users = JsonConvert.DeserializeObject<List<User>>(jsonusers);
            return users;
        }

    }
}
