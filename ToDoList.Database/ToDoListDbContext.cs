//using Microsoft.EntityFrameworkCore;
//using System.IO;

//namespace ToDoList.Database
//{
//    public class ToDoListDbContext : DbContext
//    {
//        public DbSet<WorkTask> WorkTasks { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            base.OnConfiguring(optionsBuilder);

//            optionsBuilder.UseSqlite($"Filename={Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "toDoListApp.sqlite")}");
//        }
//    }
//}
