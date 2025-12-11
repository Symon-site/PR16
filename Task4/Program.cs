namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);
            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);
        }
    }
}
