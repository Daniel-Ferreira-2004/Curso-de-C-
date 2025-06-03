using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_24
{
    public class Person
    {
        public string Name;
        public int Age;

        public string IfLegalPerson(int age, string name)
        {
            string result = string.Empty;

            if (age >= 18)
            {
                result = "O(a) " + name +" é maior de idade.";
                return result;
            }
            else
            {
                result = "O(a) " + name + " é menor de idade.";
                return result;
            }
        }
    }
}
