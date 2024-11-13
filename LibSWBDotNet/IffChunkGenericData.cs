// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.IffChunkGenericData
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class IffChunkGenericData
  {
    private readonly bool bIsForm;
    private uint Id;
    private List<byte> Data;

    public IffChunkGenericData([MarshalAs(UnmanagedType.U1)] bool isForm, string id, byte[] data)
    {
      this.bIsForm = isForm;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SetId(id);
      List<byte> byteList = new List<byte>();
      this.Data = byteList;
      byteList.Clear();
      this.Data.AddRange((IEnumerable<byte>) data);
    }

    public IffChunkGenericData([MarshalAs(UnmanagedType.U1)] bool isForm, uint id, byte[] data)
    {
      this.bIsForm = isForm;
      this.Id = id;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      List<byte> byteList = new List<byte>();
      this.Data = byteList;
      byteList.Clear();
      this.Data.AddRange((IEnumerable<byte>) data);
    }

    public IffChunkGenericData([MarshalAs(UnmanagedType.U1)] bool isForm, string id)
    {
      this.bIsForm = isForm;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SetId(id);
      this.Data = new List<byte>();
    }

    public IffChunkGenericData([MarshalAs(UnmanagedType.U1)] bool isForm, uint id)
    {
      this.bIsForm = isForm;
      this.Id = id;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Data = new List<byte>();
    }

    public List<byte> GetData() => this.Data;

    [return: MarshalAs(UnmanagedType.U1)]
    public bool IsForm() => this.bIsForm;

    public uint GetId() => \u003CModule\u003E.FlipEndian(this.Id);

    public unsafe void SetId(string str)
    {
      if (str.Length != 4)
        return;
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &str);
      // ISSUE: fault handler
      try
      {
        this.Id = \u003CModule\u003E.StringToTag(&stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
    }

    public void SetId(uint id) => this.Id = \u003CModule\u003E.FlipEndian(id);

    public unsafe string GetIdString()
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.TagToString(&stdAllocatorChar, this.Id);
      string idString;
      // ISSUE: fault handler
      try
      {
        idString = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str(&stdAllocatorChar));
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      return idString;
    }
  }
}
