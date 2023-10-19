namespace DataStructures.DisjointSets;

public class UnionFind : IDisjointSet
{
    private readonly int[] _root;
    public UnionFind(int size)
    {
        _root = new int[size];
        for (int i = 0; i < _root.Length; i++)
        {
            _root[i] = i;
        }
    }
    
    public int Find(int x)
    {
        return _root[x];
    }

    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);
        if (rootX != rootY)
        {
            for (int i = 0; i < _root.Length; i++)
            {
                if (_root[i] == rootY)
                {
                    _root[i] = rootX;
                }
            }
        }
    }

    public bool IsConnected(int x, int y)
    {
        return Find(x) == Find(y);
    }
}