using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000030 RID: 48
	public class PIMAGE_LOAD_CONFIG_DIRECTORY32 : ManagedPtr<IMAGE_LOAD_CONFIG_DIRECTORY32>
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00003C58 File Offset: 0x00001E58
		public PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003C61 File Offset: 0x00001E61
		public PIMAGE_LOAD_CONFIG_DIRECTORY32(object value) : base(value, true)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003C6B File Offset: 0x00001E6B
		public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator +(PIMAGE_LOAD_CONFIG_DIRECTORY32 c1, int c2)
		{
			return new PIMAGE_LOAD_CONFIG_DIRECTORY32(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003C85 File Offset: 0x00001E85
		public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator ++(PIMAGE_LOAD_CONFIG_DIRECTORY32 a)
		{
			return a + 1;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003C8E File Offset: 0x00001E8E
		public new static explicit operator PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PIMAGE_LOAD_CONFIG_DIRECTORY32(ptr);
		}
	}
}
