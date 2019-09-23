using System;

namespace Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* "Self Reflection"
             
             1. Feels good to be back to hands on in programming after a hiatus of 9 years
             2. Learnt how to work with creation and assignment of variables and passing them in methods
             3. Learnt how to work on arrays and nested looping constructs along with how they can be implemented collaboratively
             4. Was able to understand the concept of 'Dynamic Programming'and successfully implement the same in the 5th question of the assignment
                The problem also gave me an exposure on understanding the conversion of integer arrays into strings

            */

            Console.Write("\n");
            int a = 1, b = 22;
            Console.Write("----------Question 1 - Printing Self Dividing Numbers----------");
            Console.Write("\n");
            printSelfDividingNumbers(a, b);


            int n2 = 6;
            Console.Write("\n");
            Console.Write("--------Question 2 - Printing the Series---------");
            Console.Write("\n");
            printSeries(n2);

            int n3 = 7;
            Console.Write("\n");
            Console.Write("-------Question 3 - Printing Triangle--------");
            Console.Write("\n");
            printTriangle(n3, 0);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.Write("\n");
            Console.Write("---------Question 4 - Printing Jewels--------");
            Console.Write("\n");
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 7, 8, 9 };

            Console.Write("\n");
            Console.Write("----------Question 5 - Printing Largest Common Subarray----------");
            Console.Write("\n");

            getLargestCommonSubArray(arr1, arr2);
            Console.ReadKey(true);

            // solvePuzzle();*/
        }
        public static void printSelfDividingNumbers(int x, int y) //Passing the range of numbers to find self dividing numbers between
        {

            try
            {
                int num1 = 0; //Assign num1 variable a value of 0
                int num2;
                int selfdivide = 1; //Set selfdivide flag as 1
                while (y >= x) 
                {
                    num2 = y; //Assign the end of range number to num2
                    while (selfdivide == 1 && num2 > 0)//If the number is self dividing and num2>0 simultaneously
                    {
                        num1 = num2 % 10; //Assign remainder of dividing num2 by 10 to num1 
                        if (!IsSelfDividing(num1, num2)) //if not selfdividing number
                            selfdivide = 0;//Set selfdivide flag to 0
                        num2 /= 10; //num2 is assigned a value which comes as a result of dividing num2 by 10
                    }
                    if (selfdivide == 1) //if selfdividing number
                        Console.Write(y + ", "); //Display the value of y on console
                    y--; //Check the number (y-1) if it is selfdividing or not; repeat the process
                    selfdivide = 1; //Set selfdivide flag to 1
                }
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static bool IsSelfDividing(int num1, int num2)
        {
            // If the digit divides the number then return true else return false. 
            if (num1 != 0 && num2 % num1 == 0)
                return true;
            else
                return false;
        }

        public static void printSeries(int n)//pass the number - 'n' , for which the required series needs to be printed as output
        {
            try
            {
                for (int i = 1; i <= n; i++) // Outer, nested 'For' loop starting from 1, and iterating till the value of n. For example,
                    // If n=6, i will start from 1 and iterate until 6, through, 2,3,4 and 5 (incrementing 1 at a time)
                {
                    for (int j = 1; j <= i; j++) //For every i, the inner, nested 'For' loop counter 'j'will iterate from 
                        //1 to the value of i
                    {
                        Console.Write(i); //Print the number of occurances of i for the counter value j
                    }
                }
                Console.Write("\n");


            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n, int m)
        {
            try
            {
                // Write your code here
                if (n < 0)
                    return;
                int i;
                for (i = 0; i < m; i++) // This loop creates spaces while creating the triangle  
                    Console.Write(" ");
                for (i = 0; i < n; i++) // This loop creates the * for creating the inverted triangle                                   
                    Console.Write("* ");
                    Console.Write("\n"); // for next line
                    printTriangle(n - 1, m + 1);  //Invokes the printing of traingle using * and spaces                           

            }
            catch
            {

                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static int numJewelsInStones(int[] J, int[] S) //Passes the two arrays 
        {
            try
            {
                int count = 0;
                
                for (int i = 0; i < J.Length; i++) //The outer counter 'i' of the nested loop iterates from 0 till the length of array J
                    //incrementing 1 at a time
                {
                    for (int j = 0; j < S.Length; j++)//The inner counter, 'j' of the nested loop iterates from 0 till the length of array 
                        //S, incrementing 1 at a time
                    {
                        if (J[i] == S[j]) //If the value of the ith element for array J matches the jth element of array S in the inner loop
                            
                        {
                            count++;//Increment the counter by 1 - Number of jewels
                        }
                    }
                }
                return count; //return the value of counter, 'count' to the method
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static void getLargestCommonSubArray(int[] a, int[] b) //Passes two arrays to the function
         {
             try
             {
                string x = string.Join("", a); //Converting integer array to string
                string y = string.Join("", b); //Converting integer array to string

             var lengths = new int[x.Length, y.Length]; //Variable 'length' creates a new, 2 dimensional array of lengths of strings, 'x' and'y'
             int greatestLength = 0;//Assign initial value of 0 to the integer variable
             string output = "";
             for (int i = 0; i < x.Length; i++) //Outer For loop iterating through the row of the array
             {
                 for (int j = 0; j < y.Length; j++)//Inner For loop iterating through the column of the array
                 {
                     if (x[i] == y[j])//Check for the column values which are equal to every row value
                     {
                         lengths[i, j] = i == 0 || j == 0 ? 1 : lengths[i - 1, j - 1] + 1;//If the row and column values match and are across the
                            //diagonals, increment the value of counter by 1. If it is a match but not across the diagonals, then assign a value of 1
                            //In case of no match in values, assign a 0
                         if (lengths[i, j] > greatestLength)
                         {
                             greatestLength = lengths[i, j];
                             output = x.Substring(i - greatestLength + 1, greatestLength);//Output the substring which match and are across the diagonals
                         }
                     }
                     else
                     {
                         lengths[i, j] = 0;
                     }
                 }
             }
             Console.WriteLine(output);
             
         }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
        }
 

            
             


        /*public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
         }*/
    }

}

