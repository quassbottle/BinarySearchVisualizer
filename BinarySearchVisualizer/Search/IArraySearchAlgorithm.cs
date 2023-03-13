namespace BinarySearchVisualizer.Search
{
    public interface IArraySearchAlgorithm<in T>
    {
        int FindIndexOf(T item);
    }
}