using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            string[] mathOperations =
            {
                "add",
                "subtract",
                "multiply",
                "divide"
            };

            int chosenOperation;


            //select operation
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();

            if (int.TryParse(input, out chosenOperation) && chosenOperation >= 1 && chosenOperation <= 4)
            {
                //select numbers to operate on
                Console.WriteLine($"Enter 2 integers to {mathOperations[chosenOperation - 1]}");

                var num1 = Console.ReadLine();
                var num2 = Console.ReadLine();

                if (int.TryParse(num1, out int subNum1) && int.TryParse(num2, out int subNum2))
                {
                    //complete operation
                    int answer;
                    double divAnswer;
                    switch (input)
                    {
                        case "1":
                            answer = calculator.Add(subNum1, subNum2);
                            Console.WriteLine($"{num1} + {num2} = {answer}");
                            break;

                        case "2":
                            answer = calculator.Subtract(subNum1, subNum2);
                            Console.WriteLine($"{num1} - {num2} = {answer}");
                            break;

                        case "3":
                            answer = calculator.Multiply(subNum1, subNum2);
                            Console.WriteLine($"{num1} * {num2} = {answer}");
                            break;

                        case "4":
                            divAnswer = calculator.Divide(subNum1, subNum2);
                            Console.WriteLine($"{num1} ÷ {num2} = {divAnswer}");
                            break;

                        default:
                            Console.WriteLine("Unknown input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, one of the \"numbers\" you entered was not a number.\n" +
                            "Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Unknown input.\n" +
                            "Please try again.");
            }
        }
    }
}