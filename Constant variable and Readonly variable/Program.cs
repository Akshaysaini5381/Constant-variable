using System;

namespace Constant_variable_and_Readonly_variable
{
    class Program
    {
        // constant variable
        const int num = 100;
        Program()
        {
            Console.WriteLine("Constructor Calling :" + num);
        }
        void show()
        {
            Console.WriteLine("Non-Static Method :"+num);
        }
        static void show1()
        {
            Console.WriteLine("Static Method :" + num);
        }

                                 
        static void Main(string[] args)
        {
        
            // constructor calling
            Program obj = new Program();

            // non-static method calling
            obj.show();
            // static method calling
            Program.show1();

            // constant variable  ya local variable 
            const string name = "akshay";
            Console.WriteLine("Constant Variable :"+num);
            Console.WriteLine("Local Variable :" + name);

        }
    }
}
