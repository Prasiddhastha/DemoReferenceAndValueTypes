using System;
namespace DemoReferenceAndValueType
{
    public class Person
    {
        public int age =10;
    }
    class Program
    {   
      
        static void Main(string[] args)
        {
            //value type; changes to one doesnt impact other
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            //reference type : When change to one impact other
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1[0] :{array1[0]}\narray2[0] :{array2[0]}\n\n");
            // another example
            //value type
            var num = 1;
            Increment(num);
            Console.WriteLine(num);


            //reference type
            var person = new Person();
            person.age = 20;
            MakeOld(person);
            Console.WriteLine(person.age);


        }
        public static void Increment(int num)
        {
            num += 1;
        }

        public static void MakeOld(Person person )
        {
            person.age += 10;
        }
    }
}