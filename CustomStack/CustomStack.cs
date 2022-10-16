using ICustomStackInterface;
using IInternInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack<T> :ICustomStack<IIntern> 
    {
        public IIntern[] array;

        public int index ;


        public CustomStack()
        {
            array = new IIntern[10];
            index = 0;
        }

        public void Push(IIntern a)
        {
            index++;
            array[index] = a;

        }
        public IIntern Pop()
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
