using TodosApp.Models;
namespace TodosApp.Service;

public static class TodoService
{
    static List<Todos>? Todo {get;}
    static int IdNext = 3;
    static TodoService(){
        Todo = new List<Todos>
        {
            new Todos {Id=1, Title="Belajar", Description="Selesein .net", CreatedAt=DateTime.Now, Completed=false},
            new Todos {Id=2, Title="Makan", Description="Makan Bakso", CreatedAt=DateTime.Now, Completed=false}
        };
    }

    public static List<Todos>? GetAll() => Todo;
    public static Todos? Get(int id) => Todo.FirstOrDefault(p=> p.Id == id);
    public static void Add(Todos todos)
    {
        todos.Id = IdNext++;
        Todo.Add(todos);
    }
    public static void Delete(int id)
    {
        var todo = Get(id);
        if (todo is null)
            return;

        Todo.Remove(todo);
    }
    public static void Update(Todos todos)
    {
        var index = Todo.FindIndex(p => p.Id == todos.Id);
        if (index == -1)
            return;

        Todo[index] = todos;
    }
    
}