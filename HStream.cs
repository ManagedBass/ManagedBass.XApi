namespace ManagedBass
{
    public class HStream : HChannel
    {
        HStream(int Handle) : base(Handle) { }

        public static implicit operator HStream(int Handle) => new HStream(Handle);

        public double AverageBitrate => GetAttribute(ChannelAttribute.Bitrate);

        public bool Free() => Bass.StreamFree(this);
    }
}