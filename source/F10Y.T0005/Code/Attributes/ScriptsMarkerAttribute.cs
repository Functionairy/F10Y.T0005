using System;

using F10Y.T0000;


namespace F10Y.T0005
{
    /// <summary>
    /// Attribute indicating an interface contains scripts (default implementation methods on an interface that have no inputs).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying script interfaces and building a catalogue of scripts.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Scripts are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
        )]
    [MarkerAttributeMarker]
    public class ScriptsMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a scripts interface.
        /// This is useful for marking interfaces that end up canonical script code file locations, but are not script interfaces.
        /// </summary>
        public bool Is_Scripts { get; }


        public ScriptsMarkerAttribute(
            bool is_Scripts = true)
        {
            this.Is_Scripts = is_Scripts;
        }
    }
}
