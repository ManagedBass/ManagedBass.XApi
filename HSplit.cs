namespace ManagedBass.Mix
{
    public class HSplit : H
    {
        HSplit(int Handle) : base(Handle) { }

        public HSplit(HChannel Channel, BassFlags Flags, int[] ChannelMap = null)
            : base(BassMix.CreateSplitStream(Channel, Flags, ChannelMap)) { }

        public static implicit operator HSplit(int Handle) => new HSplit(Handle);

        public int DataAvailable => BassMix.SplitStreamGetAvailable(this);

        public int Source => BassMix.SplitStreamGetSource(this);

        public bool Reset() => BassMix.SplitStreamReset(this);

        public bool Reset(int Offset) => BassMix.SplitStreamReset(this, Offset);
    }
}