using TaskGestionAPI.Models;
using Microsoft.EntityFrameworkCore;
using Task = TaskGestionAPI.Models.Task;

namespace TaskGestionAPI.Data;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {
    }
    
    public DbSet<Task> Tasks { get; set; }
}