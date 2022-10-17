using Newtonsoft.Json;

namespace Linq
{
    public class Comment
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        public static List<Comment> GetComments()
        {
            List<Comment> comments = new List<Comment>();
            string path = Environment.CurrentDirectory;
            var relation = @"..\..\..\..\JsonFiles\";
            StreamReader r = new StreamReader(Path.Combine(path + relation + "comments.json"));
            var jsoncomments = r.ReadToEnd();
            comments = JsonConvert.DeserializeObject<List<Comment>>(jsoncomments);
            return comments;
        }
    }
}
