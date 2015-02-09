using System;
using NUnit.Framework;

namespace DFS.Test
{
    [TestFixture]
    public class BFSTest
    {
        [Test]
        public void Search_should_reach_each_node()
        {
            // Arrange
            var target = new Node();
            target.Adjacent = new Node[] { new Node(), new Node(){ Adjacent = new Node[]{ new Node(), new Node()} }, new Node() };

            // Act
            BFS.Search(target);

            // Assert
            AssertNode(target);
        }

        [Test]
        public void Search_should_reach_each_node_()
        {
            // Arrange
            var target = new Node();
            target.Adjacent = new Node[] { new Node(), new Node() { Adjacent = new Node[] { new Node() { Adjacent = new Node[] { new Node() } }, new Node() } }, new Node() };

            // Act
            BFS.Search(target);

            // Assert
            AssertNode(target);
        }

        [Test]
        public void Search_should_reach_if_node_zero()
        {
            // Arrange
            var target = new Node();
            target.Adjacent = null;

            // Act
            BFS.Search(target);

            // Assert
            AssertNode(target);
        }

        [Test]
        public void Search_should_reach_if_node_one()
        {
            // Arrange
            var target = new Node();
            target.Adjacent = new Node[] { new Node() };

            // Act
            BFS.Search(target);

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
