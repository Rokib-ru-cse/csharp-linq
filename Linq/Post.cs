using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public static List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();
            StreamReader r = new StreamReader("D:\\project\\Linq\\Linq\\JsonFiles\\posts.json");
            var jsoncomments = r.ReadToEnd();
            posts = JsonConvert.DeserializeObject<List<Post>>(jsoncomments);
            return posts;
        }
    }
}
