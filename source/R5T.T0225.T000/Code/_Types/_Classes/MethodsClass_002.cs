using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.T0225.T000
{
    /// <summary>
    /// A generic class providing example methods.
    /// </summary>
    [UtilityTypeMarker]
    public class MethodsClass_002<T>
    {
        /// <summary>
        /// Basic method.
        /// </summary>
        public void Method_101()
        { }

        /// <summary>
        /// Method taking a string.
        /// </summary>
// Allow unused parameter to stay to see if reflection contains any information on the parameter name.
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method_102(string value)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

        /// <summary>
        /// Method taking one parameter.
        /// </summary>
        public void Method_103(T _)
        { }

        /// <summary>
        /// Method with one generic type parameter.
        /// </summary>
        public void Method_104<T1>()
        { }

        /// <summary>
        /// Method with one generic type parameter, taking the type generic type parameter and the method generic type parameter.
        /// </summary>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method_105<T1>(T t, T1 t1)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

        /// <summary>
        /// Method with one generic type parameter, taking the type generic type parameter, the method generic type parameter, and a string.
        /// </summary>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method_106<T1>(T t, T1 t1, string @string)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

        /// <summary>
        /// Nested generic types.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="value"></param>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method_107<T1>(Func<Dictionary<T, IEnumerable<T1>>> value)
#pragma warning restore IDE0060 // Remove unused parameter
        { }
    }
}
