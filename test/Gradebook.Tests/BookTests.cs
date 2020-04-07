using Xunit;
using Gradebook;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(34);
            book.AddGrade(323);
            book.AddGrade(14);
            book.AddGrade(1324);
            book.AddGrade(4.43);
            book.AddGrade(143);

            //act
            var result = book.GetStatistics();


            //assert AAA
            Assert.Equal(33.2, result.High);
            Assert.Equal(23.3, result.Low);
            Assert.Equal(21.3, result.Average);
        }
    }
}
