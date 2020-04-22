using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002C RID: 44
	public class PBYTE : ManagedPtr<byte>
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00003B24 File Offset: 0x00001D24
		public PBYTE(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003B2D File Offset: 0x00001D2D
		public PBYTE(object value) : base(value, true)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003B37 File Offset: 0x00001D37
		public static PBYTE operator +(PBYTE c1, int c2)
		{
			return new PBYTE(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003B51 File Offset: 0x00001D51
		public static PBYTE operator ++(PBYTE a)
		{
			return a + 1;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003B5A File Offset: 0x00001D5A
		public new static explicit operator PBYTE(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PBYTE(ptr);
		}
	}
}
