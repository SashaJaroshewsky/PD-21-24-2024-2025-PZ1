namespace Pz1.Task
{

    internal class Task1: IBaseTask
    {

        private int _min = 1;
        private int _max = 10 + 3;
        public Task1()
        {

        }

        public Task1(int min, int max)
        {
            _min = min;
            _max = max;
        }
        public void StartTask(int[] arr) {

            Console.Write("Numbers: [ ");
            foreach (int elem in arr)
            {
                Console.Write($"{elem} ");
            }

            Console.WriteLine("]");

            Console.Write($"Numbers that are in range of [1;{_max}]: [ ");
            //Console.Write("Numbers that are in range of [1;" + _n + "]: [ ");
            Console.WriteLine("[");

            foreach (int elem in arr)
            {
                if (elem >= _min && elem <= _max)
                {
                    Console.Write($"{elem} ");
                }
            }

            Console.WriteLine("]");

            Console.ReadLine();
        }
        public void StartTask()
        {
            int[] arr = { 4, 6, 12 };



            Console.Write("Numbers: [ ");
            foreach (int elem in arr)
            {
                Console.Write($"{elem} ");
            }

            Console.WriteLine("]");

            Console.Write($"Numbers that are in range of [1;{_max}]: [ ");
            //Console.Write("Numbers that are in range of [1;" + _n + "]: [ ");
            Console.WriteLine("[");

            foreach (int elem in arr)
            {
                if (elem >= _min && elem <= _max)
                {
                    Console.Write($"{elem} ");
                }
            }

            Console.WriteLine("]");

            Console.ReadLine();
        }

        
    }
}
