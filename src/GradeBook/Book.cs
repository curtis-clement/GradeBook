using System.Collections.Generic;

namespace GradeBook 
{
  public class Book 
  {
    public Book(string name) 
    {
      grades = new List<double>();
      this.name = name;
    }
    private List<double> grades;
    private string name;

    public void AddGrade(double grade) 
    {
      grades.Add(grade);
    }

    public Statistics CalculateStatistics() 
    {
      var gradeResult = new Statistics();
      gradeResult.average = 0.0;
      gradeResult.high =  double.MinValue;
      gradeResult.low = double.MaxValue;

      foreach (var grade in grades) 
      {
        gradeResult.low = Math.Min(grade, gradeResult.low);
        gradeResult.high = Math.Max(grade, gradeResult.high);
        gradeResult.average += grade;
      }

      gradeResult.average /= grades.Count;

      return gradeResult;
    }
  }
}