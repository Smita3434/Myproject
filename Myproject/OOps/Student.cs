using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class Student
    {
        private int id;
        private string name;
        private double percentage;

        public int Id
        {
            get { return id;}
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double Per
        {
            get { return percentage; }
            set { this.percentage = value; }
        }

        static void Main(string[] args)
        {
            Student s = new Student();

            Myinfo m = new Myinfo();
            m.show();

        }
    }
    class Myinfo
    {
        public void show()
        {
            Student s = new Student();
            s.Id = 102;
            Console.WriteLine(s.Id);
            s.Name = "Smita";
            Console.WriteLine(s.Name);
            s.Per = 78;
            Console.WriteLine(s.Per);
        }
    }
}
