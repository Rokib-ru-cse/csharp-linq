using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Todo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

        public static List<Todo> GetTodos()
        {
            List<Todo> todos = new List<Todo>();
            StreamReader r = new StreamReader("D:\\project\\Linq\\Linq\\JsonFiles\\todos.json");
            var jsoncomments = r.ReadToEnd();
            todos = JsonConvert.DeserializeObject<List<Todo>>(jsoncomments);
            return todos;
        }


    }
}
