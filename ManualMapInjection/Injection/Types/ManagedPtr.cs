using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Types
{
	// Token: 0x02000031 RID: 49
	public class ManagedPtr<T> where T : struct
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003CA5 File Offset: 0x00001EA5
		public IntPtr Address { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003CAD File Offset: 0x00001EAD
		public T Value
		{
			get
			{
				return this[0U];
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003CB6 File Offset: 0x00001EB6
		public int StructSize
		{
			get
			{
				if (this._structSize == null)
				{
					this._structSize = new int?(Marshal.SizeOf(typeof(T)));
				}
				return this._structSize.Value;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003CEA File Offset: 0x00001EEA
		private static T GetStructure(IntPtr address)
		{
			return (T)((object)Marshal.PtrToStructure(address, typeof(T)));
		}

		// Token: 0x1700000E RID: 14
		public T this[uint index]
		{
			get
			{
				return ManagedPtr<T>.GetStructure(this.Address + (int)(index * (uint)this.StructSize));
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003D1B File Offset: 0x00001F1B
		public static ManagedPtr<T>operator +(ManagedPtr<T> c1, int c2)
		{
			return new ManagedPtr<T>(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003D35 File Offset: 0x00001F35
		public static ManagedPtr<T>operator ++(ManagedPtr<T> a)
		{
			return a + 1;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003D3E File Offset: 0x00001F3E
		public static ManagedPtr<T>operator -(ManagedPtr<T> c1, int c2)
		{
			return new ManagedPtr<T>(c1.Address - c2 * c1.StructSize);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003D58 File Offset: 0x00001F58
		public static ManagedPtr<T>operator --(ManagedPtr<T> a)
		{
			return a - 1;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003D61 File Offset: 0x00001F61
		public static explicit operator ManagedPtr<T>(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			return new ManagedPtr<T>(ptr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003D78 File Offset: 0x00001F78
		public static explicit operator IntPtr(ManagedPtr<T> ptr)
		{
			return ptr.Address;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003D80 File Offset: 0x00001F80
		public ManagedPtr(IntPtr address)
		{
			this.Address = address;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003D90 File Offset: 0x00001F90
		public ManagedPtr(object value, bool freeHandle = true)
		{
			if (value == null)
			{
				throw new InvalidOperationException("Cannot create a pointer of type null");
			}
			try
			{
				this._handle = GCHandle.Alloc(value, GCHandleType.Pinned);
			}
			catch (Exception)
			{
				throw new InvalidOperationException("Cannot create a pointer of type " + value.GetType().Name);
			}
			this._freeHandle = freeHandle;
			this.Address = this._handle.AddrOfPinnedObject();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003E08 File Offset: 0x00002008
		~ManagedPtr()
		{
			if (this._handle.IsAllocated && this._freeHandle)
			{
				this._handle.Free();
			}
		}

		// Token: 0x04000147 RID: 327
		private int? _structSize;

		// Token: 0x04000148 RID: 328
		private GCHandle _handle;

		// Token: 0x04000149 RID: 329
		private bool _freeHandle;
	}
}
