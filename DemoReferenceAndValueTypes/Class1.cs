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
            Console.WriteLine(num);//check num value in Increment Method
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
            Console.WriteLine(person.age);//check num value in MakeOld Method
        }
    }
    

}
