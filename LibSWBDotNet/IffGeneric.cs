// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.IffGeneric
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
  public class IffGeneric : IDisposable
  {
    private List<IffChunkGeneric> Chunks = new List<IffChunkGeneric>();

    private unsafe IffChunkGeneric BuildChunk(SIffChunkGeneric* parent_chunk)
    {
      if (\u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize((vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) parent_chunk) <= 0UL)
        return new IffChunkGeneric((bool) *(byte*) ((IntPtr) parent_chunk + 56L), (uint) *(int*) ((IntPtr) parent_chunk + 24L));
      byte[] data = new byte[(int) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize((vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) parent_chunk)];
      byte[] numArray = data;
      fixed (byte* numPtr = &numArray[numArray.GetLowerBound(0)])
      {
        \u003CModule\u003E.\u003FA0x0caf3e0f\u002Ememcpy_s((void*) numPtr, \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize((vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) parent_chunk), (void*) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u005B\u005D((vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) parent_chunk, 0UL), \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Esize((vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) parent_chunk));
        return new IffChunkGeneric((bool) *(byte*) ((IntPtr) parent_chunk + 56L), (uint) *(int*) ((IntPtr) parent_chunk + 24L), data);
      }
    }

    private unsafe void AddChildChunks(IffChunkGeneric parent, SIffChunkGeneric* parent_chunk)
    {
      IffChunkGeneric parent1 = this.BuildChunk(parent_chunk);
      vector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E* siffChunkGenericPtr1 = (vector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) parent_chunk + 32L);
      _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E siffChunkGeneric1;
      \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Ebegin(siffChunkGenericPtr1, &siffChunkGeneric1);
      _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E siffChunkGeneric2;
      \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eend(siffChunkGenericPtr1, &siffChunkGeneric2);
      if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric1, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric2))
      {
        do
        {
          unique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E* siffChunkGenericPtr2 = \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&siffChunkGeneric1);
          this.AddChildChunks(parent1, \u003CModule\u003E.std\u002Eunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Eget(siffChunkGenericPtr2));
          \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&siffChunkGeneric1);
        }
        while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric1, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric2));
      }
      parent.GetChildren().Add(parent1);
    }

    public unsafe IffGeneric(byte[] bytes)
    {
      vector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (ulong) bytes.Length);
      // ISSUE: fault handler
      try
      {
        IntPtr destination = new IntPtr((void*) \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u005B\u005D(&stdAllocatorChar1, 0UL));
        Marshal.Copy(bytes, 0, destination, bytes.Length);
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar2, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_00CNPNBAHC\u0040\u003F\u0024AA\u0040);
        CIffReader ciffReader;
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.CIffReader\u002E\u007Bctor\u007D(&ciffReader, &stdAllocatorChar2, &stdAllocatorChar1);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar2);
          unique_ptr\u003CCIffFileGeneric\u002Cstd\u003A\u003Adefault_delete\u003CCIffFileGeneric\u003E\u0020\u003E deleteCiffFileGeneric;
          \u003CModule\u003E.CIffFileGeneric\u002ECreate(&deleteCiffFileGeneric, &ciffReader);
          // ISSUE: fault handler
          try
          {
            vector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E* siffChunkGenericPtr1 = (vector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) \u003CModule\u003E.std\u002Eunique_ptr\u003CCIffFileGeneric\u002Cstd\u003A\u003Adefault_delete\u003CCIffFileGeneric\u003E\u0020\u003E\u002E\u002D\u003E(&deleteCiffFileGeneric);
            _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E siffChunkGeneric1;
            \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Ebegin(siffChunkGenericPtr1, &siffChunkGeneric1);
            _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E siffChunkGeneric2;
            \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eend(siffChunkGenericPtr1, &siffChunkGeneric2);
            if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric1, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric2))
            {
              do
              {
                unique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E* siffChunkGenericPtr2 = \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&siffChunkGeneric1);
                IffChunkGeneric parent = this.BuildChunk(\u003CModule\u003E.std\u002Eunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Eget(siffChunkGenericPtr2));
                vector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E* siffChunkGenericPtr3 = (vector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) \u003CModule\u003E.std\u002Eunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002E\u002D\u003E(siffChunkGenericPtr2) + 32L);
                _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E siffChunkGeneric3;
                \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Ebegin(siffChunkGenericPtr3, &siffChunkGeneric3);
                _Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E siffChunkGeneric4;
                \u003CModule\u003E.std\u002Evector\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Cstd\u003A\u003Aallocator\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002Eend(siffChunkGenericPtr3, &siffChunkGeneric4);
                if (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric3, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric4))
                {
                  do
                  {
                    unique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E* siffChunkGenericPtr4 = \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002A(&siffChunkGeneric3);
                    this.AddChildChunks(parent, \u003CModule\u003E.std\u002Eunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u002Eget(siffChunkGenericPtr4));
                    \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&siffChunkGeneric3);
                  }
                  while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric3, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric4));
                }
                this.Chunks.Add(parent);
                \u003CModule\u003E.std\u002E_Vector_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u002B\u002B(&siffChunkGeneric1);
              }
              while (\u003CModule\u003E.std\u002E_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u002E\u0021\u003D((_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric1, (_Vector_const_iterator\u003Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cstd\u003A\u003Aunique_ptr\u003CSIffChunkGeneric\u002Cstd\u003A\u003Adefault_delete\u003CSIffChunkGeneric\u003E\u0020\u003E\u0020\u003E\u0020\u003E\u0020\u003E*) &siffChunkGeneric2));
            }
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCIffFileGeneric\u002Cstd\u003A\u003Adefault_delete\u003CCIffFileGeneric\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteCiffFileGeneric);
          }
          \u003CModule\u003E.std\u002Eunique_ptr\u003CCIffFileGeneric\u002Cstd\u003A\u003Adefault_delete\u003CCIffFileGeneric\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteCiffFileGeneric);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(CIffReader\u002E\u007Bdtor\u007D), (void*) &ciffReader);
        }
        \u003CModule\u003E.CIffReader\u002E\u007Bdtor\u007D(&ciffReader);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      \u003CModule\u003E.std\u002Evector\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar1);
    }

    private void \u007EIffGeneric()
    {
    }

    public List<IffChunkGeneric> GetChunks() => this.Chunks;

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
        return;
      // ISSUE: explicit finalizer call
      this.Finalize();
    }

    public virtual void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }
  }
}
