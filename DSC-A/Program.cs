namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{n} * {i} = {n * i}");
            //}
            #endregion

            #region Q2
            //int n = int.Parse(Console.ReadLine());

            //int i = 1;
            //int result = 0;

            //while(i != n+1){
            //    result += i;
            //    i++;
            //}

            //Console.WriteLine(result);
            #endregion

            #region Q3
            //Console.WriteLine("How many numbers you want to enter");
            //int size = int.Parse(Console.ReadLine());
            //int[] n = new int[size];
            //int countEven = 0;
            //int countOdd = 0;
            //for (int i = 1; i-1 < size; i++)
            //{
            //    Console.Write($"Enter number {i} : ");
            //    n[i-1] = int.Parse(Console.ReadLine());
            //}
            //foreach (int i in n)
            //{
            //    if (i % 2 == 0)
            //    {
            //        countEven++;
            //    }
            //    else
            //    {
            //        countOdd++;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Even numbers = {countEven}");
            //Console.WriteLine($"Odd numbers = {countOdd}");
            #endregion

            #region Q4
            //int sum = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());

            //    if (n == 999)
            //    {
            //        Console.WriteLine("Stop signal received. Ending input early.");
            //        break;
            //    }

            //    if (n < 0)
            //    {
            //        Console.WriteLine("Negative numbers are skipped.");
            //        continue;
            //    }

            //    sum += n;
            //}

            //Console.WriteLine("Sum of valid numbers: " + sum);
            #endregion

            #region Bouns
            //int size;
            //Console.WriteLine("Enter size of array");
            //size = int.Parse(Console.ReadLine());
            //int[] nums = new int[size];
            //for (int h = 0; h < size; h++)
            //{
            //    Console.Write($"Enter number {h + 1} : ");
            //    nums[h] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter target ");
            //int target;
            //target = int.Parse(Console.ReadLine());
            //int i;
            //int j;
            //for(i= 0; i < nums.Length; i++)
            //{
            //    for(j = i+1; j < nums.Length; j++)
            //    {
            //        if(nums[i] + nums[j] == target)
            //        {
            //            Console.WriteLine($"Index1 = {i} , Index2 = {j}");
            //        }
            //    }
            //}
            #endregion
        }
    }
}
