using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002D RID: 45
	public class PIMAGE_BASE_RELOCATION : ManagedPtr<IMAGE_BASE_RELOCATION>
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00003B71 File Offset: 0x00001D71
		public PIMAGE_BASE_RELOCATION(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003B7A File Offset: 0x00001D7A
		public PIMAGE_BASE_RELOCATION(object value) : base(value, true)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003B84 File Offset: 0x00001D84
		public static PIMAGE_BASE_RELOCATION operator +(PIMAGE_BASE_RELOCATION c1, int c2)
		{
			return new PIMAGE_BASE_RELOCATION(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003B9E File Offset: 0x00001D9E
		public static PIMAGE_BASE_RELOCATION operator ++(PIMAGE_BASE_RELOCATION a)
		{
			return a + 1;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003BA7 File Offset: 0x00001DA7
		public new static explicit operator PIMAGE_BASE_RELOCATION(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_BASE_RELOCATION(ptr);
		}
	}
}
