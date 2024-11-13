// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.Repository
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
  public class Repository : IDisposable
  {
    private unsafe CSwgRepository* r;

    public unsafe void Initialise(
      CSwgRepository.SConfiguation* config,
      List<PrioritisedFile> files,
      [MarshalAs(UnmanagedType.U1)] bool storeNames,
      [MarshalAs(UnmanagedType.U1)] bool storeHistory,
      [MarshalAs(UnmanagedType.U1)] bool useFileOverrides)
    {
      CSwgRepository* cswgRepositoryPtr1 = (CSwgRepository*) \u003CModule\u003E.@new(848UL);
      CSwgRepository* cswgRepositoryPtr2;
      // ISSUE: fault handler
      try
      {
        cswgRepositoryPtr2 = (IntPtr) cswgRepositoryPtr1 == IntPtr.Zero ? (CSwgRepository*) 0L : \u003CModule\u003E.CSwgRepository\u002E\u007Bctor\u007D(cswgRepositoryPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) cswgRepositoryPtr1, 848UL);
      }
      this.r = cswgRepositoryPtr2;
      vector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E sprioritisedFile1;
      \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002E\u007Bctor\u007D(&sprioritisedFile1);
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Ereserve(&sprioritisedFile1, (ulong) files.Count);
        List<PrioritisedFile>.Enumerator enumerator = files.GetEnumerator();
        if (enumerator.MoveNext())
        {
          do
          {
            PrioritisedFile current = enumerator.Current;
            string path = current.Path;
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* pThis = &stdAllocatorChar;
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &path);
            int priority;
            // ISSUE: fault handler
            try
            {
              priority = current.Priority;
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
            }
            SPrioritisedFile sprioritisedFile2;
            SPrioritisedFile* sprioritisedFilePtr = \u003CModule\u003E.SPrioritisedFile\u002E\u007Bctor\u007D(&sprioritisedFile2, stdAllocatorCharPtr, priority);
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002Eemplace_back\u003Cstruct\u0020SPrioritisedFile\u003E(&sprioritisedFile1, sprioritisedFilePtr);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(SPrioritisedFile\u002E\u007Bdtor\u007D), (void*) &sprioritisedFile2);
            }
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) &sprioritisedFile2);
          }
          while (enumerator.MoveNext());
        }
        *(sbyte*) ((IntPtr) config + 1L) = (sbyte) storeHistory;
        *(sbyte*) config = (sbyte) storeNames;
        *(sbyte*) ((IntPtr) config + 2L) = (sbyte) useFileOverrides;
        \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002ESetFiles(config, &sprioritisedFile1);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &sprioritisedFile1);
      }
      \u003CModule\u003E.std\u002Evector\u003CSPrioritisedFile\u002Cstd\u003A\u003Aallocator\u003CSPrioritisedFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&sprioritisedFile1);
    }

    public unsafe Repository(
      string basePath,
      List<PrioritisedFile> files,
      List<string> additionalOverrides,
      [MarshalAs(UnmanagedType.U1)] bool storeNames,
      [MarshalAs(UnmanagedType.U1)] bool storeHistory,
      [MarshalAs(UnmanagedType.U1)] bool useFileOverrides)
    {
      vector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E stdAllocatorWcharT1;
      \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorWcharT1);
      // ISSUE: fault handler
      try
      {
        List<string>.Enumerator enumerator = additionalOverrides.GetEnumerator();
        if (enumerator.MoveNext())
        {
          do
          {
            string current = enumerator.Current;
            basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT2;
            basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr = \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT2, &current);
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eemplace_back\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E(&stdAllocatorWcharT1, stdAllocatorWcharTPtr);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT2);
            }
            \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT2);
          }
          while (enumerator.MoveNext());
        }
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT3;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT3, &basePath);
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT4;
          basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr = &stdAllocatorWcharT4;
          basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* repositoryScriptFileName = \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetDefaultRepositoryScriptFileName(&stdAllocatorWcharT4);
          CSwgRepository.SConfiguation sconfiguation;
          \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bctor\u007D(&sconfiguation, repositoryScriptFileName);
          // ISSUE: fault handler
          try
          {
            this.Initialise(&sconfiguation, files, storeNames, storeHistory, useFileOverrides);
            \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u003D((vector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) &sconfiguation + 72), &stdAllocatorWcharT1);
            \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u003D((basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E*) ((IntPtr) &sconfiguation + 8), &stdAllocatorWcharT3);
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst;
            function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst, (void*) 0L);
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
            \u003CModule\u003E.CSwgRepository\u002EBuild(r, &sconfiguation, cdeclFloatCharConstPtr);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D), (void*) &sconfiguation);
          }
          \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D(&sconfiguation);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT3);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT3);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT1);
      }
      \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT1);
    }

    public unsafe Repository(string luaScriptFileName)
    {
      CSwgRepository* cswgRepositoryPtr1 = (CSwgRepository*) \u003CModule\u003E.@new(848UL);
      CSwgRepository* cswgRepositoryPtr2;
      // ISSUE: fault handler
      try
      {
        cswgRepositoryPtr2 = (IntPtr) cswgRepositoryPtr1 == IntPtr.Zero ? (CSwgRepository*) 0L : \u003CModule\u003E.CSwgRepository\u002E\u007Bctor\u007D(cswgRepositoryPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) cswgRepositoryPtr1, 848UL);
      }
      this.r = cswgRepositoryPtr2;
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT1, &luaScriptFileName);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT2;
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr1 = &stdAllocatorWcharT2;
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr2 = \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorWcharT2, &stdAllocatorWcharT1);
        CSwgRepository.SConfiguation sconfiguation;
        \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bctor\u007D(&sconfiguation, stdAllocatorWcharTPtr2);
        // ISSUE: fault handler
        try
        {
          function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst;
          function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst;
          function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst, (void*) 0L);
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
          \u003CModule\u003E.CSwgRepository\u002EBuild(r, &sconfiguation, cdeclFloatCharConstPtr);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D), (void*) &sconfiguation);
        }
        \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D(&sconfiguation);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT1);
    }

    public unsafe Repository()
    {
      CSwgRepository* cswgRepositoryPtr1 = (CSwgRepository*) \u003CModule\u003E.@new(848UL);
      CSwgRepository* cswgRepositoryPtr2;
      // ISSUE: fault handler
      try
      {
        cswgRepositoryPtr2 = (IntPtr) cswgRepositoryPtr1 == IntPtr.Zero ? (CSwgRepository*) 0L : \u003CModule\u003E.CSwgRepository\u002E\u007Bctor\u007D(cswgRepositoryPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) cswgRepositoryPtr1, 848UL);
      }
      this.r = cswgRepositoryPtr2;
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT;
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* stdAllocatorWcharTPtr = &stdAllocatorWcharT;
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E* repositoryScriptFileName = \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002EGetDefaultRepositoryScriptFileName(&stdAllocatorWcharT);
      CSwgRepository.SConfiguation sconfiguation;
      \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bctor\u007D(&sconfiguation, repositoryScriptFileName);
      // ISSUE: fault handler
      try
      {
        function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst;
        function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst;
        function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst, (void*) 0L);
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
        \u003CModule\u003E.CSwgRepository\u002EBuild(r, &sconfiguation, cdeclFloatCharConstPtr);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D), (void*) &sconfiguation);
      }
      \u003CModule\u003E.CSwgRepository\u002ESConfiguation\u002E\u007Bdtor\u007D(&sconfiguation);
    }

    private unsafe void \u007ERepository()
    {
      CSwgRepository* r = this.r;
      if ((IntPtr) r == IntPtr.Zero)
        return;
      \u003CModule\u003E.CSwgRepository\u002E\u007Bdtor\u007D(r);
      \u003CModule\u003E.delete((void*) r, 848UL);
    }

    public unsafe CSwgRepository* GetNativeRepository() => this.r;

    public static unsafe void CreateTOCsForTrees(string sourceDirectory, string outputPath)
    {
      basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT1, &outputPath);
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E stdAllocatorWcharT2;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cwchar_t\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorWcharT2, &sourceDirectory);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.CSwgRepository\u002ECreateTOCsPerTree(&stdAllocatorWcharT2, &stdAllocatorWcharT1);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT2);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorWcharT1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cwchar_t\u002Cstd\u003A\u003Achar_traits\u003Cwchar_t\u003E\u002Cstd\u003A\u003Aallocator\u003Cwchar_t\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorWcharT1);
    }

    public unsafe void Purge()
    {
      CSwgRepository* r = this.r;
      if ((IntPtr) r != IntPtr.Zero)
      {
        \u003CModule\u003E.CSwgRepository\u002E\u007Bdtor\u007D(r);
        \u003CModule\u003E.delete((void*) r, 848UL);
      }
      this.r = (CSwgRepository*) 0L;
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public unsafe bool ContainsFile(string path)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &path);
      bool flag;
      // ISSUE: fault handler
      try
      {
        flag = \u003CModule\u003E.CSwgRepository\u002EContains(this.r, &stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      return flag;
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public unsafe bool ContainsFile(uint crc)
    {
      return \u003CModule\u003E.CSwgRepository\u002EContains(this.r, crc);
    }

    public unsafe TreeEntry[] Entries([MarshalAs(UnmanagedType.U1)] bool allVersions)
    {
      vector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E srepositoryEntryInfo1;
      \u003CModule\u003E.CSwgRepository\u002EGetEntries(this.r, &srepositoryEntryInfo1, allVersions);
      TreeEntry[] treeEntryArray;
      // ISSUE: fault handler
      try
      {
        treeEntryArray = new TreeEntry[(int) \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Esize(&srepositoryEntryInfo1)];
        int index = 0;
        _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E srepositoryEntryInfo2;
        \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Ebegin(&srepositoryEntryInfo1, &srepositoryEntryInfo2);
        _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E srepositoryEntryInfo3;
        \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Eend(&srepositoryEntryInfo1, &srepositoryEntryInfo3);
        if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo2, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo3))
        {
          do
          {
            CSwgRepository.SRepositoryEntryInfo* n = \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&srepositoryEntryInfo2);
            treeEntryArray[index] = new TreeEntry(n);
            ++index;
            \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&srepositoryEntryInfo2);
          }
          while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo2, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo3));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo1);
      }
      \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&srepositoryEntryInfo1);
      return treeEntryArray;
    }

    public unsafe TreeEntry[] EntriesForDirectory(string dir, [MarshalAs(UnmanagedType.U1)] bool recursive)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &dir);
      TreeEntry[] treeEntryArray;
      // ISSUE: fault handler
      try
      {
        vector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E srepositoryEntryInfo1;
        \u003CModule\u003E.CSwgRepository\u002EGetEntriesForDirectory(this.r, &srepositoryEntryInfo1, &stdAllocatorChar, recursive, false);
        // ISSUE: fault handler
        try
        {
          treeEntryArray = new TreeEntry[(int) \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Esize(&srepositoryEntryInfo1)];
          int index = 0;
          _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E srepositoryEntryInfo2;
          \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Ebegin(&srepositoryEntryInfo1, &srepositoryEntryInfo2);
          _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E srepositoryEntryInfo3;
          \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Eend(&srepositoryEntryInfo1, &srepositoryEntryInfo3);
          if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo2, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo3))
          {
            do
            {
              CSwgRepository.SRepositoryEntryInfo* n = \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&srepositoryEntryInfo2);
              treeEntryArray[index] = new TreeEntry(n);
              ++index;
              \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&srepositoryEntryInfo2);
            }
            while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo2, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo3));
          }
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
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      return treeEntryArray;
    }

    public unsafe TreeEntry[] EntriesForFile(string file)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &file);
      TreeEntry[] treeEntryArray;
      // ISSUE: fault handler
      try
      {
        vector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E srepositoryEntryInfo1;
        \u003CModule\u003E.CSwgRepository\u002EGetHistoryForFile(this.r, &srepositoryEntryInfo1, &stdAllocatorChar);
        // ISSUE: fault handler
        try
        {
          treeEntryArray = new TreeEntry[(int) \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Esize(&srepositoryEntryInfo1)];
          int index = 0;
          _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E srepositoryEntryInfo2;
          \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Ebegin(&srepositoryEntryInfo1, &srepositoryEntryInfo2);
          _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E srepositoryEntryInfo3;
          \u003CModule\u003E.std\u002Evector\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u002Cstd\u003A\u003Aallocator\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u002Eend(&srepositoryEntryInfo1, &srepositoryEntryInfo3);
          if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo2, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo3))
          {
            do
            {
              CSwgRepository.SRepositoryEntryInfo* n = \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&srepositoryEntryInfo2);
              treeEntryArray[index] = new TreeEntry(n);
              ++index;
              \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&srepositoryEntryInfo2);
            }
            while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo2, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003CCSwgRepository\u003A\u003ASRepositoryEntryInfo\u003E\u0020\u003E\u0020\u003E*) &srepositoryEntryInfo3));
          }
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
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      return treeEntryArray;
    }

    public unsafe TreeEntry Entry(string file)
    {
      if (!this.ContainsFile(file))
        return (TreeEntry) null;
      string str = file;
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &str);
      uint num;
      // ISSUE: fault handler
      try
      {
        num = \u003CModule\u003E.SwgCrc\u002ECrc32(&stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      CSwgRepository.SRepositoryEntryInfo srepositoryEntryInfo;
      \u003CModule\u003E.CSwgRepository\u002EGetEntryForFile(this.r, &srepositoryEntryInfo, num);
      TreeEntry treeEntry;
      // ISSUE: fault handler
      try
      {
        treeEntry = new TreeEntry(&srepositoryEntryInfo);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo);
      }
      \u003CModule\u003E.CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D(&srepositoryEntryInfo);
      return treeEntry;
    }

    public unsafe string[] DirectoryNames()
    {
      vector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E* directoryNames = \u003CModule\u003E.CSwgRepository\u002EGetDirectoryNames(this.r);
      string[] strArray = new string[(int) \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Esize(directoryNames)];
      int index = 0;
      _Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Ebegin(directoryNames, &stdAllocatorChar1);
      _Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E stdAllocatorChar2;
      \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eend(directoryNames, &stdAllocatorChar2);
      if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D(&stdAllocatorChar1, &stdAllocatorChar2))
      {
        do
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&stdAllocatorChar1);
          strArray[index] = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(stdAllocatorCharPtr));
          ++index;
          \u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&stdAllocatorChar1);
        }
        while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Abasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D(&stdAllocatorChar1, &stdAllocatorChar2));
      }
      return strArray;
    }

    public unsafe byte[] OpenAsVector(TreeEntry path)
    {
      CSwgRepository.SRepositoryEntryInfo srepositoryEntryInfo;
      path.ToNativeEntryInfo(&srepositoryEntryInfo);
      byte[] numArray1;
      // ISSUE: fault handler
      try
      {
        vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
        \u003CModule\u003E.CSwgRepository\u002EOpenAsVector(this.r, &stdAllocatorChar, &srepositoryEntryInfo);
        // ISSUE: fault handler
        try
        {
          if (!\u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eempty(&stdAllocatorChar))
          {
            byte[] numArray2 = new byte[(int) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize(&stdAllocatorChar)];
            byte[] numArray3 = numArray2;
            fixed (byte* numPtr = &numArray3[numArray3.GetLowerBound(0)])
            {
              \u003CModule\u003E.\u003FA0xc03709c5\u002Ememcpy_s((void*) numPtr, \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize(&stdAllocatorChar), (void*) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u005B\u005D(&stdAllocatorChar, 0UL), \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize(&stdAllocatorChar));
              numArray1 = numArray2;
            }
          }
          else
            numArray1 = new byte[0];
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
        }
        \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D), (void*) &srepositoryEntryInfo);
      }
      \u003CModule\u003E.CSwgRepository\u002ESRepositoryEntryInfo\u002E\u007Bdtor\u007D(&srepositoryEntryInfo);
      return numArray1;
    }

    public unsafe byte[] OpenAsVector(string path)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar1, &path);
      byte[] numArray1;
      // ISSUE: fault handler
      try
      {
        vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.CSwgRepository\u002EOpenAsVector(this.r, &stdAllocatorChar2, &stdAllocatorChar1);
        // ISSUE: fault handler
        try
        {
          if (!\u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eempty(&stdAllocatorChar2))
          {
            byte[] numArray2 = new byte[(int) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize(&stdAllocatorChar2)];
            byte[] numArray3 = numArray2;
            fixed (byte* numPtr = &numArray3[numArray3.GetLowerBound(0)])
            {
              \u003CModule\u003E.\u003FA0xc03709c5\u002Ememcpy_s((void*) numPtr, \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize(&stdAllocatorChar2), (void*) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u005B\u005D(&stdAllocatorChar2, 0UL), \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize(&stdAllocatorChar2));
              numArray1 = numArray2;
            }
          }
          else
            numArray1 = new byte[0];
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
      return numArray1;
    }

    public unsafe ExtractOperation Extract(
      List<TreeEntry> files,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool appendTreeNameToOutputDirectory,
      Action<float, string> callback)
    {
      ExtractOperation extractOperation = new ExtractOperation(this.r, callback);
      extractOperation.StartExtractFiles(files, outputPath, appendTreeNameToOutputDirectory);
      return extractOperation;
    }

    public unsafe ExtractOperation Extract(
      List<string> files,
      string outputPath,
      [MarshalAs(UnmanagedType.U1)] bool appendTreeNameToOutputDirectory,
      Action<float, string> callback)
    {
      ExtractOperation extractOperation = new ExtractOperation(this.r, callback);
      extractOperation.StartExtractFiles(files, outputPath, appendTreeNameToOutputDirectory);
      return extractOperation;
    }

    public unsafe ExtractOperation Extract(
      TreeEntry entry,
      string outfile,
      Action<float, string> callback)
    {
      ExtractOperation extractOperation = new ExtractOperation(this.r, callback);
      extractOperation.StartExtractFiles(new List<TreeEntry>()
      {
        entry
      }, outfile, false);
      return extractOperation;
    }

    public unsafe ExtractOperation Extract(
      string file,
      string outfile,
      Action<float, string> callback)
    {
      ExtractOperation extractOperation = new ExtractOperation(this.r, callback);
      extractOperation.StartExtractFiles(new List<string>()
      {
        file
      }, outfile, false);
      return extractOperation;
    }

    public unsafe ExtractOperation ExtractChain(
      List<TreeEntry> files,
      string outfile,
      Action<float, string> callback)
    {
      ExtractOperation chain = new ExtractOperation(this.r, callback);
      chain.StartExtractChain(files, outfile);
      return chain;
    }

    public unsafe ExtractOperation ExtractChain(
      List<string> files,
      string outfile,
      Action<float, string> callback)
    {
      ExtractOperation chain = new ExtractOperation(this.r, callback);
      chain.StartExtractChain(files, outfile);
      return chain;
    }

    public unsafe ExtractOperation ExtractChain(
      TreeEntry entry,
      string outfile,
      Action<float, string> callback)
    {
      ExtractOperation chain = new ExtractOperation(this.r, callback);
      chain.StartExtractChain(new List<TreeEntry>()
      {
        entry
      }, outfile);
      return chain;
    }

    public unsafe ExtractOperation ExtractChain(
      string file,
      string outfile,
      Action<float, string> callback)
    {
      ExtractOperation chain = new ExtractOperation(this.r, callback);
      chain.StartExtractChain(new List<string>() { file }, outfile);
      return chain;
    }

    public unsafe ExtractOperation ExtractDirectory(
      string directory,
      string outPathBase,
      [MarshalAs(UnmanagedType.U1)] bool recursive,
      Action<float, string> callback)
    {
      ExtractOperation directory1 = new ExtractOperation(this.r, callback);
      directory1.StartExtractDirectory(directory, outPathBase, recursive, false);
      return directory1;
    }

    public unsafe ExtractOperation ExtractDirectoryWithHistory(
      string directory,
      string outPathBase,
      [MarshalAs(UnmanagedType.U1)] bool recursive,
      Action<float, string> callback)
    {
      ExtractOperation directoryWithHistory = new ExtractOperation(this.r, callback);
      directoryWithHistory.StartExtractDirectory(directory, outPathBase, recursive, true);
      return directoryWithHistory;
    }

    public unsafe ExtractOperation ExtractAll(string outPathBase, Action<float, string> callback)
    {
      ExtractOperation all = new ExtractOperation(this.r, callback);
      all.StartExtractAll(outPathBase, false);
      return all;
    }

    public unsafe ExtractOperation ExtractAllWithHistory(
      string outPathBase,
      Action<float, string> callback)
    {
      ExtractOperation allWithHistory = new ExtractOperation(this.r, callback);
      allWithHistory.StartExtractAll(outPathBase, true);
      return allWithHistory;
    }

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007ERepository();
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
