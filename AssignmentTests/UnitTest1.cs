using ExceptionsAssignment;
using System.Text;

namespace AssignmentTests
{
    public class ExceptionUnitTests
    {
        [Fact]
        public void DivideWithException_DivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => ExceptionDemo.DivideWithException(10, 0));
        }

        [Fact]
        public void DivideWithException_ValidNumbers_ReturnsCorrectValue()
        {
            var result = ExceptionDemo.DivideWithException(10, 2);
            Assert.Equal(5, result);
        }
        
        [Fact]
        public void GetElementAtIndex_IndexOutOfBounds_ThrowsException()
        {
            var array = new[] { "one", "two", "three" };
            Assert.Throws<IndexOutOfRangeException>(() => ExceptionDemo.GetElementAtIndex(array, 5));
        }

        [Fact]
        public void GetElementAtIndex_ValidIndex_ReturnsCorrectValue()
        {
            var array = new[] { "one", "two", "three" };
            var result = ExceptionDemo.GetElementAtIndex(array, 1);
            Assert.Equal("two", result);
        }

        [Fact]
        public void ArgumentNullExceptionDemo_NullArgument_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ExceptionDemo.ArgumentNullExceptionDemo(null));
        }

        [Fact]
        public void ArgumentNullExceptionDemo_ValidArgument_ReturnsCorrectValue()
        {
            var result = ExceptionDemo.ArgumentNullExceptionDemo("123");
            Assert.Equal(123, 123);
        }

        [Fact]
        public void CastingExceptionDemo_InvalidCast_ThrowsException()
        {
            Assert.Throws<InvalidCastException>(() => ExceptionDemo.CastingExceptionDemo(new StringBuilder()));
        }

        [Fact]
        public void CastingExceptionDemo_ValidCast_ReturnsCorrectValue()
        {
            var result = ExceptionDemo.CastingExceptionDemo("test");
            Assert.Equal("test", result);
        }

        [Fact]
        public void TryCatchDemo_InvalidInput_ReturnsExceptionMessage()
        {
            _ = Assert.Throws<FormatException>(() => ExceptionDemo.CastingExceptionDemo(ExceptionDemo.TryCatchDemo("not_a_number")));
        }

        [Fact]
        public void TryCatchDemo_ValidInput_ReturnsCorrectValue()
        {
            var result = ExceptionDemo.TryCatchDemo("123");
            Assert.Equal(123, result);
        }
    }
}