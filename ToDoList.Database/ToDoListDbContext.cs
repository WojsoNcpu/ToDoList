using Microsoft.EntityFrameworkCore;

namespace ToDoList.Database
{
    public class ToDoListDbContext : DbContext
    {
        public DbSet<WorkTask> WorkTasks { get; set; }
    }
}
