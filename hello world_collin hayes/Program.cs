namespace HelloWorld_Collin_Hayes
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");  // Asks the user for first name
            string FirstName = Console.ReadLine();          // Assigns user Input to FirtsName variable
            Console.WriteLine("What is your last name?");   // Asks the user for last name
            string lastname = Console.ReadLine();           // Assigns user input to lastname variable

            Console.WriteLine($"Hello, {FirstName} {lastname}!");   // prints a welcome home message with FirstName and lastname
        }
    }
}