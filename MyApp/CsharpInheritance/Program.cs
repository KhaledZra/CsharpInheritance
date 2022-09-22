namespace CsharpInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new(24, "Khaled");
            Student s1 = new(24, "Khaled", "Khazra97.Student");
            Teacher t1 = new(24, "Timmy", "TimOhm97.Teacher");

            Console.Clear();

            h1.Speak();
            s1.Present();
            t1.Present();


            Console.WriteLine("Program end!");
            Console.ReadLine();
        }
    }
}