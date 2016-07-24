namespace ManagedBass.Fx
{
    public class HReverse : HChannel
    {
        HReverse(int Handle) : base(Handle) { }

        public HChannel Source => BassFx.ReverseGetSource(this);

        public bool Reverse
        {
            get { return GetAttribute(ChannelAttribute.ReverseDirection) < 0; }
            set { SetAttribute(ChannelAttribute.ReverseDirection, value ? -1 : 1); }
        }
        
        public static implicit operator HReverse(int Handle) => new HReverse(Handle);
    }
}