// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GradeBook 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      var book = new Book("Curtis' Gradebook");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.3);

      var stats = book.CalculateStatistics();
      Console.WriteLine($"The average grade is {stats.average:N1}");
      Console.WriteLine($"The lowest grade is {stats.low}");
      Console.WriteLine($"The highest grade is {stats.high}");
    }
  }
}
