

namespace Helpers
{
    public static class Printer
    {
        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}

