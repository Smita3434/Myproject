using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class StudentInfo
    {
        int id;
        string name;
        int math;
        int english;
        int marathi;
        float percentage1;
        int sum;
        

        public void acceptDetails()
        {
            id = 1;
            name = "SMITA";
            math = 56;
            english = 78;
            marathi = 86;
            
        }
        public void percentage()
        {
            sum = math + english + marathi;
            percentage1 = sum / 3.0f;
            
        }
        public void display()
        {
            Console.WriteLine("ID="+id);
            Console.WriteLine("NAME="+name);
            Console.WriteLine("Sub1="+english);
            Console.WriteLine("Sub2="+math);
            Console.WriteLine("Sub3="+marathi);
            Console.WriteLine("Percentage="+percentage1);
         
            
        }
        static void Main(string[] args)
        {
            StudentInfo std = new StudentInfo();
            std.acceptDetails();
            std.display();
            std.percentage();
            

        }

    }
}
