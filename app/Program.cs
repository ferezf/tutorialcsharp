using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
            Console.WriteLine("Hello World! My name is Ferez");
            int x = 3, y = 4, z = 5;
            int myAge = 26;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "I am";
            //myAge = 20;
            Console.WriteLine(myText + " " + myAge + "years old");
            //type casting
            double myDouble = 9.78;
            int myInt = (int)myDouble;  // Manual casting: double to int

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //conversion
            int convInt = 10;
            double convDouble = 5.25;
            bool convBool = true;

            Console.WriteLine(Convert.ToString(convInt));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(convInt));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(convDouble));  // Convert double to int
            Console.WriteLine(Convert.ToString(convBool));   // Convert bool to string

            //Console.WriteLine("Enter username:");
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Max(2, 10));
            Console.WriteLine(Math.Min(2, 10));
            // Create a string variable and get user input from the keyboard and store it in the variable
            //string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Username is: " + userName);
            Console.WriteLine("The length of the txt string is: " + myText.Length);
            Console.WriteLine(myText.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(myText.ToLower());   // Outputs "hello world"  

            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            int myAGE = 25;
            int votingAge = 18;

            if (myAGE >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}