using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz1
{
    internal class Task11: IBaseTask
    {
        private int _n = 13;

        public Task11()
        {

        }

        public Task11(int n)
        {
            _n = n;
        }

        public void StartTask(int[] arr)
        {
            Console.Write("Numbers: [ ");
            foreach (var elem in arr)
            {
                Console.Write($"{elem} ");
            }

            Console.WriteLine("]");

            Console.Write($"Numbers that are in range of [1;{_n}]: [ ");
            //Console.Write("Numbers that are in range of [1;" + _n + "]: [ ");


            foreach (int elem in arr)
            {
                if (elem >= 1 && elem <= _n)
                {
                    Console.Write($"{elem} ");
                }
            }

            Console.WriteLine("]");

            Console.ReadLine();
        }
        public void StartTask()
        {
            int[] numbers = { 4, 6, 12 };

            Console.Write("Numbers: [ ");
            foreach (var elem in numbers)
            {
                Console.Write($"{elem} ");
            }

            Console.WriteLine("]");

            Console.Write($"Numbers that are in range of [1;{_n}]: [ ");
            //Console.Write("Numbers that are in range of [1;" + _n + "]: [ ");


            foreach (int elem in numbers)
            {
                if (elem >= 1 && elem <= _n)
                {
                    Console.Write($"{elem} ");
                }
            }

            Console.WriteLine("]");

            Console.ReadLine();
        }
    }
}
