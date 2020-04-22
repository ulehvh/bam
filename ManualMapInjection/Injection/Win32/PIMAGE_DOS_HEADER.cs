using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000021 RID: 33
	public class PIMAGE_DOS_HEADER : ManagedPtr<IMAGE_DOS_HEADER>
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00003837 File Offset: 0x00001A37
		public PIMAGE_DOS_HEADER(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003840 File Offset: 0x00001A40
		public PIMAGE_DOS_HEADER(object value) : base(value, true)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000384A File Offset: 0x00001A4A
		public new static explicit operator PIMAGE_DOS_HEADER(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_DOS_HEADER(ptr);
		}
	}
}
