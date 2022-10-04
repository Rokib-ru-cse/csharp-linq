using Newtonsoft.Json;

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
            string path = Environment.CurrentDirectory;
            var relation = @"..\..\..\..\JsonFiles\";
            StreamReader r = new StreamReader(Path.Combine(path + relation + "posts.json"));
            var jsoncomments = r.ReadToEnd();
            posts = JsonConvert.DeserializeObject<List<Post>>(jsoncomments);
            return posts;
        }
    }
}
