using ToDoList.Database;

namespace ToDoList.Core
{
    public class DatabaseLocator
    {
        public static ToDoListDbContext Database { get; set; }
    }
}