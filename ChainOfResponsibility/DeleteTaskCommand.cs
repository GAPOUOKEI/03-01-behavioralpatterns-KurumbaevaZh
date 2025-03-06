using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class DeleteTaskCommand : ICommand
    {
        private readonly TaskManager _taskManager;
        private readonly string _taskName;

        public DeleteTaskCommand(TaskManager taskManager, string taskName)
        {
            _taskManager = taskManager;
            _taskName = taskName;
        }

        public void Execute()
        {
            _taskManager.RemoveTask(_taskName);
        }

        public void Undo()
        {
            _taskManager.AddTask(_taskName);
        }
    }
}
