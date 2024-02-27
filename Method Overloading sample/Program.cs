using System;

class Program
{
    public static void Main(string[] args)
    {
        Program chase = new Program();
        int x, y;
        string a, b;
        string[] i, s;

        Console.WriteLine("Enter two numbers: ");
        i = Console.ReadLine().Split(' ');
        x = Convert.ToInt32(i[0]);
        y = Convert.ToInt32(i[1]);
        Console.WriteLine();
        //Splits the input into two strings

        Console.WriteLine("Enter two strings: ");
        s = Console.ReadLine().Split(' ');
        a = s[0];
        b = s[1];
        Console.WriteLine();

        int num = chase.Add(x, y);
        Console.WriteLine("The sum of the two numbers is: " + num);
        Console.WriteLine();

        string str = chase.Add(a, b);
        Console.WriteLine("The two strings added results to a string: " + str);
        Console.WriteLine();
    }

    //Add method to add two integers, 2 integers as parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    //Add method to add two string, 2 strings as parameters
    public string Add(string a, string b)
    {
        return a + b;
    }

}