﻿using System;
class Program
{
    static void Main(string[] args)
    {
        var box = new Box<int>();

        box.Add(2);
        box.Add(3);
        box.Add(4);
        box.Add(5);
        box.Add(6);

        var element = box.Remove();
        Console.WriteLine(element);
        Console.WriteLine(box.Count);
    }
}

