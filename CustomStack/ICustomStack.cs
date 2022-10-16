using IInternInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomStackInterface
{
  
    public interface ICustomStack<IIntern> : ICustomStackReadonly<IIntern>
    {
        IIntern Pop();
    }


    public interface ICustomStackReadonly<in IIntern>
    {
        void Push(IIntern a);
        int Count();

    }
}
