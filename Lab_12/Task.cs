using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    public class Task1_2<T>
    {
        public T Max(T a, T b, T c)
        {
            dynamic n1 = (dynamic)a;
            dynamic n2 = (dynamic)b;
            dynamic n3 = (dynamic)c;
            if (n1 >= n2 && n1 >= n3)
            {
                return n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
        public T Min(T a, T b, T c)
        {
            dynamic n1 = (dynamic)a;
            dynamic n2 = (dynamic)b;
            dynamic n3 = (dynamic)c;
            if (n1 <= n2 && n1 <= n3)
            {
                return n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }



    public class Task3<T>
    {
        public T SumArray(T[] array)
        {
            dynamic sum = default(T);
            for (int i = 0; i < array.Length; i++)
            {
                sum += (dynamic)array[i];
            }
            return sum;
        }
    }



    public class Stack<T>
    {
        private List<T> element;

        public Stack()
        {
            element = new List<T>();
        }

        public void Push(T item)
        {
            element.Add(item);
        }

        public T Pop()
        {
            if (element.Count == 0)
            {
                Console.WriteLine("The stack is empty");
                Environment.Exit(0);
            }

            T item = element[element.Count - 1];
            element.RemoveAt(element.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (element.Count == 0)
            {
                Console.WriteLine("The stack is empty");
                Environment.Exit(0);
            }

            return element[element.Count - 1];
        }

        public int Count
        {
            get { return element.Count; }
        }
    }



    public class Queue<T>
    {
        private LinkedList<T> elements;

        public Queue()
        {
            elements = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            elements.AddLast(item);
        }

        public T Dequeue()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("The queue is empty");
                Environment.Exit(0);
            }

            T item = elements.First.Value;
            elements.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("The queue is empty");
                Environment.Exit(0);
            }

            return elements.First.Value;
        }

        public int Count
        {
            get { return elements.Count; }
        }
    }
}
