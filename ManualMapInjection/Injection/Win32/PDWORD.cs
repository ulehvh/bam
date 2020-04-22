using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002A RID: 42
	public class PDWORD : ManagedPtr<uint>
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003A8A File Offset: 0x00001C8A
		public PDWORD(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003A93 File Offset: 0x00001C93
		public PDWORD(object value) : base(value, true)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003A9D File Offset: 0x00001C9D
		public static PDWORD operator +(PDWORD c1, int c2)
		{
			return new PDWORD(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003AB7 File Offset: 0x00001CB7
		public static PDWORD operator ++(PDWORD a)
		{
			return a + 1;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public new static explicit operator PDWORD(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PDWORD(ptr);
		}
	}
}
