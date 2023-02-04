using TodosApp.Models;
using TodosApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace TodosApp.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    public TodoController(){}
    [HttpGet]
    public ActionResult<List<Todos>> GetAll() => TodoService.GetAll();
    
}
