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

            //Console.Clear();
            //Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
            //Console.WriteLine("3. Multiplication\n4. Division");

            //int OperationNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter first number :");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number :");
            //int num2 = int.Parse(Console.ReadLine());

            //double result = 0;

            //bool isActive = false;

            //switch (OperationNumber)
            //{
            //    case 1:
            //        result = num1 + num2;
            //        break;

            //    case 2:
            //        result = num1 - num2;
            //        break;

            //    case 3:
            //        result = num1 * num2;
            //        break;

            //    case 4:

            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Division by zero not allowed");
            //            isActive = true;

            //        }
            //        else
            //        {
            //            result = num1 / num2;
            //        }

            //        break;

            //    default:
            //        Console.WriteLine("Error! ");
            //        isActive = true;
            //        break;

            //}
            //if (!isActive)
            //{
            //    Console.WriteLine(result);
            //}
            //--------------------------------------------------------
            //----------------- Basic ATM System-----------------
            //char choice;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter the ATM_System balance :\n1. Withdraw Money\n2. Deposit Money ");
            //    Console.WriteLine("3. Check Balance\n4. Exit ");

            //    double balance = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Please select an option (1/2/3/4):");
            //    int Amount  = int.Parse(Console.ReadLine());
            //    balance = 1000;

            //    switch (Amount)
            //    {
            //        case '1':
            //            Console.WriteLine("Enter amount to Withdraw Money ");
            //            double WithdrawAmount = double.Parse(Console.ReadLine());

            //            if (WithdrawAmount > balance)
            //            {
            //                Console.WriteLine("insufficient");
            //            }
            //            else
            //            {
            //                balance -= WithdrawAmount;
            //                Console.WriteLine("Withdraw successful!  New balance :");
            //            }
            //            break;

            //        case '2':
            //            Console.WriteLine("Enter amount to Deposit Money ");
            //            double DepositAmount = double.Parse(Console.ReadLine());
            //            balance += DepositAmount;
            //            Console.WriteLine("Deposit successful!  New balance :");
            //            break;
            //        case '3':
            //            Console.WriteLine("your current balance is:");
            //            break;

            //        case '4':
            //            Console.WriteLine("Exiting... thank you for using the ATM system.");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid option, Please try again.");

            //            break;
            //    }
            //    Console.WriteLine("Do you want another options ? y / n");
            //    choice = Console.ReadKey().KeyChar;


            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("\ngood bye");
            //----------------------------------------------------
            //------------------- Geometry Calculator------------

            Console.WriteLine("Geometry Calculator");
            Console.WriteLine("Choose a shape to calculate:");
            Console.WriteLine("1. Circle (Calculate Area & Circumference)\n");
            Console.WriteLine("2. Square (Calculate Area & Perimeter)\n ");
            Console.WriteLine("3. Triangle (Calculate Area)\n ");

            Console.WriteLine("Enter the number corresponding to your shape choice:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the redius of the circle:");
                    double redius = double.Parse(Console.ReadLine());
                    double areaCircle = Math.PI * Math.Pow(redius, 2);
                    double CircumferenceCircle = 2 * Math.PI * redius;
                    Console.WriteLine("area of the Circle: ");
                    Console.WriteLine("Circumference of the Circle: ");
                    break;

                case "2":
                    Console.WriteLine("Enter the side length of the Square:");
                    double side = double.Parse(Console.ReadLine());
                    double AreaSquare = Math.Pow(side, 2);
                    double PerimeterSquare = 4 * side;
                    Console.WriteLine("area of the Square: ");
                    Console.WriteLine("Perimeter of the Square: ");
                    break;

                case "3":

                    Console.WriteLine("Enter the base  of the Triangle :");
                    double baseTrinagle  = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height  of the Triangle :");
                    double heightTriangle  = double.Parse(Console.ReadLine());
                    double areaTriangle  = 0.5 * baseTrinagle * heightTriangle;
                    Console.WriteLine("area of the triangle : ");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option. ");
                    break;





            }

        }
    } 


        }
    








        
    

