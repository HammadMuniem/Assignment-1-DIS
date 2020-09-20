using System;
using System.Diagnostics;
using System.Globalization;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;           
            Console.WriteLine("How many stars do you need in your pyramid?:");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                printtriangle(n);
            }
            catch
            {
                Console.WriteLine("Please enter a numerical value next time");
            }

        }
        static void printtriangle(int n)
        {
            int i, j;
            //We will first declare the integers I and J since we are going to use them later in our for loop
            for (i = 1; i<=n; i++)
            //The way that I have decided to build this pyramid is through matrix notation. I here will represent the row
            //whereas J will represent the column. So this loop is designed in a way that it will first deal with the
            //rows and then with the columns.
            {
                for(j=1; j<=2*n-1;j++)
                //2n-1 is used here because that is the odd number progression. In the 2nd row we need 3 stars for example.
                //once J increases more than 2n-1, the loop returns to the previous line.  
                {
                    if(j >=n-(i-1) && j<= n+(i-1))
                    //This line is important for the pyramid to be center aligned.
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("\n");           
            }
            return;    
        }
    }
    static void Main(string[] args)
    {
        int i, n2, sum;

        Console.WriteLine("Please enter the number of terms here:");
        try
        {
            n2 = Convert.ToInt32(Console.ReadLine());
            printseriessum(n2);
        }
        catch
        {
            Console.WriteLine("Please enter a numerical value next time");
        }
    }
    static void printseriessum(int n2)
    {
        int i;
        for (i = 1; i <= n2; i++)
        {
            Debug.Write("%d", (2 * i) - 1);
            sum+ = 2 * i - 1;
        }
    } Debug.WriteLine("The sum is",sum);
}
