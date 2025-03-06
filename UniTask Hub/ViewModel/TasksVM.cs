using System.Windows.Input;
using UniTask_Hub.Model;
using UniTask_Hub.Utilities;
using System;
using UniTask_Hub.View;
using System.Collections.ObjectModel;

namespace UniTask_Hub.ViewModel
{
    class TasksVM : Utilities.ViewModelBase
    {
        // Use ObservableCollection to bind to the UI
        public ObservableCollection<PageModel> Tasks { get; set; } = new ObservableCollection<PageModel>();

        // Properties for binding to the UI
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskDeadline { get; set; }

        // Command for adding a task
        public ICommand AddTaskCommand { get; }
        public ICommand EditTaskCommand { get; }

        public TasksVM()
        {
            // Define the command and associate it with the AddTask method
            AddTaskCommand = new RelayCommand(AddTask);
            EditTaskCommand = new RelayCommand(EditTask);

            // Load existing tasks (if any)
            LoadTasks();
        }

        // Method for adding a task
        private void AddTask(object parameter)
        {
            if (!string.IsNullOrWhiteSpace(TaskTitle) && !string.IsNullOrWhiteSpace(TaskDescription))
            {
                var newTask = new PageModel
                {
                    title = TaskTitle,
                    description = TaskDescription,
                    deadline = TaskDeadline  // Assuming 'deadline' is a property of PageModel
                };

                // Save the task to the database
                SqliteDataAccess.SaveTask(newTask);

                // Add to ObservableCollection to update UI
                Tasks.Add(newTask);

                // Reset the input fields
                TaskTitle = string.Empty;
                TaskDescription = string.Empty;
                TaskDeadline = string.Empty;  // Reset the deadline if you want
            }
        }

        private void EditTask(object parameter)
        {
            var taskToEdit = parameter as PageModel;

            if (taskToEdit != null)
            {
                var editWindow = new EditTaskWindow(taskToEdit);

                if (editWindow.ShowDialog() == true)
                {
                    //taskToEdit.title = editWindow.Task.title;
                    //taskToEdit.description = editWindow.Task.description;

                    SqliteDataAccess.UpdateTask(taskToEdit);

                    OnPropertyChanged(nameof(Tasks));
                }

                LoadTasks();
                OnPropertyChanged(nameof(Tasks));
            }
        }

        // Method for loading tasks from the database
        private void LoadTasks()
        {
            // Clear the existing tasks
            Tasks.Clear();

            // Get tasks from the database
            var loadedTasks = SqliteDataAccess.AddTasks();
            foreach (var task in loadedTasks)
            {
                // Add tasks to the ObservableCollection
                Tasks.Add(task);
            }
        }
    }
}
