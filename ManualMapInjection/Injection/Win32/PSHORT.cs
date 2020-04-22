using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002E RID: 46
	public class PSHORT : ManagedPtr<short>
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00003BBE File Offset: 0x00001DBE
		public PSHORT(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003BC7 File Offset: 0x00001DC7
		public PSHORT(object value) : base(value, true)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003BD1 File Offset: 0x00001DD1
		public static PSHORT operator +(PSHORT c1, int c2)
		{
			return new PSHORT(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003BEB File Offset: 0x00001DEB
		public static PSHORT operator ++(PSHORT a)
		{
			return a + 1;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public new static explicit operator PSHORT(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PSHORT(ptr);
		}
	}
}
