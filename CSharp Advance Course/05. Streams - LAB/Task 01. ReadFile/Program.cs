﻿using System;
using System.IO;

namespace Task_01._ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader("Program.cs"))
            {
                var lineNumber = 1;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine($"Line {lineNumber}: "+ line);
                    lineNumber++;
                }
            }
        }
    }
}
