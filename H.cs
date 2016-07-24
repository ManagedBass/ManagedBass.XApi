namespace ManagedBass
{
    public abstract class H
    {
        readonly int _handle;

        protected H(int Handle)
        {
            _handle = Handle;
        }

        public static implicit operator int(H HChannel) => HChannel._handle;
    }
}