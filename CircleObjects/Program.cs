using System.Reflection.Metadata.Ecma335;

namespace CircleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {
                double radius;
                try
                {
                    Console.WriteLine("Please enter a radius.");
                    radius = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You must enter a positive integer.");
                    continue;
                }
                //calling class and printing out numbers
                Circle c = new Circle(radius);
               
                c.CalculateCircumference(radius);
                Console.WriteLine($"Circumference: {c.CalculateCircumference(radius)}");
                c.CalculateArea(radius);
                Console.WriteLine(($"Area: {c.CalculateArea(radius)}"));


                goOn = goAgain();
            }
        }
        public static bool goAgain()
        {
            int goCounter = 1;
            goCounter++;
            Console.WriteLine("Measure another circle?");
            string input = Console.ReadLine().ToLower();
                
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye. You have created " + goCounter + " circle object(s).");  //"You have created" + goAgain counter + circle object(s)
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                return goAgain();
            }
        }
    }
}
