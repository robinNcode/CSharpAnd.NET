using System.IO;
using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tAssignment - 1");
            Console.WriteLine("\t\t\t****************************");

            //Implicit casting class starts here
            MyImplicitCast imp = new MyImplicitCast();
            Console.WriteLine("\t<<< Implicit Casting >>>");
            Console.Write("Enter Age: ");
            imp.age = Convert.ToInt32(Console.ReadLine());

            imp.ImpCast();

            //Explicit casting class starts here
            MyExplicitCast Exmp = new MyExplicitCast();
            Console.WriteLine("\t<<< Explicit Casting >>>");
            Console.Write("Enter Age: ");
            Exmp.age = Convert.ToDouble(Console.ReadLine());

            Exmp.ExmpCast();

            //Type Casting Method sections starts here

            MyTypeCasting test = new MyTypeCasting();
            Console.WriteLine("\t<<< Type Casting Methods >>>");
            Console.Write("Enter Int Value of myInt: ");
            test.myInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Double Value of myDouble: ");
            test.myDouble = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Bool Value of myBool: ");
            test.myBool = Convert.ToBoolean(Console.ReadLine());

            test.TypePrint();


            Console.ReadKey();
        }
    }

    class MyImplicitCast
    {
        public int age;
        public double newAge;

        public void ImpCast(){
            Console.WriteLine("Int value : " + this.age);
            this.newAge = this.age; // Automatic casting: int to double
            Console.WriteLine("Double value : " + this.newAge);
        }
    }

    class MyExplicitCast
    {
        public double age;
        public int newAge;

        public void ExmpCast(){
            Console.WriteLine("Double value : " + this.age);
            this.newAge = (int)this.age; //Explicit Type casting
            Console.WriteLine("Int value : " + this.newAge);
        }
    }

    class MyTypeCasting
    {
        public int myInt;
        public double myDouble;
        public bool myBool;

        public void TypePrint(){
            Console.WriteLine(Convert.ToString(myInt));    
            Console.WriteLine(Convert.ToDouble(myInt));    
            Console.WriteLine(Convert.ToInt32(myDouble));  
            Console.WriteLine(Convert.ToString(myBool));  
        }
    }

}
