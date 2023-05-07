namespace Project03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Convert the project from last week to keep allowing the user
             * to convert temperatures until they want to quit. Use a switch
             * statement to control the menu.
             */


            Console.WriteLine("Welcome to the temp converter!");

            int choice = -1;
            while (choice != 3)
            {

                Console.WriteLine("Enter 1 to convert from C to F.");
                Console.WriteLine("Enter 2 to convert from F to C.");
                Console.WriteLine("Enter 3 to quit.");
                choice = Convert.ToInt32(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter temperature to convert");
                        double tempC = Convert.ToDouble(Console.ReadLine());
                        double newTempF = tempC * (9.0 / 5) + 32;
                        Console.WriteLine($"{tempC} C is {newTempF} F");
                        break;

                    case 2:
                        Console.WriteLine("Enter temperature to convert");
                        double tempF = Convert.ToDouble(Console.ReadLine());
                        double newTempC = (tempF - 32) * (5.0 / 9);
                        Console.WriteLine($"{tempF} F is {newTempC} C");
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using the temp converter!");
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("That was not a valid choice.");
                        break;
                }
            }
        }
    }
}