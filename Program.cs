namespace assignment_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                int choice;

                do
                {
                    Console.WriteLine("\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
                    Console.Write("Choose an option (1-5): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 5)
                    {
                        Console.WriteLine("You have exited the program....");
                        break;
                    }

                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine("Result: " + result);
                            break;
                        case 2:
                            result = num1 - num2;
                            Console.WriteLine("Result: " + result);
                            break;
                        case 3:
                            result = num1 * num2;
                            Console.WriteLine("Result: " + result);
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine("Result: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Error:cannot divide by 0");
                            }
                            break;
                    }

                } while (true);
            }
        }
    }