namespace CourseExerciesCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// EvenOrOddNumber (1)
            //int number;

            //Console.WriteLine("enter a number:");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("number is even.");
            //}

            //else
            //{
            //    Console.WriteLine("number is odd.");
            //}
            ////-----------------------------------------
            ///


            //the largest Number (2)

            //int num1, num2, num3;

            //Console.WriteLine(" Enter the first number: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter the second number: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter the third number: ");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine("the largest number is " + num1);
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    Console.WriteLine("the largest number is " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("the largest number is " + num3);
            //}
            //-----------------------------------------------------------------

            //Temperature Converter (3)

            //double Celsius;
            //Console.WriteLine("enter Temperature in celsius:");
            //double celsius = double.Parse(Console.ReadLine());

            //double Fahrenheit = (celsius * 9 / 5) + 32;
            //Console.WriteLine($"{celsius} C equal to {Fahrenheit} F");

            //--------------------------------
            // Simple Discount Calculator (4)

            //Console.WriteLine("enter the price of the item ");
            //double price = double.Parse(Console.ReadLine());

            //if (price > 100)
            //{
            //    double Discount = price * 0.10;
            //    double finalprice = price - Discount;
            //    Console.WriteLine(" the finalprice after a 10% Discount is: " + finalprice);

            //}
            //else
            //{
            //    Console.WriteLine(" the finalprice is: " + price);
            //}
            //Grading System (5)
            //int score;
            //Console.WriteLine("enter the student's score ");
            //score = int.Parse(Console.ReadLine());

            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("Grade: A");

            //}
            //else if (score >= 80 && score <= 89)
            //{
            //    Console.WriteLine("Grade: B");
            //}
            //else if (score >= 70 && score <= 79)
            //{
            //    Console.WriteLine("Grade: C");

            //}
            //else if (score >= 60 && score <= 68)
            //{
            //    Console.WriteLine("Grade: D");
            //}
            //else if (score < 60 )
            //{
            //    Console.WriteLine("Grade: F");
            //}
            //else
            //{
            //    Console.WriteLine("invalid score> please enter a valid score between 0 and 100.");

            //}
            //------------------------------------

            //Swap Two Numbers (6)

            //Console.WriteLine(" enter the first number ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" enter the second number ");
            //int num2 = int.Parse(Console.ReadLine());


            //int temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine(" after swap num1:" +num1);
            //Console.WriteLine(" after swap num2:" + num2);
            //-------------------------------------------------

            //Days to Weeks and Days Converte (7)

            //Console.WriteLine(" enter the number of days: ");
            //int totaldays = int.Parse(Console.ReadLine());

            //int weeks = totaldays / 7;
            //int remainingdays = totaldays % 7;

            //Console.WriteLine(" days is equal to:" + totaldays);
            //Console.WriteLine(" week is equal to:" + remainingdays);
            //----------------------------------------------------------

            //Electricity Bill Calculator (8)

            //Console.WriteLine("enter the number of units consumed");
            //int unit =int.Parse(Console.ReadLine());

            //double bill = 0;
            //if (unit <= 100)
            //{
            //    bill = unit * 0.5;
            //}

            //else if (unit <= 300)
            //{
            //    bill = (100 * 0.5) + (unit - 100) * 0.75);
            //}
            //else
            //{
            //    bill = (100 * 0.5) + (200 * 0.75) + ((unit - 300) * 1);
            //}
            //Console.WriteLine("the total electricity bill for:" + unit);
            //Console.WriteLine("the total of unit:" + bill);

            //-------------------------------------------------------

            //// Simple Calculator (9)
            //Console.WriteLine(" enter the first number:");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter an operator (+, -, *, /): ");
            //char op = Console.ReadLine()[0];

            //Console.WriteLine(" enter the second number:");
            //double num2 = double.Parse(Console.ReadLine());

            //double result = 0;

            //if (op == '+')
            //{
            //    result = num1 + num2;
            //}
            //else if (op == '-')
            //{
            //    result = num1 - num2;
            //}

            //else if (op == '*')
            //{
            //    result = num1 * num2;
            //}
            //else if (op == '/')
            //{
            //    result = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("invalid operator");

            //}
            //----------------------------------------------
            // ----------------Simple Calculator (Switch-Case)------------------

            Console.Clear();
            Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
            Console.WriteLine("3. Multiplication\n4. Division");

            int OperationNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            int num2 = int.Parse(Console.ReadLine());

            double result = 0;

            bool isActive = false;

            switch (OperationNumber)
            {
                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:

                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero not allowed");
                        isActive = true;

                    }
                    else
                    {
                        result = num1 / num2;
                    }

                    break;

                default:
                    Console.WriteLine("Error! ");
                    isActive = true;
                    break;

            }
            if (!isActive)
            {
                Console.WriteLine(result);
            }
            //--------------------------------------------------------
            //----------------- Basic ATM System-----------------


        }
    }





        }
    

