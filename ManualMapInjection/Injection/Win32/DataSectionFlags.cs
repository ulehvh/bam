using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000009 RID: 9
	[Flags]
	public enum DataSectionFlags : uint
	{
		// Token: 0x0400002B RID: 43
		TypeReg = 0U,
		// Token: 0x0400002C RID: 44
		TypeDsect = 1U,
		// Token: 0x0400002D RID: 45
		TypeNoLoad = 2U,
		// Token: 0x0400002E RID: 46
		TypeGroup = 4U,
		// Token: 0x0400002F RID: 47
		TypeNoPadded = 8U,
		// Token: 0x04000030 RID: 48
		TypeCopy = 16U,
		// Token: 0x04000031 RID: 49
		ContentCode = 32U,
		// Token: 0x04000032 RID: 50
		ContentInitializedData = 64U,
		// Token: 0x04000033 RID: 51
		ContentUninitializedData = 128U,
		// Token: 0x04000034 RID: 52
		LinkOther = 256U,
		// Token: 0x04000035 RID: 53
		LinkInfo = 512U,
		// Token: 0x04000036 RID: 54
		TypeOver = 1024U,
		// Token: 0x04000037 RID: 55
		LinkRemove = 2048U,
		// Token: 0x04000038 RID: 56
		LinkComDat = 4096U,
		// Token: 0x04000039 RID: 57
		NoDeferSpecExceptions = 16384U,
		// Token: 0x0400003A RID: 58
		RelativeGP = 32768U,
		// Token: 0x0400003B RID: 59
		MemPurgeable = 131072U,
		// Token: 0x0400003C RID: 60
		Memory16Bit = 131072U,
		// Token: 0x0400003D RID: 61
		MemoryLocked = 262144U,
		// Token: 0x0400003E RID: 62
		MemoryPreload = 524288U,
		// Token: 0x0400003F RID: 63
		Align1Bytes = 1048576U,
		// Token: 0x04000040 RID: 64
		Align2Bytes = 2097152U,
		// Token: 0x04000041 RID: 65
		Align4Bytes = 3145728U,
		// Token: 0x04000042 RID: 66
		Align8Bytes = 4194304U,
		// Token: 0x04000043 RID: 67
		Align16Bytes = 5242880U,
		// Token: 0x04000044 RID: 68
		Align32Bytes = 6291456U,
		// Token: 0x04000045 RID: 69
		Align64Bytes = 7340032U,
		// Token: 0x04000046 RID: 70
		Align128Bytes = 8388608U,
		// Token: 0x04000047 RID: 71
		Align256Bytes = 9437184U,
		// Token: 0x04000048 RID: 72
		Align512Bytes = 10485760U,
		// Token: 0x04000049 RID: 73
		Align1024Bytes = 11534336U,
		// Token: 0x0400004A RID: 74
		Align2048Bytes = 12582912U,
		// Token: 0x0400004B RID: 75
		Align4096Bytes = 13631488U,
		// Token: 0x0400004C RID: 76
		Align8192Bytes = 14680064U,
		// Token: 0x0400004D RID: 77
		LinkExtendedRelocationOverflow = 16777216U,
		// Token: 0x0400004E RID: 78
		MemoryDiscardable = 33554432U,
		// Token: 0x0400004F RID: 79
		MemoryNotCached = 67108864U,
		// Token: 0x04000050 RID: 80
		MemoryNotPaged = 134217728U,
		// Token: 0x04000051 RID: 81
		MemoryShared = 268435456U,
		// Token: 0x04000052 RID: 82
		MemoryExecute = 536870912U,
		// Token: 0x04000053 RID: 83
		MemoryRead = 1073741824U,
		// Token: 0x04000054 RID: 84
		MemoryWrite = 2147483648U
	}
}
