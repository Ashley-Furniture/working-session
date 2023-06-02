namespace Todo.Api.Models;

public record Todo(long Id, string Name, string Description, bool IsCompleted);