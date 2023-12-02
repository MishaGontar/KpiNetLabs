using ConsoleApplication1.lab1.model;
using NUnit.Framework;

[TestFixture]
public class NodeTests
{
    [Test]
    public void Node_CreatesNodeWithData()
    {
        var data = 1;
        var node = new Node<int>(data);

        Assert.AreEqual(data, node.Data);
    }

    [Test]
    public void Node_CreatesNodeWithNextNode()
    {
        var data = 1;
        var nextNode = new Node<int>(2);

        var node = new Node<int>(data);
        node.Next = nextNode;

        Assert.AreEqual(nextNode, node.Next);
    }
}