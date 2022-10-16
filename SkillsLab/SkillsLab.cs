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


        public SkillsLab(string name, int id)
        {
            name = name;
            id = id;
           
        }



        public string GetNameId()
        {
            return NameId;
        }


    }
}
