// See https://aka.ms/new-console-template for more information


using Linq;
using System.Collections.Generic;

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
    todos = todos.Where(t=>t.userId==u.id).ToList(),
    posts = posts.Where(p=>p.userId)

}).ToList();

var selectedPosts = posts.Select(p => new {
    id=p.id,
    comments = comments.Where(c => c.postId == p.id).ToList(),
} ).ToList();

var selectedComments = (from u in users
                        join t in todos 
                        on u.id equals t.userId
                       join p in posts
                       on u.id equals p.userId
                       join c in comments
                       on p.id equals c.postId
                        select new
                        {
                            id = u.id,
                            todos =t,
                            posts = p,

                        }).ToList();




Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
