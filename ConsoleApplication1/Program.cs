using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    class Program
    {
        static void Main(string[] args)
        {
            #region  Стэк
            Console.WriteLine("Стэк:\n");
            Stack<int> st = new Stack<int>();
            st.Push(3);// в стеке 3
            Console.WriteLine("     Добавление (3): ");
            st.Write();
            st.Push(2); // в стеке 2, 3
            Console.WriteLine("     Добавление (2): ");
            st.Write();
            st.Push(8); // в стеке 8, 2, 3
            Console.WriteLine("     Добавление (8):");
            st.Write();
            Console.WriteLine("     Получение значения первого элемента:");
            st.Peek().Write();
            st.Write();
          
            st.Pop();
            Console.WriteLine("     Удаление первого элемента:");
            st.Write();
            st.Clear();
            Console.WriteLine("     Удаление стэка:");
            st.Write();
            Console.WriteLine("\n------------------------------------------------------------------------\n");
            #endregion

            #region  Очередь
            Queue<int> q = new Queue<int>();
            Console.WriteLine("     Очередь:");
            q.Enqueue(3); // в очереди 3
            Console.WriteLine("     Добавление 3: ");
            q.Write();
            q.Enqueue(5); // в очереди 3, 5
            Console.WriteLine("     Добавление 5: ");
            q.Write();
            q.Enqueue(7); // в очереди 3, 5, 7
            Console.WriteLine("     Добавление 7: ");
            q.Write();
            Queue<int> q_head = q.Peek(); // q_head = 3, в очереди 3, 5, 7
            Console.WriteLine("     Получили значение первого элемента без извлечения: ");
            q.Write();
            Console.WriteLine("     Очередь: ");
            q.Write();
            Console.WriteLine("     Извлекли первый элемент, в очереди осталось: ");
            q.Dequeue();
            q.Write();
            Console.WriteLine("     Удаление очереди: ");
            q.Clear();
            q.Write();
            Console.WriteLine("\n------------------------------------------------------------------------\n");
            Console.WriteLine("Массив:\n");
            #endregion

            #region Массив
            Array<int> a = new Array<int>(1);
            Console.WriteLine("     Добавление 1:");
            a.Write();
            a.Add(2);
            Console.WriteLine("     Добавление 2:");
            a.Write();
            a.Add(3);
            Console.WriteLine("     Добавление 3:");
            a.Write();
            a.Add(4);
            Console.WriteLine("     Добавление 4:");
            a.Write();
            a.Add(5);
            Console.WriteLine("     Добавление 5:");
            a.Write();
            a.Add(6);       
            Console.WriteLine("     Добавление 6:");
            a.Write();
            a.Add(7);
            Console.WriteLine("     Добавление 7:");
            a.Write();
            a.Add(8);
            Console.WriteLine("     Добавление 8:");
            a.Write();
            Console.WriteLine("\n       Удаление первго элемента:");
            a.Remove(); //удаляем перввый элемент, в массиве теперь 2, 3, 4, 5, 6
            a.Write();
            Console.WriteLine("\n       Удаление третьего элемента:");
            a.RemoveAt(3);//удалили 3 элемент (начиная с 0), в массиве теперь 2, 3, 4, 6
            a.Write();
            Console.ReadKey();
            #endregion
        }
    }

}

