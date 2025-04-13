using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry
{
    internal class Entity
    {
        public string surname { get; }
        public string name { get; }
        public string middle_name { get; }
        public string inn { get; }
        public string ogrn { get; }
        public string sign { get; }

        public Entity(string surname, string name,
            string middle_name, string inn, string ogrn, string sign)
        {
            this.surname = surname;
            this.name = name;
            this.middle_name = middle_name;
            this.inn = inn;
            this.ogrn = ogrn;
            this.sign = sign;
        }
    }
}
