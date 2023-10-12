using System;

using R5T.T0142;


namespace R5T.T0225.T000
{
    [UtilityTypeMarker]
    public class PropertiesClass_002<T>
    {
        /// <summary>
        /// A property on a generic class.
        /// </summary>
        public static string Property_020 { get; set; }

        /// <summary>
        /// A generic property on a generic class.
        /// </summary>
        public static T Property_021 { get; }

        /// <summary>
        /// An indexer for string on a generic class.
        /// </summary>
        public string this[string test] => test;

        /// <summary>
        /// An indexer for a generic type on a generic class.
        /// </summary>
        public T this[T test] => test;

        // Properties cannot be generic beyond their generic classes.
        //public static T Property<T2> { get; }
    }
}
