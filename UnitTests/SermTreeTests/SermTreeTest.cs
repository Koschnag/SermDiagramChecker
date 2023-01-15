using SermTreeCore.Helper;
using SermTreeCore.Models;

namespace UnitTests.SermTreeTests
{
    [TestClass]
    public class SermTreeTest
    {
        [TestMethod]
        public void CreateSermTreeWithAStartNode()
        {
            var tree = new SermTree();
            var startNode = new SermTreeNode("StartNode");
            tree.Root = startNode;
            Assert.AreEqual(tree.Root, startNode);
        }

        [TestMethod]
        public void CreateSermTreeWithAStartNodeAndAChild()
        {
            var tree = new SermTree();
            var startNode = new SermTreeNode
            {
                Name = "StartNode",
            };

            var childNode = new SermTreeNode
            {
                Name = "ChildNode",
                Color = new SermAttribute
                {
                    Name = "BNummer",
                    Type = AttributeTypes.PrimaryKey,
                }
            };
            

            startNode.Children.Add(childNode);
            tree.Root = startNode;
            Assert.AreEqual(tree.Root.Children[0], childNode);
        }



    }
}
}
