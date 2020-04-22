using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000010 RID: 16
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_NT_HEADERS64
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003746 File Offset: 0x00001946
		private string _Signature
		{
			get
			{
				return new string(this.Signature);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003753 File Offset: 0x00001953
		public bool isValid
		{
			get
			{
				return this._Signature == "PE\0\0";
			}
		}

		// Token: 0x040000CF RID: 207
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public char[] Signature;

		// Token: 0x040000D0 RID: 208
		[FieldOffset(4)]
		public IMAGE_FILE_HEADER FileHeader;

		// Token: 0x040000D1 RID: 209
		[FieldOffset(24)]
		public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
	}
}
