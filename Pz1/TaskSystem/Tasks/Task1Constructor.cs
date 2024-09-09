using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1.TaskSystem.Tasks
{
    internal class Task1Constructor
    {
        private Task1 _task1;

        public Task1Constructor()
        {
            _task1 = new Task1();
        }

        public Task1 ChooseAndStartStrategy()
        {
            int input;
            do
            {
                Console.Clear();
                Console.WriteLine("Use random values?");
                Console.WriteLine("1 - yes");
                Console.WriteLine("2 - no");
            }
            while (!int.TryParse(Console.ReadLine(), out input) || !_task1.IsWithinRange(input, 1, 2));

            switch (input)
            {
                case 1:
                    _task1.StartTask();
                    return _task1;
                case 2:
                    int min, max;
                    InputRange(out min, out max);
                    _task1.StartTask(InputArray(), min, max);
                    return _task1;
                default:
                    _task1.StartTask();
                    return _task1;
            }
        }

        private int[] InputArray()
        {
            int[] numbers = new int[_task1.LenghtNumbers];
            for (int i = 0; i < _task1.LenghtNumbers; i++)
            {
                int number;
                InputNumber(out number, nameof(number));
                numbers[i] = number;
            }
            return numbers;
        }

        private void InputRange(out int min, out int max)
        {
            InputNumber(out min, nameof(min));
            InputNumber(out max, nameof(max));
        }

        private void InputNumber(out int number, string a)
        {
            do
            {
                Console.Write($"Enter [{a}] = ");
            } while (!int.TryParse(Console.ReadLine(), out number));
            Console.WriteLine();
        }
    }
}
