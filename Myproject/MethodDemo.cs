using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class MethodDemo
    {
        public void show()
        {
            Console.WriteLine("Hi i am Show");
        }
        public void addition (int a,int b)
        {
            Console.WriteLine("Addition="+(a+b));
        }
        public string myfoo()
        {
            return "Hello";
        }
        public int add()
        {
            return 10 + 30;
        }

        public float areaofcircle(int r, float PI)
        {
            float area = PI * r * r;
            return area;
        }
        static void Main(string[] args)
        {
            MethodDemo m = new MethodDemo();
            m.show();
            m.addition(7,5);

            Console.WriteLine(m.myfoo());

            int ans = m.add();
            Console.WriteLine(ans);

            float a = m.areaofcircle(4, 3.14f);
            Console.WriteLine("Area of circle="+a);

        }
    }
}
