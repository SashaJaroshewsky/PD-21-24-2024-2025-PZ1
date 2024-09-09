namespace Pz1.InputSystem
{
    internal class InputController
    {
        public InputType Input()
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
                    return InputType.Exit;
                case 1:
                    return InputType.Task1;
                case 2:
                    return InputType.Task2;
                default:
                    return InputType.None;
            }
        }

        bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    }
}
