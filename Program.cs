using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tType Casting Assignment");
            Console.WriteLine("\t\t\t---------------------------------------------");

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
            this.newAge = (int)this.age; // Automatic casting: int to double
            Console.WriteLine("Int value : " + this.newAge);
        }
    }

}
