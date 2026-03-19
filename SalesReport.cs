using System;/*Steven Shetler, The purpose of this application is to prompt a user
* to enter a sales figure in order to calculate the salary distribution of employees*/

public class SalesReport
{
    public static void Main()
    {
        int[] salaries = new int[10];//array creation expression
        //creating instance variables
        int salary = 0;
        int sales = 0;
        decimal i = 0.09m;
        //creating counters
        int count200s = 0, count300s = 0, count400s = 0, count500s = 0, count600s = 0, count700s = 0, count800s = 0, count900s = 0, count1000s = 0;

        Console.Write("Enter sales amount or -1 to exit: ");//prompting user to enter sale amount (this will be placed at the end of the while loop again because we do not know how many sales were made)
        sales = int.Parse(Console.ReadLine());//reading in the user's input

        while (sales != -1)//while loop which will run so long as conditions are met
        {
            salary = (int)(200 + (sales * i));

            if (salary >= 1000)
            {
                count1000s+=1;
            }
            else if (salary >= 900)
            {
                count900s += 1;
            }
            else if (salary >= 800)
            {
                count800s += 1;
            }
            else if (salary >= 700)
            {
                count700s += 1;
            }
            else if (salary >= 600)
            {
                count600s += 1;
            }
            else if (salary >= 500)
            {
                count500s += 1;
            }
            else if (salary >= 400)
            {
                count400s += 1;
            }
            else if (salary >= 300)
            {
                count300s += 1;
            }
            else if (salary >= 200 && salary <= 299)
            {
                count200s = count200s + 1;
            }
            Console.Write("Enter sales amount or -1 to exit: ");
            sales = int.Parse(Console.ReadLine());
        }
        //printing of the results of the while loop
        Console.WriteLine("Range               Number");
        Console.WriteLine($"$200-$299           {count200s}");
        Console.WriteLine($"$300-$399           {count300s}");
        Console.WriteLine($"$400-$499           {count400s}");
        Console.WriteLine($"$500-$599           {count500s}");
        Console.WriteLine($"$600-$699           {count600s}");
        Console.WriteLine($"$700-$799           {count700s}");
        Console.WriteLine($"$800-$899           {count800s}");
        Console.WriteLine($"$900-$999           {count900s}");
        Console.WriteLine($"$1000 and over      {count1000s}");
    }
}
