using System.Runtime.InteropServices;

namespace ManagedBass
{
    public class HMusic : HChannel
    {
        HMusic(int Handle) : base(Handle) { }

        public static implicit operator HMusic(int Handle) => new HMusic(Handle);

        public bool Free() => Bass.MusicFree(this);

        public int ActiveChannelCount => (int)GetAttribute(ChannelAttribute.MusicActiveChannelCount);

        public int Amplify
        {
            get { return (int)GetAttribute(ChannelAttribute.MusicAmplify); }
            set { SetAttribute(ChannelAttribute.MusicAmplify, value); }
        }

        public int BPM
        {
            get { return (int)GetAttribute(ChannelAttribute.MusicBPM); }
            set { SetAttribute(ChannelAttribute.MusicBPM, value); }
        }

        public int PanSeparation
        {
            get { return (int)GetAttribute(ChannelAttribute.MusicPanSeparation); }
            set { SetAttribute(ChannelAttribute.MusicPanSeparation, value); }
        }

        public int PositionScaler
        {
            get { return (int)GetAttribute(ChannelAttribute.MusicPositionScaler); }
            set { SetAttribute(ChannelAttribute.MusicPositionScaler, value); }
        }

        public int Speed
        {
            get { return (int)GetAttribute(ChannelAttribute.MusicSpeed); }
            set { SetAttribute(ChannelAttribute.MusicSpeed, value); }
        }

        public double GetChannelVolume(int ChannelNum) => GetAttribute(ChannelAttribute.MusicVolumeChannel + ChannelNum);
        public bool SetChannelVolume(int ChannelNum, double Value) => SetAttribute(ChannelAttribute.MusicVolumeChannel + ChannelNum, Value);

        public int ChannelCount
        {
            get
            {
                int i;
                float vol;
                
                for (i = 0; GetAttribute(ChannelAttribute.MusicVolumeChannel + i, out  vol); ++i) { }

                return i;
            }
        }

        public int GlobalVolume
        {
            get { return (int)GetAttribute(ChannelAttribute.MusicVolumeGlobal); }
            set { SetAttribute(ChannelAttribute.MusicVolumeGlobal, value); }
        }

        public double GetInstrumentVolume(int InstrumentNum) => GetAttribute(ChannelAttribute.MusicVolumeInstrument + InstrumentNum);
        public bool SetInstrumentVolume(int InstrumentNum, double Value) => SetAttribute(ChannelAttribute.MusicVolumeInstrument + InstrumentNum, Value);

        public int InstrumentCount
        {
            get
            {
                int i;
                float vol;

                for (i = 0; GetAttribute(ChannelAttribute.MusicVolumeInstrument + i, out vol); ++i) { }

                return i;
            }
        }

        public string Author => Extensions.PtrToStringUtf8(GetTags(TagType.MusicAuth));

        public string GetInstrumentName(int InstrumentNum) => Marshal.PtrToStringAnsi(GetTags(TagType.MusicInstrument + InstrumentNum));

        public string Message => Marshal.PtrToStringAnsi(GetTags(TagType.MusicMessage));

        public string Name => Marshal.PtrToStringAnsi(GetTags(TagType.MusicName));

        public string GetSampleName(int SampleNum) => Marshal.PtrToStringAnsi(GetTags(TagType.MusicSample + SampleNum));
    }
}