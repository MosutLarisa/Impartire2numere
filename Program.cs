namespace Impartire2numere
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("can not be calculated");
            }
        }
        }
    }