namespace ThreeVariablesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ThreeVariablesApp!");
            Console.WriteLine("\r");

            // If numberOne is not very big, int should be enough
            int numberOne = 10;

            // Probably decimal is OK. 
            decimal numberTwo = 12.5M;
            
            string someText = "Szkoła Dotneta";
            
            Console.WriteLine($"The value of int variable: {numberOne}");
            Console.WriteLine($"The value of decimal variable: {numberTwo}");
            Console.WriteLine($"The value of string variable: {someText}");
        }
    }
}