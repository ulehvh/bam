using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000019 RID: 25
	public struct IMAGE_TLS_DIRECTORY32
	{
		// Token: 0x040000FE RID: 254
		public uint StartAddressOfRawData;

		// Token: 0x040000FF RID: 255
		public uint EndAddressOfRawData;

		// Token: 0x04000100 RID: 256
		public uint AddressOfIndex;

		// Token: 0x04000101 RID: 257
		public uint AddressOfCallBacks;

		// Token: 0x04000102 RID: 258
		public uint SizeOfZeroFill;

		// Token: 0x04000103 RID: 259
		public uint Characteristics;
	}
}
