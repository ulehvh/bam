using System;
using System.Runtime.InteropServices;
using System.Text;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000023 RID: 35
	public class PCHAR : ManagedPtr<char>
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000388B File Offset: 0x00001A8B
		public PCHAR(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003894 File Offset: 0x00001A94
		public PCHAR(object value) : base(value, true)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000389E File Offset: 0x00001A9E
		public PCHAR(string value) : base(Encoding.UTF8.GetBytes(value), true)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000038B2 File Offset: 0x00001AB2
		public static PCHAR operator +(PCHAR c1, int c2)
		{
			return new PCHAR(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000038CC File Offset: 0x00001ACC
		public static PCHAR operator ++(PCHAR a)
		{
			return a + 1;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000038D5 File Offset: 0x00001AD5
		public new static explicit operator PCHAR(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PCHAR(ptr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000038EC File Offset: 0x00001AEC
		public override string ToString()
		{
			return Marshal.PtrToStringAnsi(base.Address) ?? string.Empty;
		}
	}
}
