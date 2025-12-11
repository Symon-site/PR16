namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Money(10, 50);
            var m2 = new Money(5, 75);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 == new Money(10, 50)); 

        }
    }
}
