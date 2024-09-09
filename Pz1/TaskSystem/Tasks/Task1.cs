namespace Pz1.TaskSystem.Tasks
{
    internal class Task1 : ITaskeable
    {
        private int _min;
        private int _max;

        private int[] _numbers;

        public int LenghtNumbers => _numbers.Length;
        public Task1()
        {
            _min = 1;
            _max = 10 + 3;

            _numbers = new int[3];
        }
        
        public void StartTask()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = new Random().Next(-100, 100);
            }
            StartTask(_numbers, _min, _max);
        }

        public void StartTask(int[] arr, int min, int max)
        {
            ShowArray(arr);

            PrintNumbersWithinRange(arr, min, max);
        }

        private void ShowArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private void PrintNumbersWithinRange(int[] numbers, int min, int max)
        {
            Console.Write($"Numbers that are in range of [{min};{max}]: ");

            foreach (int number in numbers)
            {
                if (IsWithinRange(number, min, max))
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }

        public bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        public void StopTask()
        {
            Console.Clear();
        }

        
    }
}
