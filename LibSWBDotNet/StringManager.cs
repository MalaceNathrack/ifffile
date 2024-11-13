// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.StringManager
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class StringManager : IDisposable
  {
    private unsafe CSwgStringManager* manager;

    public unsafe StringManager(Repository repo)
    {
      if (repo == null)
        throw new Exception("Can not create a StringManager with an empty repository!");
      CSwgStringManager* cswgStringManagerPtr1 = (CSwgStringManager*) \u003CModule\u003E.@new(72UL);
      CSwgStringManager* cswgStringManagerPtr2;
      // ISSUE: fault handler
      try
      {
        cswgStringManagerPtr2 = (IntPtr) cswgStringManagerPtr1 == IntPtr.Zero ? (CSwgStringManager*) 0L : \u003CModule\u003E.CSwgStringManager\u002E\u007Bctor\u007D(cswgStringManagerPtr1, repo.GetNativeRepository());
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) cswgStringManagerPtr1, 72UL);
      }
      this.manager = cswgStringManagerPtr2;
    }

    private unsafe void \u007EStringManager()
    {
      CSwgStringManager* manager = this.manager;
      if ((IntPtr) manager == IntPtr.Zero)
        return;
      \u003CModule\u003E.CSwgStringManager\u002E\u007Bdtor\u007D(manager);
      \u003CModule\u003E.delete((void*) manager, 72UL);
    }

    public unsafe void Clear() => \u003CModule\u003E.CSwgStringManager\u002EClear(this.manager);

    public unsafe void AddFile(string file)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &file);
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.CSwgStringManager\u002EAddFile(this.manager, &stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
    }

    public unsafe string Lookup(string file, string key)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &file);
      string str;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &key);
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* pThis = &stdAllocatorChar3;
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar3, &stdAllocatorChar2);
          CSwgStringManager* manager;
          // ISSUE: fault handler
          try
          {
            manager = this.manager;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
          }
          basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT;
          basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr = \u003CModule\u003E.CSwgStringManager\u002ELookup(manager, &stdAllocatorWcharT, &stdAllocatorChar1, stdAllocatorCharPtr);
          // ISSUE: fault handler
          try
          {
            str = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Ec_str(stdAllocatorWcharTPtr));
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return str;
    }

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007EStringManager();
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
