namespace ManagedBass.Fx
{
    public class HTempo : HChannel
    {
        HTempo(int Handle) : base(Handle) { }

        public HChannel Source => BassFx.TempoGetSource(this);

        public double RateRatio => BassFx.TempoGetRateRatio(this);

        public double Tempo
        {
            get { return GetAttribute(ChannelAttribute.Tempo); }
            set { SetAttribute(ChannelAttribute.Tempo, value); }
        }

        public double Pitch
        {
            get { return GetAttribute(ChannelAttribute.Pitch); }
            set { SetAttribute(ChannelAttribute.Pitch, value); }
        }

        public static implicit operator HTempo(int Handle) => new HTempo(Handle);

        public int AntiAliasFilterLength
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoAAFilterLength); }
            set { SetAttribute(ChannelAttribute.TempoAAFilterLength, value); }
        }

        public double TempoFrequency
        {
            get { return GetAttribute(ChannelAttribute.TempoFrequency); }
            set { SetAttribute(ChannelAttribute.TempoFrequency, value); }
        }

        public int OverlapMilliseconds
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoOverlapMilliseconds); }
            set { SetAttribute(ChannelAttribute.TempoOverlapMilliseconds, value); }
        }

        public bool PreventClicks
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoPreventClick) != 0; }
            set { SetAttribute(ChannelAttribute.TempoPreventClick, value ? 1 : 0); }
        }

        public int SeekWindowMilliseconds
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoSeekWindowMilliseconds); }
            set { SetAttribute(ChannelAttribute.TempoSeekWindowMilliseconds, value); }
        }

        public int SequenceMilliseconds
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoSequenceMilliseconds); }
            set { SetAttribute(ChannelAttribute.TempoSequenceMilliseconds, value); }
        }

        public bool UseAntiAliasFilter
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoUseAAFilter) != 0; }
            set { SetAttribute(ChannelAttribute.TempoUseAAFilter, value ? 1 : 0); }
        }

        public bool UseQuickAlgorithm
        {
            get { return (int)GetAttribute(ChannelAttribute.TempoUseQuickAlgorithm) != 0; }
            set { SetAttribute(ChannelAttribute.TempoUseQuickAlgorithm, value ? 1 : 0); }
        }
    }
}