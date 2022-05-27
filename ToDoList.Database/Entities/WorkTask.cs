using System;

namespace ToDoList.Database
{
    public class WorkTask
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
