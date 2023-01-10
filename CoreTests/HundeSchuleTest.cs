using DiagramChecker;
using DiagramChecker.Contracts;

namespace CoreTests
{
    public class Tests
    {
        IDiagram diagram = new SermDiagram();
        [SetUp]
        public void Setup()
        {

            var besitzer = new Entity();
            besitzer.Name = "Besitzer";

            diagram.StartNodes.Add(besitzer);

            var BNr = new SermAttribute();
            BNr.Name = "BNr";
            BNr.Type = "Key";

            var BName = new SermAttribute();
            BName.Name = "Name";
            BName.Type = "Eigenschaft";

            besitzer.Attributes.Add(BNr);
            besitzer.Attributes.Add(BName);

            var hund = new Entity();
            hund.Attributes.Add(new SermAttribute() { Name = "HName", Type = "Key" });
            hund.Attributes.Add(new SermAttribute() { Name = "BNr", Type = "Key" });
            hund.Attributes.Add(new SermAttribute() { Name = "Name", Type = "Eigenschaft" });

            var relationship = new Relationship(besitzer, hund);
        }

        [Test]
        public void Test1()
        {
            //Testing the Setup Method
            Assert.AreEqual(1, diagram.StartNodes.Count);
            Assert.AreEqual(2, diagram.StartNodes[0].Attributes.Count);
            Assert.AreEqual(1, diagram.StartNodes[0].Relationships.Count);
            Assert.AreEqual(3, diagram.StartNodes[0].Relationships[0].To.Attributes.Count);

            //Check if the names and properties are right
            Assert.AreEqual("BNr", diagram.StartNodes[0].Attributes[0].Name);
            Assert.AreEqual("Key", diagram.StartNodes[0].Attributes[0].Type);
            Assert.AreEqual("BName", diagram.StartNodes[0].Attributes[1].Name);
            Assert.AreEqual("Eigenschaft", diagram.StartNodes[0].Attributes[1].Type);

            Assert.AreEqual("HName", diagram.StartNodes[0].Relationships[0].To.Attributes[0].Name);
            Assert.AreEqual("Key", diagram.StartNodes[0].Relationships[0].To.Attributes[0].Type);
            Assert.AreEqual("BNr", diagram.StartNodes[0].Relationships[0].To.Attributes[1].Name);
            Assert.AreEqual("Key", diagram.StartNodes[0].Relationships[0].To.Attributes[1].Type);
            Assert.AreEqual("Name", diagram.StartNodes[0].Relationships[0].To.Attributes[2].Name);
            Assert.AreEqual("Eigenschaft", diagram.StartNodes[0].Relationships[0].To.Attributes[2].Type);
            

            Assert.Pass();
        }
    }
}