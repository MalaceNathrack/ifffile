// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.TreeWriter
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System;
using System.Runtime.InteropServices;
using TreeCompression;

#nullable disable
namespace LibSWBDotNet
{
  public class TreeWriter : IDisposable
  {
    private unsafe CTreeFileWriter* w;

    public unsafe TreeWriter([MarshalAs(UnmanagedType.U1)] bool tocComp, [MarshalAs(UnmanagedType.U1)] bool nameComp)
    {
      ECompressionType ecompressionType1 = tocComp ? (ECompressionType) 2 : (ECompressionType) 0;
      ECompressionType ecompressionType2 = nameComp ? (ECompressionType) 2 : (ECompressionType) 0;
      CTreeFileWriter* ctreeFileWriterPtr1 = (CTreeFileWriter*) \u003CModule\u003E.@new(32UL);
      CTreeFileWriter* ctreeFileWriterPtr2;
      // ISSUE: fault handler
      try
      {
        ctreeFileWriterPtr2 = (IntPtr) ctreeFileWriterPtr1 == IntPtr.Zero ? (CTreeFileWriter*) 0L : \u003CModule\u003E.CTreeFileWriter\u002E\u007Bctor\u007D(ctreeFileWriterPtr1, ecompressionType1, ecompressionType2);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) ctreeFileWriterPtr1, 32UL);
      }
      this.w = ctreeFileWriterPtr2;
    }

    private unsafe void \u007ETreeWriter()
    {
      CTreeFileWriter* w = this.w;
      if ((IntPtr) w == IntPtr.Zero)
        return;
      \u003CModule\u003E.CTreeFileWriter\u002E\u007Bdtor\u007D(w);
      \u003CModule\u003E.delete((void*) w, 32UL);
    }

    public unsafe void Clear() => \u003CModule\u003E.CTreeFileWriter\u002EClear(this.w);

    public unsafe void AddFileFromDisk(
      string filename,
      string filenameInTree,
      [MarshalAs(UnmanagedType.U1)] bool preferCompression)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &filename);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &filenameInTree);
        // ISSUE: fault handler
        try
        {
          ECompressionType ecompressionType = preferCompression ? (ECompressionType) 2 : (ECompressionType) 0;
          \u003CModule\u003E.CTreeFileWriter\u002EAddFileFromDisk(this.w, &stdAllocatorChar1, &stdAllocatorChar2, ecompressionType);
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
    }

    public unsafe void BuildFromDirectory(string dirname)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &dirname);
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.CTreeFileWriter\u002EBuildFromDirectory(this.w, &stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
    }

    public unsafe SaveOperation SaveToFile(string filename, Action<float, string> callback)
    {
      return new SaveOperation(this.w, filename, callback);
    }

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007ETreeWriter();
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
