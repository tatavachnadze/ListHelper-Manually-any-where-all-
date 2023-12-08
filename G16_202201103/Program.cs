using MyLinq;

namespace G16_202201103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, -11, -1, 7, 3 };
            //var result = x.Where(n => n > 0);
            var result = ListHelper.Where(x, n => n > 0);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            var result1 = ListHelper.Any(x, n => n % 2 == 0);
            Console.WriteLine(result1);

            var result2 = ListHelper.All(x, n => n % 2 == 1 || n % 2 == -1);
            Console.WriteLine(result2);
        }
        //Func<int, int, int> f = delegate (int x, int y)
        //{
        //    return x + y;
        //};

        //Func<int, int, int> f = (x, y) => x + y;

        //Console.WriteLine(f(5, 2));
    }
}

