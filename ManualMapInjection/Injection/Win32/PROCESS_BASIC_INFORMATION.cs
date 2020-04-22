using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000013 RID: 19
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PROCESS_BASIC_INFORMATION
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003772 File Offset: 0x00001972
		public int Size
		{
			get
			{
				return Marshal.SizeOf(typeof(PROCESS_BASIC_INFORMATION));
			}
		}

		// Token: 0x040000E2 RID: 226
		public IntPtr ExitStatus;

		// Token: 0x040000E3 RID: 227
		public IntPtr PebBaseAddress;

		// Token: 0x040000E4 RID: 228
		public IntPtr AffinityMask;

		// Token: 0x040000E5 RID: 229
		public IntPtr BasePriority;

		// Token: 0x040000E6 RID: 230
		public UIntPtr UniqueProcessId;

		// Token: 0x040000E7 RID: 231
		public IntPtr InheritedFromUniqueProcessId;
	}
}
