// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.ExtractOperation
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class ExtractOperation : IDisposable
  {
    private ExtractOperation.ProgressEventDelegate del;
    private GCHandle delH;
    private unsafe CSwgRepository* r;
    private unsafe CExtractProcess* extractProcess;
    private Action<float, string> callback;
    private bool started;

    private unsafe void ExtractFiles(
      List<TreeEntry> files,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool appendTreeNameToOutputDirectory)
    {
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        vector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E srepositoryEntryInfo1;
        \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bctor\u007D(&srepositoryEntryInfo1);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Ereserve(&srepositoryEntryInfo1, (ulong) files.Count);
          List<TreeEntry>.Enumerator enumerator = files.GetEnumerator();
          if (enumerator.MoveNext())
          {
            do
            {
              CSwgRepository.SRepositoryEntryInfo srepositoryEntryInfo2;
              CSwgRepository.SRepositoryEntryInfo* nativeEntryInfo = enumerator.Current.ToNativeEntryInfo(&srepositoryEntryInfo2);
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Eemplace_back\u003Cstruct\u0020CSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E(&srepositoryEntryInfo1, nativeEntryInfo);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo2);
              }
              \u003CModule\u003E.CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D(&srepositoryEntryInfo2);
            }
            while (enumerator.MoveNext());
          }
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
          \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &outputPath);
          // ISSUE: fault handler
          try
          {
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
            CSwgRepository* r;
            // ISSUE: fault handler
            try
            {
              r = this.r;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
            }
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess;
            \u003CModule\u003E.CSwgRepository\u002EExtractFiles(r, &deleteCextractProcess, &srepositoryEntryInfo1, &stdAllocatorChar, appendTreeNameToOutputDirectory, cdeclFloatCharConstPtr);
            // ISSUE: fault handler
            try
            {
              this.extractProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Eget(&deleteCextractProcess);
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Erelease(&deleteCextractProcess);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess);
            }
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo1);
        }
        \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&srepositoryEntryInfo1);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    private unsafe void ExtractFiles(
      List<string> files,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool appendTreeNameToOutputDirectory)
    {
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        vector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E stdAllocatorChar1;
        \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Ereserve(&stdAllocatorChar1, (ulong) files.Count);
          List<string>.Enumerator enumerator = files.GetEnumerator();
          if (enumerator.MoveNext())
          {
            do
            {
              string current = enumerator.Current;
              basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
              basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &current);
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eemplace_back\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(&stdAllocatorChar1, stdAllocatorCharPtr);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
              }
              \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
            }
            while (enumerator.MoveNext());
          }
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
          \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar3, &outputPath);
          // ISSUE: fault handler
          try
          {
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
            CSwgRepository* r;
            // ISSUE: fault handler
            try
            {
              r = this.r;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
            }
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess;
            \u003CModule\u003E.CSwgRepository\u002EExtractFiles(r, &deleteCextractProcess, &stdAllocatorChar1, &stdAllocatorChar3, appendTreeNameToOutputDirectory, cdeclFloatCharConstPtr);
            // ISSUE: fault handler
            try
            {
              this.extractProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Eget(&deleteCextractProcess);
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Erelease(&deleteCextractProcess);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess);
            }
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar3);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    private unsafe void ExtractChain(List<TreeEntry> files, string outputPath)
    {
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        vector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E srepositoryEntryInfo1;
        \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bctor\u007D(&srepositoryEntryInfo1);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Ereserve(&srepositoryEntryInfo1, (ulong) files.Count);
          List<TreeEntry>.Enumerator enumerator = files.GetEnumerator();
          if (enumerator.MoveNext())
          {
            do
            {
              CSwgRepository.SRepositoryEntryInfo srepositoryEntryInfo2;
              CSwgRepository.SRepositoryEntryInfo* nativeEntryInfo = enumerator.Current.ToNativeEntryInfo(&srepositoryEntryInfo2);
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Eemplace_back\u003Cstruct\u0020CSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E(&srepositoryEntryInfo1, nativeEntryInfo);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo2);
              }
              \u003CModule\u003E.CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D(&srepositoryEntryInfo2);
            }
            while (enumerator.MoveNext());
          }
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
          \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &outputPath);
          // ISSUE: fault handler
          try
          {
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
            CSwgRepository* r;
            // ISSUE: fault handler
            try
            {
              r = this.r;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
            }
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess;
            \u003CModule\u003E.CSwgRepository\u002EExtractChain(r, &deleteCextractProcess, &srepositoryEntryInfo1, &stdAllocatorChar, cdeclFloatCharConstPtr);
            // ISSUE: fault handler
            try
            {
              this.extractProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Eget(&deleteCextractProcess);
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Erelease(&deleteCextractProcess);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess);
            }
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo1);
        }
        \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&srepositoryEntryInfo1);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    private unsafe void ExtractChain(List<string> files, string outputPath)
    {
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        vector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E stdAllocatorChar1;
        \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Ereserve(&stdAllocatorChar1, (ulong) files.Count);
          List<string>.Enumerator enumerator = files.GetEnumerator();
          if (enumerator.MoveNext())
          {
            do
            {
              string current = enumerator.Current;
              basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
              basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &current);
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eemplace_back\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(&stdAllocatorChar1, stdAllocatorCharPtr);
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
              }
              \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
            }
            while (enumerator.MoveNext());
          }
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar3;
          \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar3, &outputPath);
          // ISSUE: fault handler
          try
          {
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
            CSwgRepository* r;
            // ISSUE: fault handler
            try
            {
              r = this.r;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
            }
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess;
            \u003CModule\u003E.CSwgRepository\u002EExtractChain(r, &deleteCextractProcess, &stdAllocatorChar1, &stdAllocatorChar3, cdeclFloatCharConstPtr);
            // ISSUE: fault handler
            try
            {
              this.extractProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Eget(&deleteCextractProcess);
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Erelease(&deleteCextractProcess);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess);
            }
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar3);
          }
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar3);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    private unsafe void ExtractDirectory(
      string directory,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool recursive,
      [MarshalAs(UnmanagedType.U1)] bool history)
    {
      uint num1 = 0;
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &outputPath);
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
          \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar2, &directory);
          // ISSUE: fault handler
          try
          {
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess1;
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E* deleteCextractProcessPtr;
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess2;
            if (history)
            {
              function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
              function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
              function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
              CSwgRepository* r;
              // ISSUE: fault handler
              try
              {
                r = this.r;
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
              }
              deleteCextractProcessPtr = \u003CModule\u003E.CSwgRepository\u002EExtractDirectoryWithHistory(r, &deleteCextractProcess1, &stdAllocatorChar2, recursive, &stdAllocatorChar1, cdeclFloatCharConstPtr);
              // ISSUE: fault handler
              try
              {
                num1 = 1U;
              }
              __fault
              {
                if (((int) num1 & 1) != 0)
                {
                  num1 &= 4294967294U;
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess1);
                }
              }
            }
            else
            {
              function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst3;
              function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst3;
              function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst3, &cdeclFloatCharConst1);
              // ISSUE: fault handler
              try
              {
                CSwgRepository* r;
                // ISSUE: fault handler
                try
                {
                  r = this.r;
                }
                __fault
                {
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
                }
                deleteCextractProcessPtr = \u003CModule\u003E.CSwgRepository\u002EExtractDirectory(r, &deleteCextractProcess2, &stdAllocatorChar1, recursive, &stdAllocatorChar1, cdeclFloatCharConstPtr);
                // ISSUE: fault handler
                try
                {
                  num1 = 2U;
                }
                __fault
                {
                  if (((int) num1 & 2) != 0)
                  {
                    num1 &= 4294967293U;
                    // ISSUE: method pointer
                    // ISSUE: cast to a function pointer type
                    \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess2);
                  }
                }
              }
              __fault
              {
                if (((int) num1 & 1) != 0)
                {
                  num1 &= 4294967294U;
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess1);
                }
              }
            }
            unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess3;
            // ISSUE: fault handler
            try
            {
              // ISSUE: fault handler
              try
              {
                \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bctor\u007D(&deleteCextractProcess3, deleteCextractProcessPtr);
              }
              __fault
              {
                if (((int) num1 & 2) != 0)
                {
                  num1 &= 4294967293U;
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess2);
                }
              }
              // ISSUE: fault handler
              try
              {
                if (((int) num1 & 2) != 0)
                {
                  num1 &= 4294967293U;
                  \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess2);
                }
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess3);
              }
            }
            __fault
            {
              if (((int) num1 & 1) != 0)
              {
                num1 &= 4294967294U;
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess1);
              }
            }
            // ISSUE: fault handler
            try
            {
              if (((int) num1 & 1) != 0)
              {
                uint num2 = num1 & 4294967294U;
                \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess1);
              }
              this.extractProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Eget(&deleteCextractProcess3);
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Erelease(&deleteCextractProcess3);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess3);
            }
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess3);
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
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    private unsafe void ExtractAll(string outputPath, [MarshalAs(UnmanagedType.U1)] bool history)
    {
      uint num1 = 0;
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &outputPath);
        // ISSUE: fault handler
        try
        {
          unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess1;
          unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E* deleteCextractProcessPtr;
          unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess2;
          if (history)
          {
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
            CSwgRepository* r;
            // ISSUE: fault handler
            try
            {
              r = this.r;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
            }
            deleteCextractProcessPtr = \u003CModule\u003E.CSwgRepository\u002EExtractAllWithHistory(r, &deleteCextractProcess1, &stdAllocatorChar, cdeclFloatCharConstPtr);
            // ISSUE: fault handler
            try
            {
              num1 = 1U;
            }
            __fault
            {
              if (((int) num1 & 1) != 0)
              {
                num1 &= 4294967294U;
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess1);
              }
            }
          }
          else
          {
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst3;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst3;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst3, &cdeclFloatCharConst1);
            // ISSUE: fault handler
            try
            {
              CSwgRepository* r;
              // ISSUE: fault handler
              try
              {
                r = this.r;
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
              }
              deleteCextractProcessPtr = \u003CModule\u003E.CSwgRepository\u002EExtractAll(r, &deleteCextractProcess2, &stdAllocatorChar, cdeclFloatCharConstPtr);
              // ISSUE: fault handler
              try
              {
                num1 = 2U;
              }
              __fault
              {
                if (((int) num1 & 2) != 0)
                {
                  num1 &= 4294967293U;
                  // ISSUE: method pointer
                  // ISSUE: cast to a function pointer type
                  \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess2);
                }
              }
            }
            __fault
            {
              if (((int) num1 & 1) != 0)
              {
                num1 &= 4294967294U;
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess1);
              }
            }
          }
          unique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E deleteCextractProcess3;
          // ISSUE: fault handler
          try
          {
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bctor\u007D(&deleteCextractProcess3, deleteCextractProcessPtr);
            }
            __fault
            {
              if (((int) num1 & 2) != 0)
              {
                num1 &= 4294967293U;
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess2);
              }
            }
            // ISSUE: fault handler
            try
            {
              if (((int) num1 & 2) != 0)
              {
                num1 &= 4294967293U;
                \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess2);
              }
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess3);
            }
          }
          __fault
          {
            if (((int) num1 & 1) != 0)
            {
              num1 &= 4294967294U;
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess1);
            }
          }
          // ISSUE: fault handler
          try
          {
            if (((int) num1 & 1) != 0)
            {
              uint num2 = num1 & 4294967294U;
              \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess1);
            }
            this.extractProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Eget(&deleteCextractProcess3);
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002Erelease(&deleteCextractProcess3);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCextractProcess3);
          }
          \u003CModule\u003E.std\u002Eunique_ptr\u003CCExtractProcess\u002Cstd\u003A\u003Adefault_delete\u003CCExtractProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCextractProcess3);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    public unsafe ExtractOperation(CSwgRepository* repo, Action<float, string> action)
    {
      this.r = repo;
      this.callback = action;
      this.started = false;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      ExtractOperation.ProgressEventDelegate progressEventDelegate = new ExtractOperation.ProgressEventDelegate(this.OnProgressChanged);
      this.del = progressEventDelegate;
      this.delH = GCHandle.Alloc((object) progressEventDelegate);
    }

    private unsafe void \u007EExtractOperation()
    {
      if (!this.started)
        return;
      this.delH.Free();
      \u003CModule\u003E.CExtractProcess\u002EKill(this.extractProcess);
      CExtractProcess* extractProcess = this.extractProcess;
      if ((IntPtr) extractProcess == IntPtr.Zero)
        return;
      \u003CModule\u003E.CExtractProcess\u002E\u007Bdtor\u007D(extractProcess);
      \u003CModule\u003E.delete((void*) extractProcess, 8UL);
    }

    public void StartExtractFiles(
      List<TreeEntry> files,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool appendTreeNameToOutputDirectory)
    {
      if (this.started)
        return;
      this.started = true;
      this.ExtractFiles(files, outputPath, appendTreeNameToOutputDirectory);
    }

    public void StartExtractFiles(
      List<string> files,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool appendTreeNameToOutputDirectory)
    {
      if (this.started)
        return;
      this.started = true;
      this.ExtractFiles(files, outputPath, appendTreeNameToOutputDirectory);
    }

    public void StartExtractAll(string outputPath, [MarshalAs(UnmanagedType.U1)] bool history)
    {
      if (this.started)
        return;
      this.started = true;
      this.ExtractAll(outputPath, history);
    }

    public void StartExtractDirectory(
      string directory,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool recursive,
      [MarshalAs(UnmanagedType.U1)] bool history)
    {
      if (this.started)
        return;
      this.started = true;
      this.ExtractDirectory(directory, outputPath, recursive, history);
    }

    public void StartExtractChain(List<TreeEntry> file, string outputPath)
    {
      if (this.started)
        return;
      this.started = true;
      this.ExtractChain(file, outputPath);
    }

    public void StartExtractChain(List<string> file, string outputPath)
    {
      if (this.started)
        return;
      this.started = true;
      this.ExtractChain(file, outputPath);
    }

    public unsafe void Wait() => \u003CModule\u003E.CExtractProcess\u002EWait(this.extractProcess);

    public unsafe void Kill() => \u003CModule\u003E.CExtractProcess\u002EKill(this.extractProcess);

    private void OnProgressChanged(float percent, string msg)
    {
      if (!((MulticastDelegate) this.callback != (MulticastDelegate) null))
        return;
      this.callback(percent, msg);
    }

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007EExtractOperation();
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

    private delegate void ProgressEventDelegate(float i, string __unnamed001);
  }
}
