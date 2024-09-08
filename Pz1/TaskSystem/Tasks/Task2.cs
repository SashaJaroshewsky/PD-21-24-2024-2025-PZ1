
namespace Pz1.TaskSystem.Tasks
{
    internal class Task2 : ITaskeable
    {
        public void StartTask()
        {
            Console.WriteLine("Start Task2");
        }

        public void StopTask()
        {
            Console.Clear();
        }
    }
}
