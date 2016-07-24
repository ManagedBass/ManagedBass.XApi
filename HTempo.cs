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
    }
}