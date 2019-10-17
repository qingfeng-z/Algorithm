using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class LeetCode最小栈
    {

        /**
        * Your MinStack object will be instantiated and called as such:
        * MinStack obj = new MinStack();
        * obj.Push(x);
        * obj.Pop();
        * int param_3 = obj.Top();
        * int param_4 = obj.GetMin();
        */

        /** initialize your data structure here. */

        private Stack stack;
        public LeetCode最小栈()
        {
           var stack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (stack.Count<0)
            {
                stack.Push(x);
                stack.Push(x);
            }
            else
            {
                int tmp = (int)stack.Peek();
                stack.Push(x);
                if (tmp < x)
                {
                    stack.Push(tmp);
                }
                else
                {
                    stack.Push(x);
                }
            }
        }

        public void Pop()
        {
            stack.Pop();
            stack.Pop();
        }

        public int Top()
        {
            return 1;
            //return stack.Get(stack.Count - 2);
        }

        public int GetMin()
        {
            return 1;
        }

    }
}
