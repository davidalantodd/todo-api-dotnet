using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

//creating a database context
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {

    }
    public DbSet<TodoItem> TodoItems { get; set; } = null;
}