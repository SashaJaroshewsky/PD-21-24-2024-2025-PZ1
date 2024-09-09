
using Pz1.InputSystem;

namespace Pz1.TaskSystem
{
    internal class TasksController
    {
        private InputController _inputController;
        private TasksChanger _tasksChanger;

        public TasksController()
        {
            _inputController = new InputController();
            _tasksChanger = new TasksChanger();
        }
        public void Start()
        {
            InputType taskType = _inputController.Input();
            while (taskType != InputType.Exit)
            {
                _tasksChanger.ChangeAndStartTask(taskType);
                Console.WriteLine();
                Console.WriteLine("Press Enter to select another task");
                Console.ReadLine();
                taskType = _inputController.Input();
            }
        }
    }
}
