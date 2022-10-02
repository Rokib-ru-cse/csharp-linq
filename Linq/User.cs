using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

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
            StreamReader r = new StreamReader("D:\\project\\Linq\\Linq\\JsonFiles\\users.json");
            var jsonusers = r.ReadToEnd();
            users = JsonConvert.DeserializeObject<List<User>>(jsonusers);
            return users;
        }

    }
}
