namespace Pz1
{
    internal class T1
    {
        private int _n = 10 + 1;
        public int A;
        public int B;

      //public int N => _n;
       
        public T1(int a, int b)
        {
           
            A = a;
            B = b;
        }

        public T1()
        {

        }
        public void Ex1(int[] numbers)
        {

        }
        public void Ex1()
        {
            int[] numbers = { 4, 6, 12 };

            Console.Write("Numbers: [ ");
            foreach (int elem in numbers)
            {
                Console.Write($"{elem} ");
            }

            Console.WriteLine("]");

            Console.Write($"Numbers that are in range of [1;{_n}]: [ ");
            Console.Write("Numbers that are in range of [1;" + _n + "]: [ ");


            foreach (int elem in numbers)
            {
                if (elem >= 1 && elem <= _n)
                {
                    Console.Write($"{elem} ");
                }
            }

            Console.WriteLine("]");
        }
    }
}
