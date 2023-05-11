namespace LSP;

public class MyReadOnlyCollection : IMyCollection
{
    private IList<int> _collection;

    public MyReadOnlyCollection(IList<int>? col = null)
    {
        _collection = col ?? new List<int>();
    }
    public void Add(int item)
    {
        throw new NotImplementedException();
    }

    public int Get(int index)
    {
        return _collection[index];
    }

    public void Remove(int item)
    {
        throw new NotImplementedException();
    }
}