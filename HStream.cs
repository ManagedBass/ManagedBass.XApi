using System;

namespace ManagedBass
{
    public class HStream : HChannel, IDisposable
    {
        HStream(int Handle) : base(Handle) { }

        public static implicit operator HStream(int Handle) => new HStream(Handle);

        public double AverageBitrate => GetAttribute(ChannelAttribute.Bitrate);

        public void Dispose() => Bass.StreamFree(this);
    }
}