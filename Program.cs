using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_4__
{
    class Program
    {
        static void Main(string[] args)
        {   //a
            ValueTuple<string, int, char, ulong> student = (name1:"Nastya", age1:18, surname1:'S', year1:1999);

            //b

            var me = (one: "Nastya", two: "Sakun", three: 18, foure:1999);
            string name = me.one;
            string surname = me.two;
            int age = me.three;
            ulong year= 1999;

            //c

            Console.WriteLine("\0My name: "+name+"\n My surname: "+surname+"\n my age: "+age+"\0"+year);
            Console.WriteLine(" I am " + name + "\0" + surname);

            //d

            var(one,two,three,foure) =me ;
            var (name1, age1, surname1,year1) = student;

            //e

            Console.WriteLine("\0"+name.Equals(name1));

        }
    }
}
