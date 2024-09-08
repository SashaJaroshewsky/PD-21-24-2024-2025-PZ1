using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1.Task
{
    internal class InputController
    {
        public TaskType Input()
        {
            int inputNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter number 1-2: ");
                Console.WriteLine("Press 1 - Task1");
                Console.WriteLine("Press 2 - Task2");
                Console.WriteLine("Press \"0\" to exit");

            }
            while (!int.TryParse(Console.ReadLine(), out inputNumber) || !IsWithinRange(inputNumber, 0, 2));

            switch (inputNumber)
            {
                case 0:
                    return TaskType.Exit;
                case 1:
                    return TaskType.Task1;
                case 2:
                    return TaskType.Task2;
                default:
                    return TaskType.None;
            }
        }

        bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    }
}
