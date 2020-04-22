using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000024 RID: 36
	public class PPROCESS_BASIC_INFORMATION : ManagedPtr<PROCESS_BASIC_INFORMATION>
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003902 File Offset: 0x00001B02
		public PPROCESS_BASIC_INFORMATION(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000390B File Offset: 0x00001B0B
		public PPROCESS_BASIC_INFORMATION(object value) : base(value, true)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003915 File Offset: 0x00001B15
		public new static explicit operator PPROCESS_BASIC_INFORMATION(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new PPROCESS_BASIC_INFORMATION(ptr);
		}
	}
}
