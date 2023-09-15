using System;
using System.Collections;

namespace Task4
{
    public class SphereEventArgs : EventArgs
    {
        public IEnumerable CountOfColors;

        public SphereEventArgs(IEnumerable countOfColors) => CountOfColors = countOfColors;
    }
}
