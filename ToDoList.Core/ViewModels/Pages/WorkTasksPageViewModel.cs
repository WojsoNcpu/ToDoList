using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ToDoList.Database;

namespace ToDoList.Core
{
    public class WorkTasksPageViewModel : BaseViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();

        public string NewWorkTaskTitle { get; set; }

        public string NewWorkTaskDescription { get; set; }

        public ICommand AddNewTaskCommand { get; set; }
        public ICommand DeleteSelectedTasksCommand { get; set; }

        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteSelectedTasksCommand = new RelayCommand(DeleteSelectedTasks);

            foreach( var task in DatabaseLocator.Database.WorkTasks.ToList())
            {
                WorkTaskList.Add(new WorkTaskViewModel
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    CreatedDate = task.CreatedDate,
                });
            }
        }

        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
            };

            WorkTaskList.Add(newTask);

            DatabaseLocator.Database.WorkTasks.Add(new WorkTask
            {
               Title = newTask.Title,
               Description = newTask.Description,
               CreatedDate = newTask.CreatedDate,
            });

            DatabaseLocator.Database.SaveChanges();

            NewWorkTaskTitle = string.Empty;
            NewWorkTaskDescription = string.Empty;
        }

        private void DeleteSelectedTasks()
        {
            var selectedTasks = WorkTaskList.Where(x => x.IsSelected).ToList();

            foreach (var task in selectedTasks)
            {
                WorkTaskList.Remove(task);

                var foundEntity = DatabaseLocator.Database.WorkTasks.FirstOrDefault(x => x.Id == task.Id);
                if(foundEntity != null)
                {
                    DatabaseLocator.Database.WorkTasks.Remove(foundEntity);
                }
            }

            DatabaseLocator.Database.SaveChanges();
        }
    }
}
