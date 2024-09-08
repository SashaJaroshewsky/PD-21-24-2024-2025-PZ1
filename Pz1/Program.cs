using Pz1.Task;

namespace Pz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 task1 = new Task1();
            //task1.StartTask();

            IBaseTask task1 = new Task1();
            IBaseTask task2 = new Task2();

            task1.StartTask();
            task2.StartTask();

            IBaseTask[] baseTasks = { task1, task2 };

            foreach (var task in baseTasks) 
            { 
                task.StartTask();
            }

        }

    }
}
