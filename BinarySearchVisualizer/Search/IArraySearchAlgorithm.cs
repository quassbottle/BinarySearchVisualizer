using System;
using System.Collections.Generic;

namespace BinarySearchVisualizer.Search
{
    public interface IArraySearchAlgorithm<T>
    {
        T[] GetArray();
        int FindIndexOf(T item);
    }
}