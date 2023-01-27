namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int myVar = 5;
            int product = (myVar * myVar);
            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine(35 + 5 % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2);
            Console.WriteLine(myVar * myVar);

            if (product < number1)
            {
                Console.WriteLine("myVar * myVar is less than 10 ");
            }
            else
            {
                Console.WriteLine("myVar * myVar is greater than 10 ");
         }
    }   }
}