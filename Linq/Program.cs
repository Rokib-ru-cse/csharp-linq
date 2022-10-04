// See https://aka.ms/new-console-template for more information


using Linq;

var comments = Comment.GetComments();
var posts = Post.GetPosts();
var todos = Todo.GetTodos();
var users = User.GetUsers();

var filteredUser = users.Select(u => new /*User*/
{
    id = u.id,
    name = u.name,
    email = u.email,
    phone = u.phone,
    username = u.username,
    website = u.website,
    company = u.company,
    address = u.address,
    todos = todos.Where(t => t.userId == u.id).ToList(),
    posts = posts.Where(p => p.userId == u.id).Select(p => new /*Post*/
    {
        id = p.id,
        userId = p.userId,
        title = p.title,
        body = p.body,
        comments = comments.Where(c => c.postId == p.id).ToList()
    }).ToList()

}).ToList();






Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
