using ICustomStackInterface;
using IInternInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack<T>//:ICustomStack<T> where T : IIntern
    {
        public static T[] array = new T[10];

        public static int index = 0;

        public void Push(T a)
        {
            index++;
            array[index] = a;

        }
        public T Pop()
        {
            index--;
            var a = array[index + 1];
            return a;

        }

        public int Count()
        {
            return index;
        }


    }
}
