using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    public class Lab1
    {
        static void Main(string[] args)
        {
            // #1
            //int[] inData = new int[] { 1, 4, 7, 3, 6, 8, 2, 0, 9, 5 };
            //int[] inData2 = new int[] { 1, 4, 7, 3, 6, 8, 2, 0, 9, 5 };


            //int[] result = Sorting(inData);
            //foreach (int i in result) 
            //    Console.Write(i + " ");
            //Console.WriteLine();


            //Console.WriteLine(DoubleNum(3.45, 2));

            // #2

            //if (Palindrom("1234321"))                               
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);
            //if (Palindrom("12334321"))                               
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);
            //
            //// #3
            //
            //Console.WriteLine(Factorial(6));
            //
            //// #4
            //
            //Console.WriteLine(Fibonacci(10));
            //
            //// #5
            //
            //Console.WriteLine(DoubleNum(2.2, 3.4));                         
            //Console.WriteLine(DoubleNum(12.432, 3.344));
            //Console.WriteLine(DoubleNum(24.62, 7.33));
            //
            //// #6
            //
            //Console.WriteLine(SimpleDigit(11));                          
            //Console.WriteLine(SimpleDigit(21));

        }

        public static int[] Sorting(int[] massive)
        {
            if (massive.Length == 0)
                throw new Exception("Массив не может быть пустым! ");
            int temp;
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        temp = massive[i];
                        massive[i] = massive[j];
                        massive[j] = temp;
                    }
                }
            }
            return massive;
        }
        public static bool Palindrom(string stroka)
        {
            for (int i = 0; i < stroka.Length / 2; i++)
            {
                if (stroka[i] == stroka[stroka.Length - i - 1])
                    continue;
                else
                    return false;
            }
            return true;
        }

        public static int Factorial(int number)
        {
            if (number <= 0)
                throw new Exception("Число не может быть меньше единицы! ");
            int count = 1;
            for (int i = 1; i <= number; i++)
                count *= i;

            return count;
        }

        public static int Fibonacci(int num)
        {
            if (num < 0)
                throw new Exception("Число не может быть меньше нуля! ");
            if (num == 0)
                return 0;
            int prev = 0;
            int next = 1;
            for (int i = 1; i < num; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        public static double DoubleNum(double num, double degree) => Math.Round(Math.Pow(num, degree), 3);

        public static bool SimpleDigit(int number)
        {
            if (number <= 0)
                throw new Exception("Число не может быть меньше единицы!");
            int count = 0;
            for (int i = 1; i <= number / 2; i++) 
            {
                if (number % i == 0)
                {
                    count++;
                    if (count > 1)
                        return false;
                }
            }
            return true;  
        }
    }
}