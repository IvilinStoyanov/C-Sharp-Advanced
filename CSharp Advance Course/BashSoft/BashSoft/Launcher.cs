﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Launcher
    {
        static void Main()
        {
           // IOManager.TraverseDirectory(@"D:\GitHub\CSharp-Fundamentals-Software-University\BashSoft\BashSoft");

            StudentsRepository.InitializeData();
            StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
            

        }
    }
}
