using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    
    class Address 
    {
        int pincode;
        string cname;
        string sname;

        public Address(int pincode,string cname,string sname)
        {
            this.pincode = pincode;
            this.cname = cname;
            this.sname = sname;
        }
        public void show()
        {
            Console.WriteLine(pincode+" "+cname+" "+sname+" ");
            
        }

        class Person
        {
            int id;
            string name;
            Address add;

            public Person(int id, string name, Address add)
            {
                this.id = id;
                this.name = name;
                this.add = add;
            }
            void display()
            {
                Console.WriteLine(id+" "+name);
                
                add.show();
            }
            static void Main(string[] args)
            {
                Address a = new Address(412216, "pune", "maharashtra");
                Person p = new Person(123, "Rohan", a);
                p.display();

            }
        }


    }
}
