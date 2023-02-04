namespace TodosApp.Models;

public class Todos
{
    public int Id {get; set;}
    public string? Title {get; set;}
    public string? Description {get; set;}
    public DateTime CreatedAt {get; set;}
    public bool Completed {get; set;}
}
