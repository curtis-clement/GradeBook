// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GradeBook {
  class Program {
    static void Main(string[] args) {
      var book = new Book("Curtis' Gradebook");
      book.AddGrade(87.56);
      book.AddGrade(90.1);
      book.AddGrade(77.8);
      book.ShowStatistics();
    }
  }
}
