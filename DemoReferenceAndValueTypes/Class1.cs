using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReferenceAndValueType
{
    public class Person
    {
        public int age = 10;
        public static void Increment(int num)
        {
            num += 1;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
    

}
