﻿using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class DifficultyEntry
    {
        [Index(true)]
        public uint ID;
        public string Name;
        public byte InstanceType;
        public byte OrderIndex;
        public sbyte OldEnumValue;
        public byte FallbackDifficultyID;
        public byte MinPlayers;
        public byte MaxPlayers;
        public ushort Flags;
        public byte ItemContext;
        public byte ToggleDifficultyID;
        public ushort GroupSizeHealthCurveID;
        public ushort GroupSizeDmgCurveID;
        public ushort GroupSizeSpellPointsCurveID;
    }
}
