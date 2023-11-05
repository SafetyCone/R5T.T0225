using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.T0225.T000
{
    [UtilityTypeMarker]
    public class PropertiesClass_001
    {
        /// <summary>
        /// Property with get and set;
        /// </summary>
        public string Property_001 { get; set; }

        /// <summary>
        /// Property with get and private set.
        /// </summary>
        public string Property_002 { get; private set; }

        /// <summary>
        /// Property with get only.
        /// </summary>
        public string Property_003 { get; }

#pragma warning disable IDE0052 // Remove unread private members
        private string zProperty_004;
#pragma warning restore IDE0052 // Remove unread private members

        /// <summary>
        /// Property with backing field.
        /// </summary>
        public string Property_004
        {
            set
            {
                zProperty_004 = value;
            }
        }

        // Properties cannot be generic on non-generic classes.
        //public T Property<T> { get; }

        /// <summary>
        /// An indexer for string.
        /// </summary>
        public string this[string test] => test;

        /// <summary>
        /// An indexer for int.
        /// </summary>
        public int this[int test] => test;

        // Indexers cannot be generic on non-generic classes.
        //public T this<T>[T value] => value;

        /// <summary>
        /// Static property with get and set.
        /// </summary>
        public static string Property_010 { get; set; }

        /// <summary>
        /// A closed generically-typed property.
        /// </summary>
        public List<string> Property_011 { get; set; }
    }
}
