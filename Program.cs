namespace COMP003A.LectureActivity3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the current hour (0-23): ");
            int hour = int.Parse(Console.ReadLine());

            //conditions
            //5-11
            //12-17
            //18-20
            //21-4

            //if and elif statments

            if (hour >= 5 && hour <= 11)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if (hour >= 18 && hour <= 20)
            {
                Console.WriteLine("Good Evening!");
            }
            else if (hour >= 21 && hour <= 4)
            {
                Console.WriteLine("Good Night!");
            }

            Console.Write("Enter the day of the week: ");
            string day = Console.ReadLine();

            //condition 1: Monday
            //condition 2: Friday
            //condition 3: Sunday
            //default: Just Another Day

            //switch case
            
            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Start of the work week.");
                    break;
                case "friday":
                    Console.WriteLine("Almost the weekend!");
                    break;
                case "sunday":
                    Console.WriteLine("Relax, it's Sunday.");
                    break;
                default:
                    Console.WriteLine("Just any other day.");
                    break;
            }

        }
    }
}
