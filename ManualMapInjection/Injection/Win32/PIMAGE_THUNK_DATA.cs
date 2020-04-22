using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000027 RID: 39
	public class PIMAGE_THUNK_DATA : ManagedPtr<IMAGE_THUNK_DATA>
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000039A3 File Offset: 0x00001BA3
		public PIMAGE_THUNK_DATA(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000039AC File Offset: 0x00001BAC
		public PIMAGE_THUNK_DATA(object value) : base(value, true)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000039B6 File Offset: 0x00001BB6
		public static PIMAGE_THUNK_DATA operator +(PIMAGE_THUNK_DATA c1, int c2)
		{
			return new PIMAGE_THUNK_DATA(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000039D0 File Offset: 0x00001BD0
		public static PIMAGE_THUNK_DATA operator ++(PIMAGE_THUNK_DATA a)
		{
			return a + 1;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000039D9 File Offset: 0x00001BD9
		public new static explicit operator PIMAGE_THUNK_DATA(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_THUNK_DATA(ptr);
		}
	}
}
