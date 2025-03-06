using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class TaskManager
    {
        private readonly List<string> _tasks = new List<string>();
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public void AddTask(string taskName)
        {
            _tasks.Add(taskName);
            Console.WriteLine($"Задача \"{taskName}\" добавлена.");
        }

        public void UpdateTask(string oldTask, string newTask)
        {
            if (_tasks.Contains(oldTask))
            {
                _tasks[_tasks.IndexOf(oldTask)] = newTask;
                Console.WriteLine($"Задача \"{oldTask}\" обновлена на \"{newTask}\".");
            }
            else
            {
                Console.WriteLine($"Задача \"{oldTask}\" не найдена.");
            }
        }

        public void RemoveTask(string taskName)
        {
            if (_tasks.Remove(taskName))
            {
                Console.WriteLine($"Задача \"{taskName}\" удалена.");
            }
            else
            {
                Console.WriteLine($"Задача \"{taskName}\" не найдена.");
            }
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_history.Count > 0)
            {
                ICommand lastCommand = _history.Pop();
                lastCommand.Undo();
                Console.WriteLine("Отмена последнего действия.");
            }
            else
            {
                Console.WriteLine("История пуста.");
            }
        }

        public void ShowTasks()
        {
            Console.WriteLine("\nСписок задач:");
            if (_tasks.Count == 0)
            {
                Console.WriteLine("   (пусто)");
            }
            else
            {
                foreach (var task in _tasks)
                {
                    Console.WriteLine($"   - {task}");
                }
            }
            Console.WriteLine();
        }
    }
}
