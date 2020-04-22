﻿using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000007 RID: 7
	public enum SubSystemType : ushort
	{
		// Token: 0x04000011 RID: 17
		IMAGE_SUBSYSTEM_UNKNOWN,
		// Token: 0x04000012 RID: 18
		IMAGE_SUBSYSTEM_NATIVE,
		// Token: 0x04000013 RID: 19
		IMAGE_SUBSYSTEM_WINDOWS_GUI,
		// Token: 0x04000014 RID: 20
		IMAGE_SUBSYSTEM_WINDOWS_CUI,
		// Token: 0x04000015 RID: 21
		IMAGE_SUBSYSTEM_POSIX_CUI = 7,
		// Token: 0x04000016 RID: 22
		IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
		// Token: 0x04000017 RID: 23
		IMAGE_SUBSYSTEM_EFI_APPLICATION,
		// Token: 0x04000018 RID: 24
		IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER,
		// Token: 0x04000019 RID: 25
		IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER,
		// Token: 0x0400001A RID: 26
		IMAGE_SUBSYSTEM_EFI_ROM,
		// Token: 0x0400001B RID: 27
		IMAGE_SUBSYSTEM_XBOX
	}
}
