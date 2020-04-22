using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002F RID: 47
	public class PIMAGE_TLS_DIRECTORY32 : ManagedPtr<IMAGE_TLS_DIRECTORY32>
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003C0B File Offset: 0x00001E0B
		public PIMAGE_TLS_DIRECTORY32(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003C14 File Offset: 0x00001E14
		public PIMAGE_TLS_DIRECTORY32(object value) : base(value, true)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003C1E File Offset: 0x00001E1E
		public static PIMAGE_TLS_DIRECTORY32 operator +(PIMAGE_TLS_DIRECTORY32 c1, int c2)
		{
			return new PIMAGE_TLS_DIRECTORY32(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003C38 File Offset: 0x00001E38
		public static PIMAGE_TLS_DIRECTORY32 operator ++(PIMAGE_TLS_DIRECTORY32 a)
		{
			return a + 1;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003C41 File Offset: 0x00001E41
		public new static explicit operator PIMAGE_TLS_DIRECTORY32(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_TLS_DIRECTORY32(ptr);
		}
	}
}
