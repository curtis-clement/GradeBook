using System.Collections.Generic;

namespace GradeBook {
  class Book {
    public Book(string name) {
      grades = new List<double>();
      this.name = name;
    }
    private List<double> grades;
    private string name;

    public void AddGrade(double grade) {
      grades.Add(grade);
    }

    public void ShowStatistics() {
      var gradeResult = 0.0;
      var highestGrade =  double.MinValue;
      var lowestGrade = double.MaxValue;

      foreach (var number in grades) {
        highestGrade = Math.Max(number, highestGrade);
        lowestGrade = Math.Min(number, lowestGrade);
        gradeResult += number;
      }

      gradeResult = gradeResult / grades.Count;
      Console.WriteLine($"The average grade is {gradeResult:N1}");
      Console.WriteLine($"The lowest grade is {lowestGrade}");
      Console.WriteLine($"The highest grade is {highestGrade}");
    }
  }
}