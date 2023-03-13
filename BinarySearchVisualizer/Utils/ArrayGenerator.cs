using System;
using System.Collections.Generic;

namespace BinarySearchVisualizer.Utils
{
    public class ArrayGenerator
    {
        private Random _rnd;
        
        public ArrayGenerator()
        {
            _rnd = new Random();
        }

        public int[] Generate(int min, int max, int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = _rnd.Next(min, max);
            return array;
        }
    }
}