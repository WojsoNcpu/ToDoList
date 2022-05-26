using ToDoList.Core;
using Xamarin.Forms;

namespace ToDoList.Mobile
{
    public partial class WorkTaskPage : ContentPage
    {
        public WorkTaskPage()
        {
            InitializeComponent();

            BindingContext = new WorkTasksPageViewModel();
        }
    }
}