// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.TreeEntry
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class TreeEntry : IComparable, IDisposable
  {
    private string name;
    private string extension;
    private int compressed;
    private int uncompressed;
    private string path;
    private string container;
    private uint crc;
    private bool isOverride;
    private unsafe CSwgRepository.SRepositoryEntry* entry;

    public unsafe TreeEntry(CSwgRepository.SRepositoryEntryInfo* n)
    {
      this.name = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) n));
      this.extension = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) ((IntPtr) n + 32L)));
      this.path = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) ((IntPtr) n + 64L)));
      this.container = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Ec_str((basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E*) ((IntPtr) n + 96L)));
      CSwgRepository.SRepositoryEntry* srepositoryEntryPtr1 = (CSwgRepository.SRepositoryEntry*) \u003CModule\u003E.@new(36UL);
      CSwgRepository.SRepositoryEntry* srepositoryEntryPtr2;
      if ((IntPtr) srepositoryEntryPtr1 != IntPtr.Zero)
      {
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) srepositoryEntryPtr1, (IntPtr) n + 128L, 36);
        srepositoryEntryPtr2 = srepositoryEntryPtr1;
      }
      else
        srepositoryEntryPtr2 = (CSwgRepository.SRepositoryEntry*) 0L;
      this.entry = srepositoryEntryPtr2;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    private unsafe void \u007ETreeEntry() => \u003CModule\u003E.delete((void*) this.entry, 36UL);

    public unsafe CSwgRepository.SRepositoryEntryInfo* ToNativeEntryInfo(
      [In] CSwgRepository.SRepositoryEntryInfo* obj0)
    {
      uint num1;
      // ISSUE: fault handler
      try
      {
        num1 = 0U;
        \u003CModule\u003E.CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bctor\u007D(obj0);
        num1 = 1U;
        string container = this.container;
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT;
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT, &container);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u003D((basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E*) ((IntPtr) obj0 + 96L), stdAllocatorWcharTPtr);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT);
        string name = this.name;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr1 = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &name);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u003D((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) obj0, stdAllocatorCharPtr1);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
        string extension = this.extension;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr2 = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &extension);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u003D((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) ((IntPtr) obj0 + 32L), stdAllocatorCharPtr2);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
        string path = this.path;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr3 = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar3, &path);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u003D((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) ((IntPtr) obj0 + 64L), stdAllocatorCharPtr3);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar3);
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj0 + 128L, (IntPtr) this.entry, 36);
        return obj0;
      }
      __fault
      {
        if (((int) num1 & 1) != 0)
        {
          uint num2 = num1 & 4294967294U;
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D), (void*) obj0);
        }
      }
    }

    public virtual int CompareTo(object other) => this.name.CompareTo(((TreeEntry) other).name);

    public string Name => this.name;

    public string Extension => this.extension;

    public unsafe int Compressed => *(int*) ((IntPtr) this.entry + 32L);

    public unsafe int Uncompressed => *(int*) ((IntPtr) this.entry + 28L);

    public string Path => this.path;

    public string Container => this.container;

    public unsafe uint Crc32 => (uint) *(int*) ((IntPtr) this.entry + 16L);

    public unsafe bool IsOverride
    {
      [return: MarshalAs(UnmanagedType.U1)] get => (bool) *(byte*) this.entry;
    }

    protected virtual unsafe void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        \u003CModule\u003E.delete((void*) this.entry, 36UL);
      }
      else
      {
        // ISSUE: explicit finalizer call
        this.Finalize();
      }
    }

    public virtual void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }
  }
}
