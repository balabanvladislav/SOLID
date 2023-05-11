namespace LSP;

public class MySimpleCollection : IMyCollection
{
    private IList<int> _collection;

    public MySimpleCollection(IList<int>? collection = null)
    {
        _collection = collection ?? new List<int>();
    }
    public void Add(int item)
    {
        _collection.Add(item);
    }

    public void Remove(int item)
    {
        var collectionItem = _collection.FirstOrDefault(i => i.Equals(item));
        _collection.Remove(collectionItem);
    }

    public int Get(int index)
    {
        return _collection[index];
    }
}