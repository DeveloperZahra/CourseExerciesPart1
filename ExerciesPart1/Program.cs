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
               int  num1 = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter the second number: ");
               int  num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter the third number: ");
               int  num3 = int.Parse(Console.ReadLine());

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
                    bill = (100 * 0.5) + (unit - 100) * 0.75);
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
                    case '+': Console.WriteLine($"Result: {num1 + num2}"); break;
                    case '-': Console.WriteLine($"Result: {num1 - num2}"); break;
                    case '*': Console.WriteLine($"Result: {num1 * num2}"); break;
                    case '/': Console.WriteLine(num2 != 0 ? $"Result: {num1 / num2}" : "Error: Division by zero!"); break;
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
            static void BasicATMSystem ()
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
                            Console.WriteLine($"Deposit successful! New balance: {balance}");
                            break;
                        case 3:
                            Console.WriteLine($"Current Balance: {balance}");
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
                        Console.WriteLine($"Area: {Math.PI * r * r}, Circumference: {2 * Math.PI * r}");
                        break;
                    case 2:
                        Console.Write("Enter side length: ");
                        double s = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Area: {s * s}, Perimeter: {4 * s}");
                        break;
                    case 3:
                        Console.Write("Enter base: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Area: {0.5 * b * h}");
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
                Console.WriteLine($"Factorial: {fact}");

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

            
            //-----------Scientific Calculator (Switch-Case & Math Functions)---------

            //Console.WriteLine("Scientific Calculator");
            //Console.WriteLine("Choose an operation");
            //Console.WriteLine("1. sin (sine)");
            //Console.WriteLine("2. cos (cosine)");
            //Console.WriteLine("3. tan (tangent)");
            //Console.WriteLine("4. sqrt (Square Root)");
            //Console.WriteLine("5. log (logarithm)");
            //Console.WriteLine("6. pow (Power)");


            //Console.WriteLine("Enter the number corresponding to your choice (1-6):");
            //string operation = Console.ReadLine();

            //switch (operation)
            //{

            //    case "1":
            //        Console.WriteLine("Enter the angle in degrees:");
            //        double angleSin = double.Parse(Console.ReadLine());
            //        double SinResult = Math.Sin(angleSin * Math.PI / 180);
            //        Console.WriteLine("sin  + angleSin = SinResult");
            //        break;

            //    case "2":
            //        Console.WriteLine("Enter the angle in degrees:");
            //        double angleCos = double.Parse(Console.ReadLine());
            //        double CosResult = Math.Cos(angleCos * Math.PI / 180);
            //        Console.WriteLine("Cos  + angleCos = CosResult");
            //        break;

            //    case "3":
            //        Console.WriteLine("Enter the angle in degrees:");
            //        double angleTan = double.Parse(Console.ReadLine());
            //        double TanResult = Math.Cos(angleTan * Math.PI / 180);
            //        Console.WriteLine("Tan  + ngleTan = TanResult");
            //        break;

            //    case "4":
            //        Console.WriteLine("Enter the number to find the square root of:");
            //        double sqrtNum  = double.Parse(Console.ReadLine());
            //       if (sqrtNum < 0 )
            //        {
            //            Console.WriteLine(" Cannot calculate the square root of a negative number."); 
            //        }
            //       else
            //        {
            //            double sqrtResult = double.Parse(Console.ReadLine());
            //            Console.WriteLine("sqrt +sqrtNum = sqrtResult ");
            //        }
            //        break;

            //    case "5":
            //        Console.WriteLine("Enter the number to find the logarithm of ( base 10):");
            //        double logNum = double.Parse(Console.ReadLine());
            //        if (logNum <= 0)
            //        {
            //            Console.WriteLine(" logarithm is not defined for zero or negative numbers.");
            //        }
            //        else
            //        {
            //            double logResult = double.Parse(Console.ReadLine());
            //            Console.WriteLine("log +logNum = logResult ");
            //        }
            //        break;

            //    case "6":
            //        Console.WriteLine("Enter the base  number :");
            //        double baseNum = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter the exponent:");
            //        double exponent = double.Parse(Console.ReadLine());
            //        double powResult = Math.Pow(baseNum , exponent);
            //        Console.WriteLine("raised to the power of  +exponent = powResult ");
            //        break;

            //    default:
            //           Console.WriteLine("Invalid choice. Please enter a number between 1 and 6. ");
            //     break;
            //}
            //-------------------------------------------------------
            //---------------------Print Pattern (For Loop)--------

            // int i, j;

            // Console.WriteLine("Printing number of N: \n");
            //int N  = int.Parse(Console.ReadLine());


            // for (i = 1; i <= 5; i++)
            // {

            //     for (j = 1; j <= i; j++)

            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }

            //--------------------------------------------------------------
            //-------------- Print a Pyramid Pattern (For Loop)---------

            //Console.WriteLine("enter number of rows : ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //---------------------------------------------------------
            //--------------Print a Diamond Pattern (For Loop)----

            //Console.WriteLine("enter number of rows : ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //--------------------------------------------------




        }


    }
    } 


        
    








        
    

