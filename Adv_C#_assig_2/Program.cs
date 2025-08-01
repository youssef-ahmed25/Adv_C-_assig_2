using System.Xml.Linq;

namespace Adv_C__assig_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //List<int> list = new List<int>();
            ////------------------
            //Console.WriteLine("enter size of array");
            //int.TryParse(Console.ReadLine(), out int x);

            //Console.WriteLine("enter elements in array:");
            //for (int i = 0; i < x; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int element);
            //    list.Add(element);
            //}
            //Queue<int> queries = new Queue<int>();
            ////------------------
            //Console.WriteLine("enter number of queries:");
            //int.TryParse(Console.ReadLine(), out int q);

            //Console.WriteLine("enter query value:");
            //for (int i = 0; i < q; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int v);
            //    queries.Enqueue(v);
            //}
            //while (queries.Count > 0)
            //{
            //    int que = queries.Dequeue();
            //    int count = 0;
            //    foreach (int n in list)
            //    {
            //        if (n > que)
            //            count++;
            //    }
            //    Console.WriteLine(count);
            //}
            #endregion
            #region Q2
            //مش عارف حاولت بس كان بيطلع علط
            #endregion
            #region Q3
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);
            //queue.Enqueue(50);
            //Console.WriteLine("Original Queue:");
            //foreach (int i in queue)
            //{
            //    Console.Write(i);
            //}
            //Stack<int> stack = new Stack<int>();
            //while (queue.Count > 0)
            //{
            //    int i = queue.Dequeue();
            //    stack.Push(i);
            //}

            //while (stack.Count > 0)
            //{
            //    int i = stack.Pop();
            //    queue.Enqueue(i);
            //}
            //Console.WriteLine("\nReverse Queue:");
            //foreach (int i in queue)
            //{
            //    Console.Write(i);
            //}


            #endregion
            #region Q4
            //مش عارف حاولت بس كان بيطلع علط
            #endregion
            #region Q5
            //int[] arr = { 1, 2, 2, 3, 4, 1, 5, 3 };
            //int[] arr2 = new int[arr.Length];
            //int k = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int j;
            //    for (j = 0; j < k; j++)
            //    {
            //        if (arr[i] == arr2[j])
            //            break;
            //    }
            //    if (j == k)
            //        arr2[k++] = arr[i];
            //}
            //for (int i = 0; i < k; i++)
            //{
            //    Console.Write(arr2[i]);
            //}


            #endregion
            #region Q6
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //for (int i = 7; i >= 0; i--)
            //{
            //    if (list[i] % 2 == 1)
            //    {
            //        list.RemoveAt(i);
            //    }
            //}
            //foreach (int n in list)
            //{
            //    Console.Write(n);
            //}
            #endregion
            #region Q7
            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //foreach (object i in queue)
            //{
            //    Console.Write(i);
            //}
            #endregion
            #region Q8
            //Stack<int> stack = new Stack<int>();
            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };
            //foreach (int s in numbers)
            //    stack.Push(s);

            //Console.Write("Enter target integer: ");
            //int.TryParse(Console.ReadLine(), out int x);

            //int count = 0;
            //bool found = false;
            //foreach (int n in stack)
            //{
            //    count++;
            //    if (n == x)
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //if (found)
            //{ Console.WriteLine($"Target was found successfully and the count = {count}"); }
            //else
            //{ Console.WriteLine("Target was not found"); }
            #endregion
            #region Q9
            //List<int> arr1 = new List<int> { 1, 2, 2, 3, 4, 4 };
            //List<int> arr2 = new List<int> { 10, 4, 4, 2, 2 };

            //List<int> final = new List<int>();

            //foreach (int i in arr2)
            //{
            //    if (arr1.Contains(i))
            //    {
            //        final.Add(i);
            //        arr1.Remove(i);
            //    }
            //}
            //foreach (int i in final)
            //{
            //    Console.Write(i);
            //}
            #endregion
            #region Q10
            //مش عارف حاولت بس كان بيطلع علط
            #endregion
            #region Q11
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            int k = 3;

            Stack<int> F_Stack = new Stack<int>();
            Stack<int> S_Stack = new Stack<int>();
            for (int i = 0; i < k; i++)
                F_Stack.Push(q.Dequeue());

            //foreach (int i in F_Stack)
            //{
            //    Console.Write(i);//321
            //}
            while (q.Count > 0)
                S_Stack.Push(q.Dequeue());

            //foreach (int i in S_Stack)
            //{
            //    Console.Write(i);//5 4
            //}

            while (S_Stack.Count > 0)
                F_Stack.Push(S_Stack.Pop());
            foreach (int i in F_Stack)
            {
                Console.Write(i);
            }
            //مش عارف بيطلع معايا 45321
            #endregion

        }
    }
}

