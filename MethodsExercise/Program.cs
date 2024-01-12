namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Madlib();
            int added = Add(2, 4);
            Console.WriteLine(added);

            int removed = Subtract(14, 2);
            Console.WriteLine(removed);

            int multiplied = Multiply(6, 4);
            Console.WriteLine(multiplied);

            int divided = Divide(18, 2);
            Console.WriteLine(divided);

            int sum = AddAllSums(2, 4);
            Console.WriteLine(sum);

            int sum2 = AddAllSums2 (2, 4, 6);
            Console.WriteLine(sum2);

            int sum3 = AddAllSums3(1, 1, 1, 1, 1);
            Console.WriteLine(sum3);


        }

        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}, What is your favorite Sport?");
            string favSport = Console.ReadLine();
            Console.WriteLine("What is your favorite Food?");
            string favFood = Console.ReadLine();
            Console.WriteLine("What is your favorite Season?");
            string favSeason = Console.ReadLine();

            Console.WriteLine($"One day {userName} was playing {favSport} outside during the {favSeason} and after hours of playing he finally sat down to eat at {favFood}");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;

        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;

        }

        public static int AddAllSums(params int[] nums)
        {
            int sum = 0;
            foreach (int number in nums)
            {
                sum = sum + number;
            }

            return sum;
        }

        public static int AddAllSums2(params int[] nums)
        {
            int sum = 0;
            foreach (int number in nums)
            {
                sum = sum + number;
            }

            return sum;
        }

        public static int AddAllSums3(params int[] nums)
        {
            int sum = 0;
            foreach (int number in nums)
            {
                sum = sum + number;
            }

            return sum;
        }


    }
}
