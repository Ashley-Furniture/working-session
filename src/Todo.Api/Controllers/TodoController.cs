using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private readonly ILogger _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = nameof(GetAllTodos))]
    public Task<IActionResult> GetAllTodos()
    {
        return Task.FromResult<IActionResult>(Ok(Enumerable.Empty<Models.Todo>()));
    }

    [HttpGet("{id}", Name = nameof(GetTodoForId))]
    public Task<IActionResult> GetTodoForId(long id)
    {
        Models.Todo todo = new(id, string.Empty, string.Empty, false);

        return Task.FromResult<IActionResult>(Ok(todo));
    }

    [HttpPost("{id}", Name = nameof(PostTodo))]
    public Task<IActionResult> PostTodo(long id, [FromBody] Models.Todo todo)
    {
        return Task.FromResult<IActionResult>(Ok(todo));
    }

    [HttpPut("{id}", Name = nameof(PutTodo))]
    public Task<IActionResult> PutTodo(long id, [FromBody] Models.Todo todo)
    {
        var created = todo with { Id = DateTime.UtcNow.Ticks };

        return Task.FromResult<IActionResult>(Ok(created));
    }
}