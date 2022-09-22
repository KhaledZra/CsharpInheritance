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
            

            Console.WriteLine("---------------------------------");
            h1.Speak();
            h1.Introduction();
            Console.WriteLine("---------------");
            s1.Speak();
            s1.Introduction();
            Console.WriteLine("---------------");
            t1.Speak();
            t1.Introduction();
            Console.WriteLine("---------------------------------");



            Console.Write("Program end! Press any key to quit...");
            Console.ReadLine();
        }
    }
}