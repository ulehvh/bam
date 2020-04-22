using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000022 RID: 34
	public class PIMAGE_NT_HEADERS32 : ManagedPtr<IMAGE_NT_HEADERS32>
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003861 File Offset: 0x00001A61
		public PIMAGE_NT_HEADERS32(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000386A File Offset: 0x00001A6A
		public PIMAGE_NT_HEADERS32(object value) : base(value, true)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003874 File Offset: 0x00001A74
		public new static explicit operator PIMAGE_NT_HEADERS32(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_NT_HEADERS32(ptr);
		}
	}
}
