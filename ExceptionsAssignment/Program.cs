namespace ExceptionsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceptions assignment");

            Console.WriteLine("Assignment 1: Divide exception");
            Console.WriteLine(ExceptionDemo.DivideWithException(10, 2));

            Console.WriteLine("Assignment 2: Index out of bounds exception");
            var array = new[] { "one", "two", "three" };
            Console.WriteLine(ExceptionDemo.GetElementAtIndex(array, 1));

            Console.WriteLine("Assignment 3: Argument null exception");
            Console.WriteLine(ExceptionDemo.ArgumentNullExceptionDemo("123"));

            Console.WriteLine("Assignment 4: Casting exception");
            Console.WriteLine(ExceptionDemo.CastingExceptionDemo("test"));

            Console.WriteLine("Assignment 5: Try catch");
            Console.WriteLine(ExceptionDemo.TryCatchDemo("test"));

        }
    }
}