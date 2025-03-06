using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class UpdateTaskCommand : ICommand
    {
        private readonly TaskManager _taskManager;
        private readonly string _oldTask;
        private readonly string _newTask;

        public UpdateTaskCommand(TaskManager taskManager, string oldTask, string newTask)
        {
            _taskManager = taskManager;
            _oldTask = oldTask;
            _newTask = newTask;
        }

        public void Execute()
        {
            _taskManager.UpdateTask(_oldTask, _newTask);
        }

        public void Undo()
        {
            _taskManager.UpdateTask(_newTask, _oldTask);
        }
    }
}
