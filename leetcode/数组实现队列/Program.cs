using System;

namespace 数组实现队列
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
           //Tree t = new Tree();
            var arr = new ArrayQueue(10);
            var ee = new int[10];
            var aa = new int[10];
            for (var s = 0; s<ee.Length;s++)
            {
                if (ee[s] == aa[s])
                {

                }
            }
                
            
            arr.enqueue("one");
            arr.enqueue("two");
            arr.enqueue("three");
            arr.printAll();
           var item =  arr.dequeue();
           var item1 =  arr.dequeue();
           var item2 =  arr.dequeue();
           var item3 =  arr.dequeue();
           Console.WriteLine("Hello World!");
        }
    }

    /**
 * Created by wangzheng on 2018/10/9.
 */
    // 用数组实现的队列
    public class ArrayQueue
    {
        // 数组：items，数组大小：n
        private string[] items;
        private int n = 0;
        // head表示队头下标，tail表示队尾下标
        private int head = 0;
        private int tail = 0;

        // 申请一个大小为capacity的数组
        public ArrayQueue(int capacity)
        {
            items = new string[capacity];
            n = capacity;
        }

        // 入队
        public bool enqueue(string item)
        {
            // 如果tail == n 表示队列已经满了
            if (tail == n) return false;
            items[tail] = item;
            ++tail;
            return true;
        }

        // 出队
        public string dequeue()
        {
            // 如果head == tail 表示队列为空
            if (head == tail) return null;
            // 为了让其他语言的同学看的更加明确，把--操作放到单独一行来写了
            var ret = items[head];
            ++head;
            return ret;
        }

        public void printAll()
        {
            for (int i = head; i < tail; ++i)
            {
                Console.WriteLine(items[i] + " ");
            }
        }
    }
}
