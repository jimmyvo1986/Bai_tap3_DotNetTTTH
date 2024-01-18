// Tên học viên: Võ Lê Hồng Hạnh

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap3
{
    internal class Program
    {
        static void divideBy3()
        {
            Console.WriteLine("Enter the number: ");
            string userInput = Console.ReadLine();
            if(int.TryParse(userInput, out int intNumber))
            {
                //Check if the number is divided by 3 without a remaining
                string resultMessage = (intNumber % 3) == 0 ? $"{intNumber} can be divided by 3" :
                    $"{intNumber} can't be divided by 3";
                Console.WriteLine(resultMessage);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static void printMultiplicationTable()
        {
            Console.WriteLine("Enter the number to print multiplication table: ");
            string number = Console.ReadLine();

            if(int.TryParse(number, out int intNumber) && intNumber > 0) 
            {
                for(int i = 1; i <= intNumber; i ++)
                {
                    for (int j = 1; j <= 10; j ++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
            
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static void CalculateSumOfFactorials()
        {
            Console.WriteLine("Enter the positive number to calculate sum of factorials: ");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int intNumber) && intNumber >= 0)
            {
                long factorial = 1;
                long sum = 0;
                for(int i = 1; i <= intNumber; i ++)
                {
                    factorial *= i;
                    sum += factorial;
                }
                Console.WriteLine($"Sum of factorials from 1 to {intNumber} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static void checkPerfectSquare()
        {
            Console.WriteLine("Enter the number to check perfect square:");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int intNumber) && intNumber > 0)
            {
                double squareRoot = Math.Sqrt(intNumber);
                string result = squareRoot % 1 == 0 ? $"{intNumber} is a perfect square" :
                    $"{intNumber} is NOT a perfect square";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static void getDaysInMonth()
        {
            Console.WriteLine("Enter the month:");
            string input = Console.ReadLine();
            if (int.TryParse(input,out int  monthNumber) && monthNumber >=1 && monthNumber <= 12 )
            {
                int daysInMonth;
                switch(monthNumber) 
                { 
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        daysInMonth = 31; 
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        daysInMonth= 30; 
                        break;
                    case 2:
                        // Assume a non-leap year for simplicity
                        daysInMonth = 28;
                        break;
                    default:
                        daysInMonth = 0;
                        break;
                }

                Console.WriteLine($"Number of days in month {monthNumber}: {daysInMonth} ");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static void sumOfPower()
        {
            Console.WriteLine("Enter the positive number:");
            string input = Console.ReadLine() ;
            if(int.TryParse(input, out int powerNumber) && powerNumber >= 1)
            {
                char c = '+';
                long pow = 0;
                long sum = 0;
                string result ="";
                for (int i = 1; i <= powerNumber; i ++)
                {
                    pow = power(i);
                    sum += pow;
                    result = i != powerNumber ? result+ $"{i}^{i} " + c : result + $"{i}^{i}";
                }
                Console.WriteLine($"S = " + result + " = " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }
        static long power(long number)
        {
            long result = 1;
            for(int i = 0; i < number; i ++)
            {
                result *= number;
            }
            return result;
        }

        static void CalculateSumOfOdds()
        {
            Console.WriteLine("Enter the integer number:");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int intNumber))
            {
                int sumOfOdds = 0;
                for(int i = 1; i <= intNumber; i += 2)
                {
                    sumOfOdds += i;
                }
                Console.WriteLine($"Sum of odd numbers from 1 to {intNumber}: {sumOfOdds}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static bool isPrime(int  number) 
        {
            if(number < 2)
            {
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void displaysPrimeNumbers()
        {
            Console.WriteLine("Enter the positive integer number:");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int intNumber) && intNumber > 0)
            {
                Console.WriteLine($"Prime numbers from 1 to {intNumber} is: ");
                for (int i = 2; i <= intNumber; i++)
                {
                    if(isPrime(i))
                    {
                        Console.Write($"\t{i}");
                    }

                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static void drawRightTriangle()
        {
            Console.WriteLine("Enter the positive integer number:");
            string input = Console.ReadLine() ;
            if (int.TryParse(input,out int intNumber) && intNumber > 0)
            {
                for(int i = 1;  i <= intNumber; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }

        static int Fibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }

            int a = 0, b = 1;

            for (int i = 2; i <= num; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

        static void displayFibonacciSequence()
        {
            Console.WriteLine("Enter the positive number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intNumber) && intNumber > 0)
            {
                Console.WriteLine($"Fibonacci sequence with {intNumber} elements is:");
                for (int i = 0; i < intNumber; i++)
                {
                    Console.Write($"\t{Fibonacci(i)} ");
                }
                Console.WriteLine(); // Add a line break after displaying the sequence
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }


        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("1: Check number divided by 3 or not");
            Console.WriteLine("2: Display the multiplication table from 1 to n");
            Console.WriteLine("3: Calculate the sum of the factorials from 1 to n");
            Console.WriteLine("4: Check if the number is a perfect square number or not");
            Console.WriteLine("5: Displays the number of days in the month");
            Console.WriteLine("6: Calculate the sum of the exponents from 1 to n");
            Console.WriteLine("7: Calculate the sum of odd numbers from 1 to n");
            Console.WriteLine("8: Displays on the screen the prime numbers from 1 to n");
            Console.WriteLine("9: Draw triangle * with number of rows");
            Console.WriteLine("10: Calculate and display the Fibonacci sequence");
            Console.WriteLine("Enter number from 1 to 10 to do exercise:");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int intNumber) && intNumber >= 1 && intNumber <= 10 )
            {
                switch(intNumber)
                {
                    case 1:
                        divideBy3();
                        break;
                    case 2:
                        printMultiplicationTable();
                        break;
                    case 3:
                        CalculateSumOfFactorials(); 
                        break;
                    case 4:
                        checkPerfectSquare(); 
                        break;
                    case 5:
                        getDaysInMonth(); 
                        break;
                    case 6:
                        sumOfPower();
                        break;
                    case 7:
                        CalculateSumOfOdds();
                        break;
                    case 8:
                        displaysPrimeNumbers();
                        break;
                    case 9:
                        drawRightTriangle();
                        break;
                    case 10:
                        displayFibonacciSequence();
                        break;
                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }

            Console.ReadKey();
            
            
        }
        
        

    }
}
