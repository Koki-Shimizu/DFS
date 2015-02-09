using System;
using NUnit.Framework;

namespace DFS.Test
{
    [TestFixture]
    public class DFSTest
    {
        [Test]
        public void Search_should_reach_each_node()
        {
            // Arrange
            var target = new Node();
            target.Adjacent = new Node[] { new Node(), new Node(){ Adjacent = new Node[]{ new Node(), new Node()} }, new Node() };

            // Act
            DFS.Search(target);

            // Assert
            AssertNode(target);
        }

        private void AssertNode(Node node)
        {
            Assert.IsTrue(node.Visited);
            if (node.Adjacent != null)
            { 
                foreach (var n in node.Adjacent)
                {
                    Assert.IsTrue(n.Visited);
                    AssertNode(n);
                }
            }
        }
    }
}
