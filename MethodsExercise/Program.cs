using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");

                string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}, a few more questions.");

            Console.WriteLine("How old are you?");

                int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where do you live?");

                string location = Console.ReadLine();

            Console.WriteLine("What is your favorite hobby?");

                string hobby = Console.ReadLine();

            Console.WriteLine($"{userName}, from {location} you are {age} and your favorite hobby is {hobby}" +
                " I had a feeling I would like you, but now that I know a little more about you it confirms my suspicions.");



            static int UseParams(params int[] list)
            {
                return list.Sum();    
            }

            int Add(int x, int y)
            {
                return x + y;
            }

            int Sub(int a, int b)
            {
                return a - b;
            }

            int Multiply(int h, int j)
            {
                return h * j;
            }

            int Divide(int c, int d)
            {
                return c / d;
            }

            int Remainder(int l, int m)
            {
                return l % m;
            }

            Console.WriteLine("Let's do some addition, type in 2 numbers you want to add.");

                var mathInput1 = int.Parse(Console.ReadLine());
                var mathInput2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your answer is {Add(mathInput1, mathInput2)}.");

            Console.WriteLine("How many numbers do you want to add?");

                int userNput = Convert.ToInt32(Console.ReadLine());

                int[] myArray = new int[userNput];

            Console.WriteLine("What numbers do you want to add?");

                for (int i = 0; i < myArray.Length; i++)
                {
                    int ab = Convert.ToInt32(Console.ReadLine());

                    myArray[i] = ab;
                }

            Console.WriteLine($"Your answer is {UseParams(myArray)}.");

        }
    }
}