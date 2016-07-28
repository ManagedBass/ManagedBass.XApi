using System;

namespace ManagedBass
{
    public abstract class H
    {
        readonly int _handle;

        protected H(int Handle)
        {
            if (Handle == 0)
                throw new ArgumentException("Invalid Zero Handle", nameof(Handle));

            _handle = Handle;
        }

        public static implicit operator int(H HChannel) => HChannel._handle;
    }
}