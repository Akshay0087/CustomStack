using CustomStack;
using ICustomStackInterface;
using IInternInterface;
using JediClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackExtendedOPClass
{
    public class CustomStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(CustomStack<Jedi> stack) 
        {
            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop().NameId);
            }
        }
    }
}
