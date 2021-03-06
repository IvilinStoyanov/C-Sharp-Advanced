﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : Human
{
    private const int FacNumMinLength = 5;
    private const int FacNumMaxLength = 10;

    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        private set
        {
            if (value.Length < FacNumMinLength || value.Length > FacNumMaxLength ||
                   !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultynumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultynumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append(base.ToString())
            .AppendLine($"Faculty number: {this.facultyNumber}");

        return sb.ToString();
    }
}

