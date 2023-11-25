using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApplication1.lab1.model;

namespace ConsoleApplication1.lab1;

public class Queue<T> : IEnumerable<T>
{
    public event EventHandler<T> ItemAddedToFront;
    public event EventHandler<T> ItemEnqueued;
    public event EventHandler<T> ItemDequeued;
    public event EventHandler Cleared;

    private Node<T> _head;
    private Node<T> _tail;

    public void Enqueue(T data)
    {
        if (data == null)
        {
            throw new ArgumentNullException("data");
        }

        Node<T> node = new Node<T>(data);
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail.Next = node;
            _tail = node;
        }

        ItemEnqueued?.Invoke(this, data);
    }

    public void AddToFront(T data)
    {
        if (data == null)
        {
            throw new ArgumentNullException("data");
        }

        Node<T> node = new Node<T>(data);
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            node.Next = _head;
            _head = node;
        }

        ItemAddedToFront?.Invoke(this, data);
    }

    public T Dequeue()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T result = _head.Data;
        _head = _head.Next;

        if (_head == null)
        {
            _tail = null;
        }

        ItemDequeued?.Invoke(this, result);

        return result;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;

        Cleared?.Invoke(this, EventArgs.Empty);
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = _head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}