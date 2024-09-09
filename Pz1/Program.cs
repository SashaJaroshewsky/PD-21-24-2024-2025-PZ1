using Pz1.TaskSystem;

namespace Pz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TasksController controller = new TasksController();
            controller.Start();
        }

    }
}
