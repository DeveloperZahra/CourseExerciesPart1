using System;
using System.Diagnostics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseExerciesCsharp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("\nSelect a Program:");
            //    Console.WriteLine("1. Simple Calculator");
            //    Console.WriteLine("2. Basic ATM System");
            //    Console.WriteLine("3. Geometry Calculator");
            //    Console.WriteLine("4. Factorial of a Number");
            //    Console.WriteLine("5. Sum of Even and Odd Numbers");
            //    Console.WriteLine("6. Scientific Calculator");
            //    Console.WriteLine("7. Print Triangle Pattern");
            //    Console.WriteLine("8. Print Pyramid Pattern");
            //    Console.WriteLine("9. Print Diamond Pattern");
            //    Console.WriteLine("10. Guess the Number Game");
            //    Console.WriteLine("0. Exit");

            //    Console.Write("Enter your choice: ");
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1: SimpleCalculator(); break;
            //        case 2: BasicATMSystem(); break;
            //        case 3: GeometryCalculator(); break;
            //        case 4: FactorialOfANumber(); break;
            //        case 5: SumOfEvenAndOddNumbers(); break;
            //        case 6: ScientificCalculator(); break;
            //        case 7: PrintPattern(); break;
            //        case 8: PrintAPyramidPattern(); break;
            //        case 9: PrintADiamondPattern(); break;
            //        case 10: GuessGame(); break;
            //        case 0: return;
            //        default: Console.WriteLine("Invalid Choice! Try again."); break;
            //    }
            //    Console.ReadLine();
            //}
        }
            //---------Part (3) -------------

            //---------Array Initialization & Output (1)----------
            static void ArrayInitializationAndOutput()
        {
            int[] arr = { 20, 25, 30, 35, 40 };

            Console.WriteLine("Array Elements:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }



        //------------Find Maximum & Minimum in an Array (2)---------

        //int[] numbers = new int[10];
        //Console.WriteLine("Please Enter 10 numbers:\n  ");
        //for (int i=0; i < 10; i++)
        //{
        //    Console.Write("Enter numbers: \n" + i + 1);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        //int max = numbers[0];
        //int min = numbers[0];
        //for (int i=1; i < 10; i++)
        //{
        //    if (numbers[i] > max)
        //    {
        //        max = numbers[i];
        //    }
        //    if (numbers[i] < min)
        //    {
        //        min = numbers[i];
        //    }
        //}
        //Console.WriteLine("the maximum value is:\n" +max);
        //Console.WriteLine("the minimum value is:\n" + min);

        //-----------Count Even & Odd Numbers (3)-----------

        //Console.Write("Enter the number of  elements:" );
        //int N = int.Parse(Console.ReadLine());
        //int[] numbers = new int[N];
        //Console.WriteLine("Please Enter numbers: " +N);

        //for (int i = 0; i < N; i++)
        //{
        //    Console.Write("Enter numbers: " + i + 1);
        //     numbers[i] = int.Parse(Console.ReadLine());
        //}

        //int EvenCount = 0;
        //int OddCount = 0;

        //if (N % 2 == 0)
        //{
        //    Console.WriteLine("number is even." + EvenCount);
        //}

        //else
        //{
        //    Console.WriteLine("---------------------------------");
        //}
        //-----------------Reverse an Array (4)------------
        //Console.Write("Enter the number of elements: ");
        //int N = int.Parse(Console.ReadLine());


        //int[] arr = new int[N];

        //Console.WriteLine("Enter the elements:");

        //for (int i = 0; i < N; i++)
        //{
        //    Array.Reverse(arr);

        //    {
        //        Console.Write(N + " ");

        //    }
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Reversed Array:");

        //-------Search for a Number in an Array (5)----------

        //Console.Write("Enter the number of elements: ");
        //int N = int.Parse(Console.ReadLine());


        //int[] arr = new int[N];


        //Console.WriteLine("Enter the elements:");
        //for (int i = 0; i < N; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}


        //Console.Write("Enter the number to search for: ");
        //int searchNumber = int.Parse(Console.ReadLine());


        //int index = Array.IndexOf(arr, searchNumber);


        //if (index != -1)
        //{
        //    Console.WriteLine("Number :" +searchNumber, "found at index" +index);
        //}
        //else
        //{
        //    Console.WriteLine("Number {searchNumber} not found in the array.");
        //}
        //------------Sorting an Array (Ascending Order) (6)-----------------
        //Console.Write("Enter the number of elements:  ");
        //int N = int.Parse(Console.ReadLine());
        //int[] numbers = new int[N];

        //Console.WriteLine("Enter numbers:" + N);

        //for (int i=0; i<N; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());

        //}
        //Array.Sort(numbers);
        //Console.WriteLine("the number in ascending order are:  \n");

        //for (int i = 0; i < N; i++)
        //{
        //    Console.WriteLine("numbers is:" + numbers[ i]); 

        //}

        //---------------Merging Two Arrays (7)----------------

        Console.Write("Enter the size for each array:     ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            Console.WriteLine("Enter element for  the first array :    " +n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter elemnt: " + i + 1);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element for  the second array :    " + n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter elemnt: " + i + 1);
                array2[i] = int.Parse(Console.ReadLine());
            }

        




        //------------Part( 1 )--------------
        //------------- EvenOrOddNumber (1)----------
        static void EvenOrOddNumber()

        {
            int number;

            Console.WriteLine("enter a number:");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("number is even.");
            }

            else
            {
                Console.WriteLine("---------------------------------");
            }


        }


        //---------the largest Number (2)------------
        static void largestNumber()
        {

            Console.WriteLine(" Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = num1;

            if (largest > num2)
            {
                if (largest > num3)
                    Console.WriteLine("The largest number is:" + largest);
            }
            else
            {
                largest = num2;

                if (largest > num3)
                    Console.WriteLine("The largest number is:" + largest);
                else
                    Console.WriteLine("The largest number is:" + num3);

            }

        }


        //----------Temperature Converter (3)--------------
        static void TemperatureConverter()

        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            Console.WriteLine("-------------------------------------------------");
        }


        //------------- Simple Discount Calculator (4)----------
        static void SimpleDiscountCalculator()
        {
            Console.Write("enter the price of the item ");
            double price = double.Parse(Console.ReadLine());

            double discount = 0;

            double finalPrice;

            if (price > 100)
            {
                discount = (price / 100) * 10;
                finalPrice = price - discount;
                Console.WriteLine("Final price is:" + finalPrice);

            }
            else
            {
                Console.WriteLine("Final price is:" + price);

            }

            Console.WriteLine("-------------------------------------------------");
        }


        //------------Grading System (5)-------------------
        static void GradingSystem()
        {
            int score;
            Console.Write("enter the student's score ");
            score = int.Parse(Console.ReadLine());
            char grade;

            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else if (score >= 60)
                grade = 'D';
            else
                grade = 'F';
            {
                Console.WriteLine("The student's grade is: " + grade);
                Console.WriteLine("-------------------------------------------------");
            }

        }


        //-------------Swap Two Numbers(6)---------------
        static void SwapTwoNumbers()
        {
            Console.WriteLine(" enter the first number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" enter the second number ");
            int num2 = int.Parse(Console.ReadLine());


            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(" after swapping:  first number = " + num1 + " , second number =" + num2);
            Console.WriteLine(" --------------------------------------------------------------");
        }


        //------Days to Weeks and Days Converte (7)------
        static void DaystoWeeksandDaysConverte()
        {
            Console.WriteLine(" enter the number of days: ");
            int totaldays = int.Parse(Console.ReadLine());

            int weeks = totaldays / 7;
            int remainingdays = totaldays % 7;

            Console.WriteLine(totaldays + " days = " + weeks + " week(s) and " + remainingdays + " day(s)");
            Console.WriteLine("-------------------------------------------------");
        }

        //--------Electricity Bill Calculator (8)--------
        static void ElectricityBillCalculator()

        {
            Console.WriteLine("enter the number of units consumed");
            int unit = int.Parse(Console.ReadLine());

            double bill = 0;
            if (unit <= 100)
            {
                bill = unit * 0.5;
            }

            else if (unit <= 300)
            {
                bill = (100 * 0.5) +( (unit - 100) * 0.75);
            }
            else
            {
                bill = (100 * 0.5) + (200 * 0.75) + ((unit - 300) * 1);
            }
            Console.WriteLine("the total electricity bill for:" + unit);
            Console.WriteLine("the total of unit:" + bill);
        }


        //-------Simple Calculator (9)--------
        static void SimpleCalculator()
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.Write("\nEnter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine("Result: {num1 + num2}"); break;
                case '-': Console.WriteLine("Result: {num1 - num2}"); break;
                case '*': Console.WriteLine("Result: {num1 * num2}"); break;
                case '/': Console.WriteLine(num2 != 0 ? "Result: {num1 / num2}" : "Error: Division by zero!"); break;
                default: Console.WriteLine("Invalid operator!"); break;
            }
        }

        //---------------Part( 2 ) -----------------------
        // ----------------Simple Calculator (Switch-Case) (1)------------------
        static void SimpleCalculatorSwitchCase()
        {
            char choice;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
                Console.WriteLine("3. Multiplication\n4. Division");

                int OperationNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number :");
                int FirstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number :");
                int SecondNumber = int.Parse(Console.ReadLine());


                double result = 0;

                bool isActive = false;

                switch (OperationNumber)
                {


                    case 1:
                        result = FirstNumber + SecondNumber;
                        break;

                    case 2:
                        result = FirstNumber - SecondNumber;
                        break;

                    case 3:
                        result = FirstNumber * SecondNumber;
                        break;

                    case 4:

                        if (SecondNumber == 0)
                        {
                            Console.WriteLine("Division by zero not allowed");
                            isActive = true;

                        }
                        else
                        {
                            result = FirstNumber / SecondNumber;
                        }

                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        isActive = true;
                        break;
                }


                if (!isActive)
                {
                    Console.WriteLine(result);
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');

            Console.WriteLine("\ngood bye");
        }


        //----------------- Basic ATM System (2)-----------------
        static void BasicATMSystem()
        {
            double balance = 1000;
            while (true)
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = double.Parse(Console.ReadLine());
                        if (withdraw > balance) Console.WriteLine("Insufficient funds!");
                        else { balance -= withdraw; Console.WriteLine($"Withdrawal successful! New balance: {balance}"); }
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double deposit = double.Parse(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine("Deposit successful! New balance: {balance}");
                        break;
                    case 3:
                        Console.WriteLine("Current Balance: {balance}");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }


        //------------------- Geometry Calculator (3)------------
        static void GeometryCalculator()
        {
            Console.WriteLine("Choose a shape to calculate:");
            Console.WriteLine("1. Circle (Calculate Area & Circumference)\n");
            Console.WriteLine("2. Square (Calculate Area & Perimeter)\n ");
            Console.WriteLine("3. Triangle (Calculate Area)\n ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {Math.PI * r * r}, Circumference: {2 * Math.PI * r}");
                    break;
                case 2:
                    Console.Write("Enter side length: ");
                    double s = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {s * s}, Perimeter: {4 * s}");
                    break;
                case 3:
                    Console.Write("Enter base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {0.5 * b * h}");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        //--------------Factorial of a Number (4)-----------------
        static void FactorialOfANumber()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            Console.WriteLine("Factorial: {fact}");

        }

        //-----------------Sum of Even and Odd Numbers (5)----------------
        static void SumOfEvenAndOddNumbers()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0, sumOdd = 0;
            for (int i = 1; i <= n; i++)
                if (i % 2 == 0) sumEven += i; else sumOdd += i;
            Console.WriteLine($"Sum of Even: {sumEven}, Sum of Odd: {sumOdd}");
        }


        //-----------Scientific Calculator (Switch-Case & Math Functions) (6)---------
        static void ScientificCalculator()
        {
            Console.Write("Choose operation (sin, cos, tan, sqrt, log, pow): ");
            string op = Console.ReadLine();
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "sin": Console.WriteLine("Result: {Math.Sin(num)}"); break;
                case "cos": Console.WriteLine("Result: {Math.Cos(num)}"); break;
                case "tan": Console.WriteLine("Result: {Math.Tan(num)}"); break;
                case "sqrt": Console.WriteLine("Result: {Math.Sqrt(num)}"); break;
                case "log": Console.WriteLine("Result: {Math.Log(num)}"); break;
                case "pow":
                    Console.Write("Enter exponent: ");
                    double exp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {Math.Pow(num, exp)}");
                    break;
                default: Console.WriteLine("Invalid operation!"); break;
            }
        }


        //---------------------Print Pattern (For Loop) (7)--------
        static void PrintPattern()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('*', i));

        }

        //-------------- Print a Pyramid Pattern (For Loop) (8)---------
        static void PrintAPyramidPattern()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        }

        //--------------Print a Diamond Pattern (For Loop) (9)----
        static void PrintADiamondPattern()
        {
            Console.WriteLine("enter number of rows : ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        //-----------------Guess Game (10)--------------
        static void GuessGame()
        {
            Random rand = new Random();
            int target = rand.Next(1, 101);

            int guess;

            do
            {
                Console.Write("Guess the number (1-100): ");
                guess = int.Parse(Console.ReadLine());


                if (guess > target)
                    Console.WriteLine("Try Lower!");
                else if (guess < target)
                    Console.WriteLine("Try Higher!");
                else
                    Console.WriteLine("You Win!");


            } while (guess != target);
        }
    }
}

        
        


    
    


        
    








        
    

