using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExceptionsAssignment
{
    public static class ExceptionDemo
    {
        public static int DivideWithException(int num1, int num2)
        {
            //Assignment 1: Change this code to throw an exception instead if trying to divide by 0
            var result = num1 / num2;

            return result;
        }

        public static string GetElementAtIndex(string[] array, int index)
        {
            //Assignment 2: Change this code to throw an exception instead if trying to access an index that is out of bounds
            var result = array[index];

            return result;
        }
        
        public static int ArgumentNullExceptionDemo(string number)
        {
            //Assignment 3: Change this code to throw an ArgumentNullException if the parameter is null
            //The ? after the int means that it is a nullable int. More information about Nulable types can be found here https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
            var result = int.Parse(number);

            return result;
        }

        public static string CastingExceptionDemo(object obj)
        {
            //Assignment 4: Change this code to throw an InvalidCastException if the object cannot be cast to a string
            //object is base type for all types in .NET. More information about casting can be found here https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
            var result = (string)obj;

            return result;
        }

        public static int? TryCatchDemo(string input)
        {
            //Assignment 5: Change this code to use a try catch technique to catch the exception and return correct exception if an exception is thrown

            //Be note that you could actually use TryParse to avoid try catch but for demo purposes we use Parse()-method so we get crash easily
            //For more information about TryParse you can find here https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-7.0

            int? number = 0;


            return number;
        }
    }
}
