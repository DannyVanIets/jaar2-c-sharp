using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2b
{
    class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>
            {
                new Auto(),
                new Auto()
            };

            var boten = new List<Boot>
            {
                new Boot(),
                new Boot()
            };

            var objects = new List<Object>
            {
                new Object(),
                new Object()
            };

            var strings = new string[] { "a", "b", "c" };
            var ints = new int[] { 1, 2, 3 };
            var objecten = new object[] { 1, 2, 3 };

            //CountStringArray(strings);
            //CountIntArray(ints);

            CountArray<int>(ints);
            CountArray(strings);
            CountArray(objecten);

            var autoRepository = new GenericRepository<Auto>(autos);
            var bootRepository = new GenericRepository<Boot>(boten);

            var autos2 = autoRepository.GetAll();
            bootRepository.GetAll();

            new Controller<Auto>(autoRepository);
            var bootController = new Controller<Boot>(bootRepository);
        }

        static void CountStringArray(string[] arr)
        {
            var length = arr.Length;
            Console.WriteLine($"De lengte van de array is {length}");
        }

        static void CountIntArray(int[] arr)
        {
            var length = arr.Length;
            Console.WriteLine($"De lengte van de array is {length}");
        }

        static void CountArray<T>(T[] arr)
        {
            var length = arr.Length;
            Console.WriteLine($"De lengte van de array is {length}");
        }
    }
}
