namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BookCalculatesAnAverageGrad()
    {
        // arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // act
        var result = book.CalculateStatistics();

        //assert
        Assert.Equal(85.6, result.average, 1);
        Assert.Equal(90.5, result.high, 1);
        Assert.Equal(77.3, result.low, 1);
    }
}