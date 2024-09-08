using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1.Task
{
    internal class Task2: ITaskeable
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
