﻿using System;

    class Strings_and_Objects
    {
        static void Main(string[] args)
        {
        string w1 = "Hello";
        string w2 = "World";
        object obj = w1 + " " + w2;
        string str =(string)  obj;
        Console.WriteLine(str);
        }
    }

