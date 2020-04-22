using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200000F RID: 15
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_NT_HEADERS32
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003727 File Offset: 0x00001927
		private string _Signature
		{
			get
			{
				return new string(this.Signature);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003734 File Offset: 0x00001934
		public bool isValid
		{
			get
			{
				return this._Signature == "PE\0\0";
			}
		}

		// Token: 0x040000CC RID: 204
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public char[] Signature;

		// Token: 0x040000CD RID: 205
		[FieldOffset(4)]
		public IMAGE_FILE_HEADER FileHeader;

		// Token: 0x040000CE RID: 206
		[FieldOffset(24)]
		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}
}
