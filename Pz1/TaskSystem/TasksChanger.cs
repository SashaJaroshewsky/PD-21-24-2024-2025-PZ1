using Pz1.InputSystem;
using Pz1.TaskSystem.Tasks;

namespace Pz1.TaskSystem
{
    internal class TasksChanger
    {
        private ITaskeable _currentTaskeable;

        public TasksChanger()
        {
            _currentTaskeable = new Task1();
        }

        public void ChangeAndStartTask(InputType taskType)
        {
            switch (taskType)
            {
                case InputType.Task1:
                    _currentTaskeable?.StopTask();
                    _currentTaskeable = new Task1Constructor().ChooseAndStartStrategy();
                    break;
                case InputType.Task2:
                    _currentTaskeable?.StopTask();
                    _currentTaskeable = new Task2();
                    _currentTaskeable.StartTask();
                    break;
                default:
                    Console.WriteLine("There is no such task");
                    break;
            }
        }

        
    }
}
