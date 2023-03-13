using System;
using BinarySearchVisualizer.Search;

namespace BinarySearchVisualizer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var search = new BinarySearch(new[] { 1, 2, 3, 4, 5, 6, 7 });
            search.OnIteration += SearchOnOnIteration;
            Console.WriteLine(search.FindIndexOf(8));
        }

        private static void SearchOnOnIteration(int left, int right, int mid)
        {
            Console.WriteLine($"{left} {right} {mid}");
        }
    }
}