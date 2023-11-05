using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.T0225.T000
{
    /// <summary>
    /// A class with example methods.
    /// </summary>
    [UtilityTypeMarker]
    public class MethodsClass_001
    {
        /// <summary>
        /// Static method returning void.
        /// </summary>
        public static void Method_001()
        { }

        /// <summary>
        /// Static method returning a string.
        /// </summary>
        /// <returns></returns>
        public static string Method_002()
        {
            return String.Empty;
        }

        /// <summary>
        /// Static method with one type parameter.
        /// </summary>
        public static void Method_003<T>()
        { }

        /// <summary>
        /// Static method with two type parameters.
        /// </summary>
        public static void Method_004<T1, T2>()
        { }

        /// <summary>
        /// Method retuning void.
        /// </summary>
        public void Method_005()
        { }

        /// <summary>
        /// Method returning a string.
        /// </summary>
        public string Method_006()
        {
            return String.Empty;
        }

        /// <summary>
        /// Method with one generic type parameter.
        /// </summary>
        public void Method_006<T>()
        { }

        /// <summary>
        /// Method with two generic type parameters.
        /// </summary>
        public void Method_006<T1, T2>()
        { }

        /// <summary>
        /// Method returning a generic type parameter.
        /// </summary>
        public T Method_007<T>()
        {
            var output = (T)(new object());
            return output;
        }

        /// <summary>
        /// Method taking a string and returning a string.
        /// </summary>
        public string Method_008(string value)
        {
            return value;
        }

        /// <summary>
        /// Method taking a generic type instance and returning a generic type instance.
        /// </summary>
        public T Method_009<T>(T value)
        {
            return value;
        }

        /// <summary>
        /// Method with new() restriction on generic type parameter.
        /// </summary>
        public void Method_010<T>()
            where T : new()
        { }

        /// <summary>
        /// Method with class restriction on generic type parameter.
        /// </summary>
        public void Method_011<T>()
            where T : class
        { }

        /// <summary>
        /// Method with specific class restriction on generic type parameter.
        /// </summary>
        public void Method_012<T>()
            where T : Class_001
        { }

        /// <summary>
        /// A method taking a nested closed generic argument.
        /// </summary>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method_013(Dictionary<string, List<Class_001>> values, string @string)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

#pragma warning disable IDE0060 // Remove unused parameter
        public void Method_014(List<string> strings)
#pragma warning restore IDE0060 // Remove unused parameter
        { }
    }
}
