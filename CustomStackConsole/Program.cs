using CustomStack;
using CustomStackExtendedOPClass;
using JediClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace customStackConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              CustomStack<string> stack = new CustomStack<string>();
              stack.Push("Jedi-x");
              stack.Pop();
              stack.Push("Jedi");
              stack.Push("skillslab");

              while (stack.Count() > 0)
              {
                  Console.WriteLine(stack.Pop());
              }

              Console.ReadLine();
            */

            CustomStack<Jedi> stackJedi = new CustomStack<Jedi>();
            stackJedi.Push(new Jedi("new1", 1));
            stackJedi.Push(new Jedi("new2", 2));
            stackJedi.Push(new Jedi("new3", 3));

            CustomStackExtendedOP.DisplayAllInternsNameAndId(stackJedi);
            Console.ReadLine();


        }
    }
}
