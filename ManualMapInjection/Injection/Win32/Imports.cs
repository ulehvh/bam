﻿using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200001C RID: 28
	[SuppressUnmanagedCodeSecurity]
	internal static class Imports
	{
		// Token: 0x0600002C RID: 44
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, UIntPtr lpAddress, IntPtr dwSize, Imports.AllocationType flAllocationType, Imports.MemoryProtection flProtect);

		// Token: 0x0600002D RID: 45
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, Imports.AllocationType flAllocationType, Imports.MemoryProtection flProtect);

		// Token: 0x0600002E RID: 46
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(Imports.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x0600002F RID: 47
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle(IntPtr hObject);

		// Token: 0x06000030 RID: 48
		[DllImport("Dbghelp.dll")]
		public static extern IntPtr ImageRvaToVa(IntPtr NtHeaders, IntPtr Base, UIntPtr Rva, [Optional] IntPtr LastRvaSection);

		// Token: 0x06000031 RID: 49
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr GetProcessHeap();

		// Token: 0x06000032 RID: 50
		[DllImport("kernel32.dll")]
		public static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, UIntPtr dwBytes);

		// Token: 0x06000033 RID: 51
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

		// Token: 0x06000034 RID: 52
		[DllImport("NTDLL.DLL", SetLastError = true)]
		public static extern int NtQueryInformationProcess(IntPtr hProcess, int pic, IntPtr pbi, uint cb, out uint pSize);

		// Token: 0x06000035 RID: 53
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int dwSize, out UIntPtr lpNumberOfBytesRead);

		// Token: 0x06000036 RID: 54
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x06000037 RID: 55
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, IntPtr nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x06000038 RID: 56
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x06000039 RID: 57
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, Imports.FreeType dwFreeType);

		// Token: 0x0600003D RID: 61
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool VirtualFree(IntPtr lpAddress, int dwSize, Imports.FreeType dwFreeType);

		// Token: 0x0600003E RID: 62
		[DllImport("kernel32.dll")]
		public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

		// Token: 0x0600003F RID: 63
		[DllImport("kernel32.dll")]
		public static extern void GetSystemTimeAsFileTime(out FILETIME lpSystemTimeAsFileTime);

		// Token: 0x06000040 RID: 64
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		// Token: 0x06000041 RID: 65 RVA: 0x00003784 File Offset: 0x00001984
		public static bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, out UIntPtr lpNumberOfBytesRead)
		{
			GCHandle gchandle = GCHandle.Alloc(lpBuffer, GCHandleType.Pinned);
			bool result = Imports.ReadProcessMemory(hProcess, lpBaseAddress, gchandle.AddrOfPinnedObject(), lpBuffer.Length, out lpNumberOfBytesRead);
			gchandle.Free();
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000037B4 File Offset: 0x000019B4
		public static bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out uint lpBuffer, out UIntPtr lpNumberOfBytesRead)
		{
			byte[] array = new byte[4];
			bool result = Imports.ReadProcessMemory(hProcess, lpBaseAddress, array, out lpNumberOfBytesRead);
			lpBuffer = BitConverter.ToUInt32(array, 0);
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000037DC File Offset: 0x000019DC
		public static bool ReadProcessMemory<T>(IntPtr hProcess, IntPtr lpBaseAddress, out T lpBuffer, out UIntPtr lpNumberOfBytesRead) where T : struct
		{
			byte[] array = new byte[Marshal.SizeOf(typeof(T))];
			bool result = Imports.ReadProcessMemory(hProcess, lpBaseAddress, array, out lpNumberOfBytesRead);
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			lpBuffer = Marshal.PtrToStructure<T>(gchandle.AddrOfPinnedObject());
			gchandle.Free();
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003828 File Offset: 0x00001A28
		public static IntPtr OpenProcess(Process proc, Imports.ProcessAccessFlags flags)
		{
			return Imports.OpenProcess(flags, false, proc.Id);
		}

		// Token: 0x0200001D RID: 29
		[Flags]
		public enum AllocationType
		{
			// Token: 0x04000120 RID: 288
			Commit = 4096,
			// Token: 0x04000121 RID: 289
			Reserve = 8192,
			// Token: 0x04000122 RID: 290
			Decommit = 16384,
			// Token: 0x04000123 RID: 291
			Release = 32768,
			// Token: 0x04000124 RID: 292
			Reset = 524288,
			// Token: 0x04000125 RID: 293
			Physical = 4194304,
			// Token: 0x04000126 RID: 294
			TopDown = 1048576,
			// Token: 0x04000127 RID: 295
			WriteWatch = 2097152,
			// Token: 0x04000128 RID: 296
			LargePages = 536870912
		}

		// Token: 0x0200001E RID: 30
		[Flags]
		public enum MemoryProtection
		{
			// Token: 0x0400012A RID: 298
			Execute = 16,
			// Token: 0x0400012B RID: 299
			ExecuteRead = 32,
			// Token: 0x0400012C RID: 300
			ExecuteReadWrite = 64,
			// Token: 0x0400012D RID: 301
			ExecuteWriteCopy = 128,
			// Token: 0x0400012E RID: 302
			NoAccess = 1,
			// Token: 0x0400012F RID: 303
			ReadOnly = 2,
			// Token: 0x04000130 RID: 304
			ReadWrite = 4,
			// Token: 0x04000131 RID: 305
			WriteCopy = 8,
			// Token: 0x04000132 RID: 306
			GuardModifierflag = 256,
			// Token: 0x04000133 RID: 307
			NoCacheModifierflag = 512,
			// Token: 0x04000134 RID: 308
			WriteCombineModifierflag = 1024
		}

		// Token: 0x0200001F RID: 31
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x04000136 RID: 310
			All = 2035711U,
			// Token: 0x04000137 RID: 311
			Terminate = 1U,
			// Token: 0x04000138 RID: 312
			CreateThread = 2U,
			// Token: 0x04000139 RID: 313
			VirtualMemoryOperation = 8U,
			// Token: 0x0400013A RID: 314
			VirtualMemoryRead = 16U,
			// Token: 0x0400013B RID: 315
			VirtualMemoryWrite = 32U,
			// Token: 0x0400013C RID: 316
			DuplicateHandle = 64U,
			// Token: 0x0400013D RID: 317
			CreateProcess = 128U,
			// Token: 0x0400013E RID: 318
			SetQuota = 256U,
			// Token: 0x0400013F RID: 319
			SetInformation = 512U,
			// Token: 0x04000140 RID: 320
			QueryInformation = 1024U,
			// Token: 0x04000141 RID: 321
			QueryLimitedInformation = 4096U,
			// Token: 0x04000142 RID: 322
			Synchronize = 1048576U
		}

		// Token: 0x02000020 RID: 32
		[Flags]
		public enum FreeType
		{
			// Token: 0x04000144 RID: 324
			Decommit = 16384,
			// Token: 0x04000145 RID: 325
			Release = 32768
		}
	}
}
