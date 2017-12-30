using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Queue<T> : Collections<T>
    {

        public Node head; //первый элемент
        private Node tail; //последний элемент
        public Queue() //конструктор
        {
            head = null;
            tail = null;
        }
        public Queue(T x) //конструктор
        {
            Node p = new Node(x);
            head = p;
            tail = head;
        }

        public void Write() //вызываем метод базового класса для печати очереди
        {
            Write(head);
        }
        public void Enqueue(T x) // добавляем элемент со значением x
        {
            Node element = new Node(x);
            if (head == null)
            {
                head = element;
                tail = head;
            }
            else
            {
                tail.Next = element;
                tail = tail.Next;
            }
        }
        public Queue<T> Dequeue()//извлекаем первый элемент
        {
            if (head == null) return null;
            Queue<T> p = new Queue<T>(head.Data);
            head = head.Next;
            return p;
        }
        public Queue<T> Peek() //получаем значение первого элемента без извлечения
        {
            if (head == null) return null;
            Queue<T> p = new Queue<T>(head.Data);
            return p;
        }
        public void Clear() //удаляем
        {
            Clear(head);
        }
    }
}
