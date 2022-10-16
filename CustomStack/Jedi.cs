using IInternInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JediClass
{
    public class Jedi:IIntern
    {
        private string name;
        private int id;
        public string NameId => $"Jedi - {name}:{id}";

        public Jedi(string _name, int _id)
        {
            name = _name;
            id = _id;

        }

        public string GetNameId()
        {
            return NameId;
        }


    }
}
