using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }

    }
    class Student:Teacher
    {
        public void learn()
        {
            Console.WriteLine("Learn");
        }

    }
    class SingleInheritance2
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.Teach();
            Student s = new Student();
            s.learn();
            s.Teach();
        }
    }
}
