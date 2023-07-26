using System;

public class Example
{
    static void Main(string[] args)
            {
                String[] s;

                Console.Clear();
                s = Console.ReadLine().Split(' ');

                int n = Int32.Parse(s[0]);

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
}