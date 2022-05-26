using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Core
{
    public class DatabaseLocator
    {
        public static ToDoListDbContext Database { get; set; } 
    }
}
