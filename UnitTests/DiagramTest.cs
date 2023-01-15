using DiagramChecker;
using DiagramChecker.Contracts;
using DiagramChecker.Helper;

namespace UnitTests
{
    [TestClass]
    public class DiagramTest
    {
        IDiagram diagram;
        private void Setup() {
            diagram = new SermDiagram();
            var besitzer = new Entity("Besitzer");

            diagram.StartNodes.Add(besitzer);
        }
        
        [TestMethod]
        public void CheckIfAddingNodeIsPossible()
        {
            Setup();
            //Check if adding note is possible
            Assert.AreEqual(1, diagram.StartNodes.Count);
        }

        [TestMethod]
        public void CheckIfAddingAttributeIsPossible()
        {
            Setup();
            //Check if adding attribute is possible
            var besitzer = diagram.StartNodes[0];
            besitzer.Attributes.Add(new SermAttribute("Name", AttributeType.PrimaryKey));
            Assert.AreEqual(1, besitzer.Attributes.Count);
        }
    }
}