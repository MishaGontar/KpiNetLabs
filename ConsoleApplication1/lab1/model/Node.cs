#nullable enable
namespace ConsoleApplication1.lab1.model
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
}