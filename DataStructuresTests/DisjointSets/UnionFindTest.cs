using NUnit.Framework;
using DataStructures.DisjointSets;

namespace DataStructuresTests.DisjointSets;

[TestFixture]
public class UnionFindTest
{
    [Test]
    public void ElementsInUnionFindHaveItselfAsRoot()
    {
        // Create the UnionFind instance with 10 elements
        const int ufSize = 10;
        var uF = new UnionFind(ufSize);
        
        // Validate each element is has itself as root
        for (int i = 0; i < ufSize; i++)
        {
            
            Assert.IsTrue(uF.IsConnected(i, i));
        }
    }

    [Test]
    public void ElementsInUnionFindShouldNotHaveADifferentRootThanItself()
    {
        // Create the UnionFind instance with 10 elements
        const int ufSize = 10;
        var uF = new UnionFind(ufSize);
        
        // Validate each element is has itself as root
        for (int root = 0; root < ufSize; root++)
        {
            for (int element = root + 1; element < ufSize; element++)
            {
                Assert.IsFalse(uF.IsConnected(root, element));
            }
        }
    }
    
}