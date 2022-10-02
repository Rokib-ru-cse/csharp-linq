using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            StreamReader r = new StreamReader("D:\\project\\Linq\\Linq\\JsonFiles\\comments.json");
            var jsoncomments = r.ReadToEnd();
            comments = JsonConvert.DeserializeObject<List<Comment>>(jsoncomments);
            return comments;
        }
    }
}
