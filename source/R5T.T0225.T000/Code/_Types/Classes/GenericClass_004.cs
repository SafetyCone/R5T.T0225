using System;

using R5T.T0142;


namespace R5T.T0225.T000
{
    /// <summary>
    /// A generic class with a constrained type parameter.
    /// </summary>
    [UtilityTypeMarker]
    public class GenericClass_004<T>
        where T : IInterface_001
    {
    }
}
