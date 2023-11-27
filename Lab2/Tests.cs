using NUnit.Framework;
using System;
using System.Linq;
using ConsoleApplication1.lab1;

[TestFixture]
public class QueueTests
{
    private Queue<string> _queue;

    [SetUp]
    public void SetUp()
    {
        _queue = new Queue<string>();
    }

    [Test]
    public void Enqueue_WhenCalled_ShouldAddItemToQueue()
    {
        _queue.Enqueue("test");

        Assert.That(_queue.Count(), Is.EqualTo(1));
    }

    [Test]
    public void Dequeue_WhenCalled_ShouldRemoveItemFromQueue()
    {
        _queue.Enqueue("test");
        _queue.Dequeue();

        Assert.That(_queue.Count(), Is.EqualTo(0));
    }

    [Test]
    public void Dequeue_WhenQueueIsEmpty_ShouldThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => _queue.Dequeue());
    }

    [Test]
    public void Clear_WhenCalled_ShouldRemoveAllItemsFromQueue()
    {
        _queue.Enqueue("test1");
        _queue.Enqueue("test2");
        _queue.Clear();

        Assert.That(_queue.Count(), Is.EqualTo(0));
    }

    [Test]
    public void Enqueue_WhenDataIsNull_ShouldThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => _queue.Enqueue(null));
    }

    [Test]
    public void AddToFront_WhenDataIsNull_ShouldThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => _queue.AddToFront(null));
    }
}