namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            ICommand createTask1 = new CreateTaskCommand(taskManager, "Разработать дизайн");
            ICommand createTask2 = new CreateTaskCommand(taskManager, "Написать код");

            ICommand updateTask = new UpdateTaskCommand(taskManager, "Разработать дизайн", "Разработать UI/UX");

            ICommand deleteTask = new DeleteTaskCommand(taskManager, "Написать код");

            taskManager.ExecuteCommand(createTask1);
            taskManager.ExecuteCommand(createTask2);
            taskManager.ShowTasks();

            taskManager.ExecuteCommand(updateTask);
            taskManager.ShowTasks();

            taskManager.ExecuteCommand(deleteTask);
            taskManager.ShowTasks();

            taskManager.UndoLastCommand();
            taskManager.ShowTasks();
        }
    }
}
