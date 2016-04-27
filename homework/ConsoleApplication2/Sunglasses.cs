using System;


class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string bridge = new string('|', n);
        string frame1 = new string('*', (2 * n));
        string frame2 = new string(' ', n);
        string frame3 = frame1 + frame2;
        string lens = new string('/', 2 * n - 2);
        string lens1 = string.Format("{0}{1}{0}", '*', lens);
        for (int i = 1; i < n; i++)
        { if ((i == 1) || (i == n - 1)) 
            { Console.WriteLine("{0}{1}{0}", frame1, frame2); } 
           
            else
                { Console.WriteLine("{0}{1}{0}",lens1,frame2); }
            if (i == n / 2)
            { Console.WriteLine("{0}{1}{0}",lens1,bridge ); }

        }
    }


    }

