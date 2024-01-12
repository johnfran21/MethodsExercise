namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Madlib();
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
    }
}
