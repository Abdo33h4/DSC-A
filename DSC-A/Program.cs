namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Area of Circle

            //const double bi = 3.141592653;
            //double R = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Area is: {bi*R*R}");
            //Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 2- Given two numbers X and Y. Print the summation and multiplication and subtraction of these 2 numbers.

            //int x, y;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{x} + {y} = {x+y}");
            //Console.WriteLine($"{x} * {y} = {x*y}");
            //Console.WriteLine($"{x} - {y} = {x-y}");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 3- Given two numbers A and B. Print "Multiples" if A is multiple of B or vice versa. Otherwise print "No Multiples".

            //int A, B;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());

            //if (A % B == 0)
            //{
            //    Console.WriteLine("Multiples");
            //}
            //else
            //{
            //    Console.WriteLine("Not Multiple");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 4- Given 3 numbers A, B and C, Print the minimum and the maximum numbers.

            //int A, B,C;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());

            //int min = A;
            //int max = A;

            //if (B < min) min = B;
            //if (C < min) min = C;

            //if (B > max) max = B;
            //if (C > max) max = C;

            //Console.WriteLine(min + " " + max);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 5- Given a letter X. Determine whether X is Digit or Alphabet and if it is Alphabet determine if it is Capital Case or Small Case.

            //char X = char.Parse(Console.ReadLine());

            //if (X >= '0' && X <= '9')
            //{
            //    Console.WriteLine("IS DIGIT");
            //}
            //else
            //{
            //    Console.WriteLine("ALPHA");

            //    if (X >= 'A' && X <= 'Z')
            //        Console.WriteLine("IS CAPITAL");
            //    else
            //        Console.WriteLine("IS SMALL");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //6 - Given a mathematical expression

            //string A_str = Console.ReadLine();
            //string[] parts = A_str.Split(' ');

            //int A = int.Parse(parts[0]);
            //char S = char.Parse(parts[1]);
            ////char S = parts[1][0];
            //int B = int.Parse(parts[2]);
            //int C = int.Parse(parts[4]);

            //int result = 0;

            //if (S == '+') result = A + B;
            //else if (S == '-') result = A - B;
            //else if (S == '*') result = A * B;

            //if (result == C)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine(result);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 7- Given 4 numbers A, B, C and D. Print the last 2 digits from their Multiplication.

            //string inputs = Console.ReadLine();
            //string[] parts = inputs.Split(' ');
            //int A = int.Parse(parts[0]);
            //int B = int.Parse(parts[1]);
            //int C = int.Parse(parts[2]);
            //int D = int.Parse(parts[3]);

            //int result = A * B * C * D;
            //Console.WriteLine(result % 100);

            // 8- Given 4 numbers A,B,C and D If A^B > C^D Print "YES" otherwise, print "NO".

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //long A, B, C, D;
            //string[] s = Console.ReadLine().Split();
            //A = long.Parse(s[0]);
            //B = long.Parse(s[1]);
            //C = long.Parse(s[2]);
            //D = long.Parse(s[3]);

            //long p1 = 1;
            //for (int i = 0; i < B; i++)
            //    p1 *= A;

            //long p2 = 1;
            //for (int i = 0; i < D; i++)
            //    p2 *= C;

            //if (p1 > p2)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 9- Write a program that allows the user to enter a number then print it

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(n);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 10- Write C# program that converts a string to an integer, but the string contains non-numeric characters

            //string s = Console.ReadLine();
            //string digits = "";

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] >= '0' && s[i] <= '9')   
            //    {
            //        digits += s[i];
            //    }
            //}

            //int number = int.Parse(digits);  
            //Console.WriteLine(number);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 11- Write C# program that Extract a substring from a given string

            //string txt = Console.ReadLine();
            //int start = int.Parse(Console.ReadLine());
            //int len = int.Parse(Console.ReadLine());

            //string res = txt.Substring(start, len);
            //Console.WriteLine(res);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 12- Write C# program that take two string variables and print them as one variable

            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();

            //string result = s1 + s2;

            //Console.WriteLine(result);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 13- Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time ) /100.

            //Console.Write("Enter Principal amount: ");
            //double principal = double.Parse(Console.ReadLine());

            //Console.Write("Enter Rate of interest (%): ");
            //double rate = double.Parse(Console.ReadLine());

            //Console.Write("Enter Time (years): ");
            //double time = double.Parse(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine("Simple Interest = " + interest);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 14- Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //Console.Write("Enter the temperature: ");
            //int temp = int.Parse(Console.ReadLine());

            //string result = (temp < 10) ? "Just Cold" :
            //                (temp > 30) ? "Just Hot" :
            //                "Just Good";

            //Console.WriteLine(result);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 15- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //int n = int.Parse(Console.ReadLine());

            //if (n % 3 == 0 && n % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            // 16- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            // 17- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //char[] Vowels = {'a','A','e','E','I','i','o','O','U','u'};
            //char c = char.Parse(Console.ReadLine());
            //bool isVowel = false;
            //for (int i = 0; i < Vowels.Length; i++)
            //{
            //    if (Vowels[i] == c)
            //    {
            //        isVowel = true;
            //        break;
            //    }
            //    i++;
            //}
            //if (isVowel == true)
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}

        }
    }
}
