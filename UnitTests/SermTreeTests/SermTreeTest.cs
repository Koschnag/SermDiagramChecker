using SermTreeCore.Contracts;
using SermTreeCore.Helper;
using SermTreeCore.Models;

namespace UnitTests.SermTreeTests
{
    [TestClass]
    public class SermTreeTest
    {

        [TestMethod]
        public void CreateSermTreeWithAStartNodeAndOneAttribute()
        {
            var tree = new SermTree();
            var Besitzer = new SermTreeNode
            {
                Name = "Besitzer",
                Attributes = new List<IColor>
                {
                    new SermAttribute
                    {
                        Name = "BNummer",
                        Type = AttributeTypes.PrimaryKey,
                    }
                }
            };
            tree.Roots.Add(Besitzer);
            Assert.AreEqual(tree.Roots[0], Besitzer);
        }

        [TestMethod]
        public void CreateSermTreeWithOneSuccessor()
        {
            var tree = new SermTree();
            var Besitzer = new SermTreeNode
            {
                Name = "Besitzer",
                Attributes = new List<IColor>
                {
                    new SermAttribute
                    {
                        Name = "BNummer",
                        Type = AttributeTypes.PrimaryKey,
                    },
                    
                    //Name
                    new SermAttribute
                    {
                        Name = "Name",
                        Type = AttributeTypes.Property,
                    }
                }
            };
            var Hund = new SermTreeNode
            {
                Name = "Hund",
                Attributes = new List<IColor>
                {
                    new SermAttribute
                    {
                        Name = "HNummer",
                        Type = AttributeTypes.PrimaryKey,
                    },
                    new SermAttribute
                    {
                        Name = "BNummer",
                        Type = AttributeTypes.Property,
                    },
                    new SermAttribute
                    {
                        Name = "Name",
                        Type = AttributeTypes.Property,
                    }
                }
            };

            tree.Roots.Add(Besitzer);
            var connection = TreeNodeConnector.Connect(Besitzer, Hund, RelationshipTypes.OneToMany);
            Besitzer.Successor.Relationships.Add(connection);

            Assert.AreEqual(Besitzer.Successor.Relationships[0].To, Hund);
        }
    }
}

