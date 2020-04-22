using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000025 RID: 37
	public class PIMAGE_IMPORT_DESCRIPTOR : ManagedPtr<IMAGE_IMPORT_DESCRIPTOR>
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000392C File Offset: 0x00001B2C
		public PIMAGE_IMPORT_DESCRIPTOR(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003935 File Offset: 0x00001B35
		public PIMAGE_IMPORT_DESCRIPTOR(object value) : base(value, true)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000393F File Offset: 0x00001B3F
		public static PIMAGE_IMPORT_DESCRIPTOR operator +(PIMAGE_IMPORT_DESCRIPTOR c1, int c2)
		{
			return new PIMAGE_IMPORT_DESCRIPTOR(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003959 File Offset: 0x00001B59
		public static PIMAGE_IMPORT_DESCRIPTOR operator ++(PIMAGE_IMPORT_DESCRIPTOR a)
		{
			return a + 1;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003962 File Offset: 0x00001B62
		public new static explicit operator PIMAGE_IMPORT_DESCRIPTOR(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_IMPORT_DESCRIPTOR(ptr);
		}
	}
}
