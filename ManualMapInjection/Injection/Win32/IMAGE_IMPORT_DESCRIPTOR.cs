using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000012 RID: 18
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_IMPORT_DESCRIPTOR
	{
		// Token: 0x040000DC RID: 220
		[FieldOffset(0)]
		public uint Characteristics;

		// Token: 0x040000DD RID: 221
		[FieldOffset(0)]
		public uint OriginalFirstThunk;

		// Token: 0x040000DE RID: 222
		[FieldOffset(4)]
		public uint TimeDateStamp;

		// Token: 0x040000DF RID: 223
		[FieldOffset(8)]
		public uint ForwarderChain;

		// Token: 0x040000E0 RID: 224
		[FieldOffset(12)]
		public uint Name;

		// Token: 0x040000E1 RID: 225
		[FieldOffset(16)]
		public uint FirstThunk;
	}
}
