using System;

namespace ManagedBass
{
    public class HChannel : H
    {
        protected HChannel(int Handle) : base(Handle) { }

        public int Device
        {
            get { return Bass.ChannelGetDevice(this); }
            set { Bass.ChannelSetDevice(this, value); }
        }

        public ChannelInfo Info => Bass.ChannelGetInfo(this);
        public int Level => Bass.ChannelGetLevel(this);
        public int LevelLeft => Bass.ChannelGetLevelLeft(this);
        public int LevelRight => Bass.ChannelGetLevelRight(this);
        public PlaybackState IsActive => Bass.ChannelIsActive(this);
        
        public static implicit operator HChannel(int Handle) => new HChannel(Handle);

        public bool AddFlag(BassFlags Flag) => Bass.ChannelAddFlag(this, Flag);

        public double Bytes2Seconds(long Position) => Bass.ChannelBytes2Seconds(this, Position);

        public BassFlags Flags(BassFlags Flags, BassFlags Mask) => Bass.ChannelFlags(this, Flags, Mask);

        public bool Get3DAttributes(ref Mode3D Mode, ref float Min, ref float Max, ref int iAngle, ref int oAngle, ref float OutVol)
        {
            return Bass.ChannelGet3DAttributes(this, ref Mode, ref Min, ref Max, ref iAngle, ref oAngle, ref OutVol);
        }

        public bool Get3DPosition(ref Vector3D Position, ref Vector3D Orientation, ref Vector3D Velocity)
        {
            return Bass.ChannelGet3DPosition(this, ref Position, ref Orientation, ref Velocity);
        }

        public double GetAttribute(ChannelAttribute Attribute) => Bass.ChannelGetAttribute(this, Attribute);

        public bool GetAttribute(ChannelAttribute Attribute, out float Value) => Bass.ChannelGetAttribute(this, Attribute, out Value);

        public int GetAttribute(ChannelAttribute Attribute, IntPtr Value, int Size)
        {
            return Bass.ChannelGetAttribute(this, Attribute, Value, Size);
        }

        public int GetData(byte[] Buffer, int Length) => Bass.ChannelGetData(this, Buffer, Length);

        public int GetData(short[] Buffer, int Length) => Bass.ChannelGetData(this, Buffer, Length);

        public int GetData(int[] Buffer, int Length) => Bass.ChannelGetData(this, Buffer, Length);

        public int GetData(float[] Buffer, int Length) => Bass.ChannelGetData(this, Buffer, Length);

        public int GetData(IntPtr Buffer, int Length) => Bass.ChannelGetData(this, Buffer, Length);

        public bool GetInfo(out ChannelInfo Info) => Bass.ChannelGetInfo(this, out Info);

        public long GetLength(PositionFlags Mode = PositionFlags.Bytes) => Bass.ChannelGetLength(this, Mode);

        public bool GetLevel(float[] Levels, float Length, LevelRetrievalFlags Flags)
        {
            return Bass.ChannelGetLevel(this, Levels, Length, Flags);
        }

        public long GetPosition(PositionFlags Mode = PositionFlags.Bytes)
        {
            return Bass.ChannelGetPosition(this, Mode);
        }

        public IntPtr GetTags(TagType TagType) => Bass.ChannelGetTags(this, TagType);

        public bool HasFlag(BassFlags Fllag) => Bass.ChannelHasFlag(this, Fllag);

        public bool IsSliding(ChannelAttribute Attribute) => Bass.ChannelIsSliding(this, Attribute);

        public bool Lock(bool Lock = true) => Bass.ChannelLock(this, Lock);

        public bool Pause() => Bass.ChannelPause(this);

        public bool Play(bool Restart = false) => Bass.ChannelPlay(this, Restart);

        public bool RemoveDSP(int DSP) => Bass.ChannelRemoveDSP(this, DSP);

        public bool RemoveFlag(BassFlags Flag) => Bass.ChannelRemoveFlag(this, Flag);

        public bool RemoveFX(HFX FX) => Bass.ChannelRemoveFX(this, FX);

        public bool RemoveLink(HChannel Channel) => Bass.ChannelRemoveLink(this, Channel);

        public bool RemoveSync(int Sync) => Bass.ChannelRemoveSync(this, Sync);

        public long Seconds2Bytes(double Position) => Bass.ChannelSeconds2Bytes(this, Position);

        public bool Set3DAttributes(Mode3D Mode, float Min, float Max, int iAngle, int oAngle, float OutVol)
        {
            return Bass.ChannelSet3DAttributes(this, Mode, Min, Max, iAngle, oAngle, OutVol);
        }

        public bool Set3DPosition(Vector3D Position, Vector3D Orientation, Vector3D Velocity)
        {
            return Bass.ChannelSet3DPosition(this, Position, Orientation, Velocity);
        }

        public bool SetAttribute(ChannelAttribute Attribute, double Value)
        {
            return Bass.ChannelSetAttribute(this, Attribute, Value);
        }

        public bool SetAttribute(ChannelAttribute Attribute, IntPtr Value, int Size)
        {
            return Bass.ChannelSetAttribute(this, Attribute, Value, Size);
        }

        public int SetDSP(DSPProcedure Procedure, IntPtr User = default(IntPtr), int Priority = 0)
        {
            return Bass.ChannelSetDSP(this, Procedure, User, Priority);
        }

        public HFX SetFX(EffectType Type, int Priority = 0)
        {
            return Bass.ChannelSetFX(this, Type, Priority);
        }

        public bool Link(HChannel Channel) => Bass.ChannelSetLink(this, Channel);

        public bool SetPosition(long Position, PositionFlags Mode = PositionFlags.Bytes)
        {
            return Bass.ChannelSetPosition(this, Position, Mode);
        }

        public int SetSync(SyncFlags Type, long Parameter, SyncProcedure Procedure, IntPtr User = default(IntPtr))
        {
            return Bass.ChannelSetSync(this, Type, Parameter, Procedure, User);
        }

        public bool SlideAttribute(ChannelAttribute Attribute, double Value, int Time)
        {
            return Bass.ChannelSlideAttribute(this, Attribute, (float)Value, Time);
        }

        public bool Stop() => Bass.ChannelStop(this);

        public bool Update(int Length) => Bass.ChannelUpdate(this, Length);

        public double CPUUsage => GetAttribute(ChannelAttribute.CPUUsage);

        public double Frequency
        {
            get { return GetAttribute(ChannelAttribute.Frequency); }
            set { SetAttribute(ChannelAttribute.Frequency, value); }
        }

        public double Pan
        {
            get { return GetAttribute(ChannelAttribute.Pan); }
            set { SetAttribute(ChannelAttribute.Pan, value); }
        }

        public double Volume
        {
            get { return GetAttribute(ChannelAttribute.Volume); }
            set { SetAttribute(ChannelAttribute.Volume, value); }
        }
    }
}