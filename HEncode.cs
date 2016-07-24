using System;

namespace ManagedBass.Enc
{
    public class HEncode : H
    {
        HEncode(int Handle) : base(Handle) { }
        
        public static implicit operator HEncode(int Handle) => new HEncode(Handle);

        public bool AddChunk(string ID, byte[] Buffer, int Length)
        {
            return BassEnc.EncodeAddChunk(this, ID, Buffer, Length);
        }

        public bool AddChunk(string ID, IntPtr Buffer, int Length)
        {
            return BassEnc.EncodeAddChunk(this, ID, Buffer, Length);
        }

        public HChannel Channel
        {
            get { return BassEnc.EncodeGetChannel(this); }
            set { BassEnc.EncodeSetChannel(this, value); }
        }

        public long GetCount(EncodeCount Count) => BassEnc.EncodeGetCount(this, Count);

        public PlaybackState IsActive => BassEnc.EncodeIsActive(this);

        public bool SetNotify(EncodeNotifyProcedure Procedure, IntPtr User = default(IntPtr))
        {
            return BassEnc.EncodeSetNotify(this, Procedure, User);
        }

        public bool SetPaused(bool Paused = true) => BassEnc.EncodeSetPaused(this, Paused);

        public bool Stop() => BassEnc.EncodeStop(this);

        public bool Stop(bool Queue) => BassEnc.EncodeStop(this, Queue);

        public bool Write(byte[] Buffer, int Length) => BassEnc.EncodeWrite(this, Buffer, Length);
        public bool Write(short[] Buffer, int Length) => BassEnc.EncodeWrite(this, Buffer, Length);
        public bool Write(float[] Buffer, int Length) => BassEnc.EncodeWrite(this, Buffer, Length);
        public bool Write(IntPtr Buffer, int Length) => BassEnc.EncodeWrite(this, Buffer, Length);
    }
}