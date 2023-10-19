namespace DataStructures.DisjointSets;

public interface IDisjointSet
{
    int Find(int x);
    void Union(int x, int y);
    bool IsConnected(int x, int y);
}