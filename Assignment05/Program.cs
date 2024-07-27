using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Assignment05
{
    internal class Program
    {

        #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

        #region By Value

        //static void SWAP(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        #endregion


        #region By Reference

        //static void SWAP(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        #endregion



        #endregion


        #region 2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        #region By Value 

        //static void Array(int[] arr)
        //{
        //    if (arr != null)
        //    {
        //        arr[0] = 50;
        //        for (int i = 0; i < arr.Length; i++)
        //        {

        //            Console.WriteLine("Func Array =====> {0} ", arr[i]);
        //        }
        //    }
        //}

        #endregion

        #region By Reference

        //static void Array(ref int[] arr)
        //{
        //    if (arr != null)
        //    {
        //        arr[0] = 50;
        //        for (int i = 0; i < arr.Length; i++)
        //        {

        //            Console.WriteLine("Func Array =====> {0} ", arr[i]);
        //        }
        //    }
        //}


        #endregion

        #endregion


        #region 3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        //static void SumSub(int a, int b, out int Sum, out int Sub)
        //{
        //    Sum = a + b;
        //    Sub = a - b;
        //}

        #endregion


        #region 4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

        //static int Count(int x)
        //{

        //    int sum = 0;

        //    while (x > 0)
        //    {
        //        sum += x % 10;
        //        x /= 10;
        //    }

        //    return sum;

        //}


        #endregion


        #region 5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:


        //static bool IsPrime(int x)
        //{
        //    if (x <= 1) return false;
        //    if (x == 2) return true; 

        //    int count = 0;
        //    for (int i = 1; i <= x; i++)
        //    {
        //        if (x % i == 0)
        //        {
        //            count++;
        //        }
        //    }

        //    if (count == 2) { return true; }

        //    return false;
        //}

        #endregion


        #region 6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        //static void MinMaxArray(int[] arr , out int Max , out int Min)
        //{
        //    Max = arr[0];
        //    Min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if(arr[i] < Min)
        //        {
        //            Min = arr[i];
        //        }

        //        if (arr[i] > Max)
        //        {
        //            Max = arr[i];
        //        }
        //    }

        //}

        #endregion


        #region 7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        //static long Fact(int n)
        //{

        //    long result = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}

        #endregion


        #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

        //static string ChangeChar(string original, int position, char newChar)
        //{
        //    if (position < 0 || position >= original.Length)
        //        throw new ArgumentOutOfRangeException(nameof(position), "Position is out of the string's range.");

        //    char[] chars = original.ToCharArray();

        //    chars[position] = newChar;

        //    return new string(chars);
        //}

        #endregion

        static void Main()
        {

            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // By Value  ===> It will not change or modify the original variable, it only controls itself.
            // By Reference ===> It changes and modifies the original variable because it has its own reference.

            //Example

            #region By Value

            //int A = 10, B = 20;
            //Console.WriteLine("A = {0} \nB = {1}", A, B);
            //SWAP(A, B);
            //Console.WriteLine("============ After Swap ============");
            //Console.WriteLine("A = {0} \nB = {1}", A, B);

            #endregion

            #region By Reference

            //int A = 10, B = 20;
            //Console.WriteLine("A = {0} \nB = {1}", A, B);
            //SWAP(ref A, ref B);
            //Console.WriteLine("============ After Swap ============");
            //Console.WriteLine("A = {0} \nB = {1}", A, B);


            #endregion

            #endregion

            #region 2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.


            /*
             Both give the same result but with a different way of working

             In the case of the value, the variable in the function has the reference to the array

            But in the case of the reference, 
            the variable in the function during its operation changes the name of the array to the name of the variable in the function,
            meaning it is the same as the array,
            and after the function ends,
            the name of the array is returned 
             */


            //Example

            #region By Value

            //int[] Numbers = { 1, 2, 3, 4 };
            //Console.WriteLine("Numbers Array ====> {0}", Numbers[0]);
            //Console.WriteLine("======== After Edit ========");
            //Array(Numbers);
            //Console.WriteLine("Numbers Array ====> {0}", Numbers[0]);

            #endregion

            #region By Reference

            //int[] Numbers = { 1, 2, 3, 4 };
            //Console.WriteLine("Numbers Array ====> {0}", Numbers[0]);
            //Console.WriteLine("======== After Edit ========");
            //Array(ref Numbers);
            //Console.WriteLine("Numbers Array ====> {0}", Numbers[0]);


            #endregion



            #endregion

            #region 3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


            //int a = 10, b = 5 , Sum , Sub;
            //SumSub(a , b , out Sum , out Sub);
            //Console.WriteLine("Sum Of Numbers ===> {0} \nSub Of Numbers ===> {1}" , Sum , Sub);

            #endregion

            #region 4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //int x;

            //Console.WriteLine("Please Enter a Number");

            //if (int.TryParse(Console.ReadLine(), out x))
            //{
            //    int res = Count(x);
            //    Console.WriteLine("The sum of the digits of the number {0} is : {1}", x ,res);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            #endregion

            #region 5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //int x;

            //Console.WriteLine("Please Enter a Number");

            //if (int.TryParse(Console.ReadLine(), out x))
            //{
            //    bool res = IsPrime(x);
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}


            #endregion

            #region 6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


            //int[] Numbers = { 1, 2, 3, -5 , 0 , 504,  4, 5, 6 };
            //int Max, Min;
            //MinMaxArray(Numbers, out Max, out Min);
            //Console.WriteLine("Max Of Array ===> {0} \nMin Of Array ===> {1}" , Max , Min);

            #endregion

            #region 7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int x;

            //Console.WriteLine("Please Enter a Number");

            //if (int.TryParse(Console.ReadLine(), out x))
            //{
            //    long res = Fact(x);
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}



            #endregion

            #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //string result = ChangeChar("hello", 1, 'a');

            //Console.WriteLine(result); 



            #endregion
        }
    }
    
}
