using System;

namespace BinarySearchVisualizer.Search
{
    public class BinarySearch : IArraySearchAlgorithm<int>
    {
        public delegate void IterationHandler(int left, int right, int mid);
        public event IterationHandler OnIteration;
        
        private int[] _array;
        private int[] _sortedArray;
        
        public BinarySearch(int[] array)
        {
            _array = array;
            _sortedArray = _array;
            Array.Sort(_sortedArray);
        }

        public int[] GetSortedArray() => _sortedArray;
        public int[] GetArray() => _array;
        
        public int FindIndexOf(int item)
        {
            int left = 0;
            int right = _array.Length - 1;

            while (right - left > 1)
            {
                int mid = left + (right - left) / 2;
                
                OnIteration?.Invoke(left, right, mid);
                
                if (_sortedArray[mid] == item) return mid;
                if (item > _sortedArray[mid]) left = mid + 1;
                else right = mid;
            }
            
            if (_array[left] == item) return left;
            if (_array[right] == item) return right;
            return -1;
        }
    }
}