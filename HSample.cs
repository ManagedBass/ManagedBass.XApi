using System;
using System.Linq;

namespace ManagedBass
{
    public class HSample : H, IDisposable
    {
        HSample(int Handle) : base(Handle) { }

        public static implicit operator HSample(int Handle) => new HSample(Handle);

        public void Dispose() => Bass.SampleFree(this);

        public HChannel GetChannel(bool OnlyNew = false) => Bass.SampleGetChannel(this, OnlyNew);

        public HChannel[] Channels => Bass.SampleGetChannels(this).Cast<HChannel>().ToArray();

        public bool GetData(byte[] Buffer) => Bass.SampleGetData(this, Buffer);

        public bool GetData(short[] Buffer) => Bass.SampleGetData(this, Buffer);

        public bool GetData(int[] Buffer) => Bass.SampleGetData(this, Buffer);

        public bool GetData(float[] Buffer) => Bass.SampleGetData(this, Buffer);

        public bool GetData(IntPtr Buffer) => Bass.SampleGetData(this, Buffer);

        public SampleInfo Info
        {
            get { return Bass.SampleGetInfo(this); }
            set { Bass.SampleSetInfo(this, value); }
        }

        public bool SetData(byte[] Buffer) => Bass.SampleSetData(this, Buffer);

        public bool SetData(short[] Buffer) => Bass.SampleSetData(this, Buffer);

        public bool SetData(int[] Buffer) => Bass.SampleSetData(this, Buffer);

        public bool SetData(float[] Buffer) => Bass.SampleSetData(this, Buffer);

        public bool SetData(IntPtr Buffer) => Bass.SampleSetData(this, Buffer);

        public bool Stop => Bass.SampleStop(this);
    }
}
