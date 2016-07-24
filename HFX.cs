using System;

namespace ManagedBass
{
    public class HFX : H
    {
        HFX(int Handle) : base(Handle) { }

        public static implicit operator HFX(int Handle) => new HFX(Handle);
        
        public bool GetParameters(IntPtr Parameters)
        {
            return Bass.FXGetParameters(this, Parameters);
        }

        public bool SetParameters(IntPtr Parameters)
        {
            return Bass.FXSetParameters(this, Parameters);
        }

        public bool Reset() => Bass.FXReset(this);

        public bool SetPriority(int Priority) => Bass.FXSetPriority(this, Priority);
    }
}