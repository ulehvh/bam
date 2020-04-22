using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000026 RID: 38
	public class PIMAGE_SECTION_HEADER : ManagedPtr<IMAGE_SECTION_HEADER>
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00003979 File Offset: 0x00001B79
		public PIMAGE_SECTION_HEADER(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003982 File Offset: 0x00001B82
		public PIMAGE_SECTION_HEADER(object value) : base(value, true)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000398C File Offset: 0x00001B8C
		public new static explicit operator PIMAGE_SECTION_HEADER(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_SECTION_HEADER(ptr);
		}
	}
}
