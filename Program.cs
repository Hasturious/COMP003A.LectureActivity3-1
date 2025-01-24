namespace COMP003A.LectureActivity3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the time?: ");
            int hour = int.Parse(Console.ReadLine());

            //conditions
            //5-11
            //12-17
            //18-20
            //21-4
            if (hour >= 5 && hour <= 11)
            {
                Console.WriteLine("Good Morning!");
            }
        }
    }
}
