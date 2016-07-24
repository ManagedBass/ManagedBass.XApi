namespace ManagedBass
{
    public class HRecord : HChannel
    {
        HRecord(int Handle) : base(Handle) { }

        public static implicit operator HRecord(int Handle) => new HRecord(Handle);
    }
}