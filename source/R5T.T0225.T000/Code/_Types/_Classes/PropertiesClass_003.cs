using System;

using R5T.T0142;


namespace R5T.T0225.T000
{
    /// <summary>
    /// A simple class with a property marked obsolete.
    /// </summary>
    [UtilityTypeMarker]
    public class PropertiesClass_003
    {
        /// <summary>
        /// Marked obsolete.
        /// </summary>
        [Obsolete]
        public string Property_100 { get; set; }
    }
}
