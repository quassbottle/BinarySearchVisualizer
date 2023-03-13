using System;
using System.Collections.Generic;
using BinarySearchVisualizer.Utils;

namespace BinarySearchVisualizer.GUI
{
    public class ConsoleHandler
    {
        private int[] _array;

        public ConsoleHandler(int[] array)
        {
            _array = array;
        }

        public void WriteArrayHighlighted(int left, int right, int mid)
        {
            int c = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                int itemLength = _array[i].ToString().Length;
                var arr = new int[itemLength];
                for (int j = 0; j < itemLength; j++)
                {
                    arr[j] = c++;
                }
                
                if (i == mid)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (i >= left && i <= right)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                Console.Write(_array[i]);
                Console.Write(" ");
                c++;
            }
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public void WriteArray()
        {
            foreach (var i in _array)
            {
                Console.Write(i + " ");
            }
        }
    }
}