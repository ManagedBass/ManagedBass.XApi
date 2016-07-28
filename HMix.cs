namespace ManagedBass.Mix
{
    public class HMix : H
    {
        HMix(int Handle) : base(Handle) { }

        public HMix(int Frequency, int Channels, BassFlags Flags = BassFlags.Default)
            : base(BassMix.CreateMixerStream(Frequency, Channels, Flags)) { }

        public static implicit operator HMix(int Channel) => new HMix(Channel);

        public bool AddChannel(HChannel Channel, BassFlags Flags = BassFlags.Default)
        {
            return BassMix.MixerAddChannel(this, Channel, Flags);
        }

        public bool AddChannel(HChannel Channel, BassFlags Flags, long Start, long Length)
        {
            return BassMix.MixerAddChannel(this, Channel, Flags, Start, Length);
        }

        public bool RemoveChannel(HChannel Channel) => BassMix.MixerRemoveChannel(Channel);
    }
}