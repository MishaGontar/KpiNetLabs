using ConsoleApplication1.lab1.model;
using NUnit.Framework;

namespace Lab2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Node<bool> n = new Node<bool>(true);
            Assert.True(n.Data);
        }
    }
}