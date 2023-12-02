using System;
using System.Collections;

namespace ConsoleApplication1.lab1;

public class MyCollection : IEnumerable
{
    private int[] data;

    public MyCollection(int[] array)
    {
        data = array;
    }


    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(data);
    }

    private class MyEnumerator : IEnumerator
    {
        private int[] data;
        private int position = -1;

        public MyEnumerator(int[] data)
        {
            this.data = data;
        }

        public bool MoveNext()
        {
            position++;
            return position < data.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return data[position];
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
