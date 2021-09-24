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

            //Math and String section starts here
            Console.WriteLine("\t^^^^ Math Methods Practice ^^^^");
            MathString example = new MathString();
            Console.Write("Enter Double Value of value1: ");
            example.value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter negative Value of value2: ");
            example.value2 = Convert.ToDouble(Console.ReadLine());

            example.PrintMathMethods();

            Console.WriteLine("\t^^^^ Playing with Strings ^^^^");
            Console.Write("Enter Your First Name: ");
            example.firstName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Your last Name: ");
            example.lastName = Convert.ToString(Console.ReadLine());

            Console.Write("One sentence about yourself: ");
            example.sentence = Convert.ToString(Console.ReadLine());

            example.PlayingWithStrings();

            //Array starts here
            Console.WriteLine("\t^^^^ Array Practice ^^^^");
            MyArray arrayExample = new MyArray();
            arrayExample.PrintArray();

            //Method overloading examples
            
            Console.WriteLine("\t^^^^ Method Overloading Practice ^^^^");
            MyMethodOverLoading testMethod = new MyMethodOverLoading();

            Console.Write("Enter Int Value of number1: ");
            int myNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Int Value of number2: ");
            int myNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("For int value doing sum : " + testMethod.DoAsMyWish(myNum1, myNum2) + "\n");

            Console.Write("Enter double Value of number1: ");
            double myDouble1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter double Value of number2: ");
            double myDouble2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("For double value doing multiplication : " + testMethod.DoAsMyWish(myDouble1, myDouble2));

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
            Console.WriteLine("convert int to string : " + Convert.ToString(myInt));    // convert int to string
            Console.WriteLine("convert int to double : " + Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine("convert double to int : " + Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine("convert bool to string : " + Convert.ToString(myBool));  // convert bool to string
        }
    }

    class MathString
    {
        public double value1, value2;
        public string firstName, lastName, sentence, nameInterpolation;
        public int charPos;

        public void PrintMathMethods(){
            Console.WriteLine("Max between value1 & value2 : " + Math.Max(this.value1, this.value2));
            Console.WriteLine("Min between value1 & value2 : " + Math.Min(this.value1, this.value2));
            Console.WriteLine("the square root of value1 : " + Math.Sqrt(this.value1));
            Console.WriteLine("the absolute (positive) value of value2 : " + Math.Abs(this.value2));
            Console.WriteLine("The nearest round value of value1 : " + Math.Round(this.value1));
        }

        public void PlayingWithStrings(){
            Console.WriteLine("String Length of sentence:" + this.sentence.Length);
            Console.WriteLine("Upper Case of First Name :" + this.firstName.ToUpper());
            Console.WriteLine("Lower Case of last Name :" + this.lastName.ToLower());
            Console.WriteLine("Your full name :" + this.firstName + this.lastName);

            this.nameInterpolation = $"My full name is: {this.firstName} {this.lastName}";
            Console.WriteLine("Name Interpolation : " + this.nameInterpolation);

            Console.WriteLine("First charecter of your sentence:" + this.sentence[0]);
            Console.WriteLine("Last charecter of your sentence:" + this.sentence[this.sentence.Length-1]);

            this.charPos = sentence.IndexOf('M');
            Console.WriteLine("Last word of your sentence:" + this.sentence.Substring(this.charPos));

        }
    }

    class MyArray{
        public string[] countries = {"Bangladesh", "West-Indies", "New Zeland", "GreenLand", "Saudi Arabia", "UAE", "UK", "USA", "Oman"};
        public double[] numbers = {23, -12, -56.67, 4.5, 13, 3.3, 66, 7.777, 4.34, 400, -52.2525, 3442341};

        public void PrintArray(){
            Console.WriteLine("  <----- String Array before sort----->");
            for(int ptr=0; ptr<this.countries.Length; ptr++){
                Console.WriteLine(this.countries[ptr]);
            }

            Console.WriteLine("  <----- String Array after sort----->");
            Array.Sort(this.countries); // sorting array
            for(int ptr=0; ptr<this.countries.Length; ptr++){
                Console.WriteLine(this.countries[ptr]);
            }

            Console.WriteLine("  <----- Double Array before sort----->");
            for(int ptr=0; ptr<this.numbers.Length; ptr++){
                Console.WriteLine(this.numbers[ptr]);
            }

            Console.WriteLine("  <----- Double Array after sort----->");
            Array.Sort(this.numbers); //sorting array
            for(int ptr=0; ptr<this.numbers.Length; ptr++){
                Console.WriteLine(this.numbers[ptr]);
            }

        }
    }

    class MyMethodOverLoading
    {

        public int DoAsMyWish(int num1, int num2){
            return num1 + num2;
        }

        public double DoAsMyWish(double num1, double num2){
            return num1 * num2;
        }
    }

}
