using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200000B RID: 11
	public struct IMAGE_FILE_HEADER
	{
		// Token: 0x04000068 RID: 104
		public ushort Machine;

		// Token: 0x04000069 RID: 105
		public ushort NumberOfSections;

		// Token: 0x0400006A RID: 106
		public uint TimeDateStamp;

		// Token: 0x0400006B RID: 107
		public uint PointerToSymbolTable;

		// Token: 0x0400006C RID: 108
		public uint NumberOfSymbols;

		// Token: 0x0400006D RID: 109
		public ushort SizeOfOptionalHeader;

		// Token: 0x0400006E RID: 110
		public ushort Characteristics;
	}
}
