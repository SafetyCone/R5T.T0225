using System;

using R5T.T0142;


namespace R5T.T0225.T000
{
    /// <summary>
    /// A simple class with an event marked obsolete.
    /// </summary>
    [UtilityTypeMarker]
    public class EventsClass_003
    {
#pragma warning disable CS0067 // Event is never used.

        [Obsolete]
        public event EventHandler Event_003;

#pragma warning restore CS0067 // Event is never used.
    }
}
