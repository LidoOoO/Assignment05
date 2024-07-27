namespace Demo
{
    internal class Program
    {

        #region Functions

        public static void PrintShape()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("(*_*)");

        }

        public static void PrintShape(int count = 10, string pattern = "*_*")
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(pattern);

        }


        static void SWAP(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        static int SumArray(params int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            }
            return sum;
        }


        static void SumMul(int x, int y, ref int Sum, ref int Mul)
        {
            Sum = x + y;
            Mul = x * y;
        }



        #endregion
        static void Main()
        {
            #region Boxing , UnBoxing

            #region Ex01
            //object O1;
            //O1 = "Ahmed"; //Casting

            //O1 = 1; //Casting [value type -> reference type] boxing

            //O1 = 'a'; 
            #endregion


            #region Ex02

            //int x = 10;
            //object obj = x; //Boxing [Safe Casting]
            ////obj = new object(10);


            //object obj02 = 10;
            //int y = (int)obj02; //Casting UnBoxing [UnSafe Casting]

            //Console.WriteLine(y);

            #endregion

            #endregion

            #region Nullable - Value Types

            #region Value type 

            #region Ex01

            ////int x = null; // Invalid
            //////int x allow only int numbers

            ////int? y = null;// Valid
            ////// int y allow int Values OR Null

            //int? Y = null;
            //int X = 10;
            ////int? Z = Y; // Valid
            ////int? Z = X; // Valid

            //int? number = null; //nullable<int> Number;
            //                    //Nullable -> Allow Null + Values


            ////decimal Num01 = 1.1M;
            ////decimal? Num02 = Num01; 

            //decimal? Num01 = null;
            //decimal Num02 = null;  
            #endregion

            #region Ex02

            //int X = 10;

            //int? Y = /*(int?)*/ X; //Valid Implicit Casting

            //// Safe Casting

            //int? Number01 = null;
            //int  Number02 = (int)Number01; //Explicit Casting


            //Console.WriteLine(Number02);
            //// Unsafe Casting

            #endregion

            #region Ex03

            //int? k = null;
            //int l;
            ////l = k; Unsafe
            //if (k.HasValue)
            //{
            //    l = (int)k; //Casting
            //}
            //else
            //{
            //    l = 0;
            //}

            //l = k.HasValue ? k.Value : 0;
            //l = k != null ? (int)k : 0;



            #endregion

            #endregion

            #region Reference Type

            //// Null is Default Value of Reference Type

            #region Ex01

            //string message = "Hiii";
            //message = null; //Valid with Warning
            //message = null!; // ! -> Null Forgiveness Operator

            //string? message02 = null; // Valid without Warning

            //Console.WriteLine(message02);
            //Console.WriteLine(message); 
            #endregion

            #region Ex02

            //string notNull = "hello";

            //string? NullableString = default; // Null


            //Console.WriteLine(NullableString);
            //Console.WriteLine(notNull);

            //// NullableString = notNull ; // Valid

            //notNull = NullableString; //Valid With Warning

            #endregion


            #endregion

            #region Null Propagation Operator ?

            //int[] Numbers = default!; // Null
            // NullReferenceException


            //for(int i = 0; (Numbers != null) && (i < Numbers.Length) ; i++)
            //for(int i = 0; i < Numbers?.Length; i++) 
            //     Console.WriteLine(Numbers[i]);


            //if(Numbers !=  null)
            // {
            //     for(int i = 0;i < Numbers.Length; i++)
            //     {
            //         Console.WriteLine(Numbers[i]);
            //     }
            // }

            // Numbers != null
            // i < Numbers.length

            // Numbers?.length
            // Numbers = null -> (Numbers?.length)=> Null
            // Numbers != Null -> Numbers?.length =>  length

            // ?

            // ??

            //int length = Numbers?.Length ?? 0;
            #endregion

            #endregion

            #region Functions

            //PrintShape(); Without Parameter

            //PrintShape(20 , "/-"); // Passing Parameter With Order

            //PrintShape("/-" , 20); // Invalid

            //PrintShape(pattern:"/-" ,count: 20); // Pasing Parameter By Name

            //PrintShape(); // Using Default  Values

            //Hello To Route Welcome Waleed
            //Console.WriteLine("Hello To Route \n Welcome \t Waleed");

            // C:\Users\Waleed\source\repos\Assignment05\Assignment05.sln

            //string path = @"C:\Users\Waleed\source\repos\Assignment05\Assignment05.sln";

            //Console.WriteLine(path);


            //PrintShape(10 , "*(\\");
            #endregion

            #region Passing Parameters

            #region Passing Value Type Parameters

            // int  , Double ,Char 

            #region Passing By Value
            //int a = 10 ,  b = 20;
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //SWAP(a, b);
            //Console.WriteLine("SWAP"); //Passing By Value

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}"); 
            #endregion

            #region Passing By Reference

            //int a = 10, b = 20;
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //SWAP(ref a, ref b);
            //Console.WriteLine("SWAP"); //Passing By Reference

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            #endregion

            #endregion

            #region Passing Reference Type Parameters

            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int res = SumArray(Numbers);
            //Console.WriteLine(res);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #region Passing By Ref
            //int[] Numbers = { 1, 2, 3, };
            //int Result = SumArray(ref Numbers); // Passing By Ref
            //                                    //  Array Its Self
            //Console.WriteLine(Result);
            #endregion

            #region Ex01 By Value

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Result = SumArray(Numbers); // Passing By Value
            ////Address Of Array 
            ////Arr = Numbers
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Result);


            #endregion


            #region Ex02 By reference


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Result = SumArray(ref Numbers); // Passing By Value
            ////Address Of Array 
            ////Arr = Numbers
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Result);


            #endregion


            #endregion

            #region Passing By Out

            //int A = 10, B = 20;
            //int SumRes = 0 , MulRes = 0 ;
            ////SumMul(A, B ,out SumRes ,out MulRes); // Passing By Out
            //SumMul(A, B ,ref SumRes ,ref MulRes); // Passing By Reference

            //Console.WriteLine(SumRes);
            //Console.WriteLine(MulRes);

            #endregion

            #region Params

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int result = SumArray(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(result);


            //int a = 10 , b = 5 , c = 30 ,d = 45;
            //string Name = "Test";

            //Console.WriteLine("{0} + {1} + {3} = {2}  {4}" , a , b, d, c ,Name);

            #endregion

            #endregion

        }
    }
}
