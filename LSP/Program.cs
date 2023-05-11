
using LSP;

MySimpleCollection collection = new();
collection.Add(1);
collection.Remove(1);
Console.WriteLine(collection.Get(0));

MyReadOnlyCollection readOnlyCollection = new MyReadOnlyCollection(new List<int> {1,2,3,4});
readOnlyCollection.Add(5);