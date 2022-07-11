using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class Department
    {
        int did;
        string dname;
        public Department(int did, string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void show()
        {
            Console.WriteLine(did + " " + dname);
        }

    }
    class Empolyee
    {
        int id;
        string name;
        Department dept;
        public Empolyee(int id,string name,Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;

        }
        void diplay()
        {
            Console.WriteLine(id + " " + name + " ");
            dept.show();

        }
        static void Main(string[] args)
        {

            Department d = new Department(1, "sales");
           // Employee e = new Empolyee(101,"smita",d);
           // e.display();

        }

    }


    
  
    
}
