using Newtonsoft.Json;

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
            string path = Environment.CurrentDirectory;
            var relation = @"..\..\..\..\JsonFiles\";
            StreamReader r = new StreamReader(Path.Combine(path + relation + "todos.json"));
            var jsoncomments = r.ReadToEnd();
            todos = JsonConvert.DeserializeObject<List<Todo>>(jsoncomments);
            return todos;
        }


    }
}
