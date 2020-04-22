using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002B RID: 43
	public class PIMAGE_IMPORT_BY_NAME : ManagedPtr<IMAGE_IMPORT_BY_NAME>
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00003AD7 File Offset: 0x00001CD7
		public PIMAGE_IMPORT_BY_NAME(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public PIMAGE_IMPORT_BY_NAME(object value) : base(value, true)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003AEA File Offset: 0x00001CEA
		public static PIMAGE_IMPORT_BY_NAME operator +(PIMAGE_IMPORT_BY_NAME c1, int c2)
		{
			return new PIMAGE_IMPORT_BY_NAME(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003B04 File Offset: 0x00001D04
		public static PIMAGE_IMPORT_BY_NAME operator ++(PIMAGE_IMPORT_BY_NAME a)
		{
			return a + 1;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003B0D File Offset: 0x00001D0D
		public new static explicit operator PIMAGE_IMPORT_BY_NAME(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_IMPORT_BY_NAME(ptr);
		}
	}
}
