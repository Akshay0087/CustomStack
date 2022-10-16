using IInternInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsLabClass
{
    public class SkillsLab:IIntern
    {
        private string name;
        private int id;
        public string NameId => $"Jedi - {name}:{id}";


        public SkillsLab(string _name, int _id)
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
