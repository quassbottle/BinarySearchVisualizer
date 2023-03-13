using System;
using System.Threading.Tasks;
using BinarySearchVisualizer.GUI;
using BinarySearchVisualizer.Search;
using BinarySearchVisualizer.Utils;

namespace BinarySearchVisualizer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Binary Searching Algorithm Visualizer";
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        private ConsoleHandler _handler;
        
        private async Task MainAsync()
        {
            Console.Clear();
            BinarySearch search = new BinarySearch(new ArrayGenerator().Generate(0, 25, 15));
            _handler = new ConsoleHandler(search.GetSortedArray());
            search.OnIteration += SearchOnOnIteration;

            Console.WriteLine("Welcome to the binary searching algorithm visualizer!");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Yellow color");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" is for the range from left to right side of the array.");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("Orange color");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" is for the mid value of the array.");
            
            Console.WriteLine();
            
            Console.Write("Initial array: ");
            _handler.WriteArray();
            Console.WriteLine();

            Console.Write("Target value: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int result = search.FindIndexOf(target);

            if (result == -1) Console.WriteLine($"Target not found.");
            else Console.WriteLine($"Found target {target} at index {result}.");

            Console.Read();

            await Task.Delay(-1);
        }

        private void SearchOnOnIteration(int left, int right, int mid)
        {
            _handler.WriteArrayHighlighted(left, right, mid);
            Console.WriteLine();
        }
    }
}