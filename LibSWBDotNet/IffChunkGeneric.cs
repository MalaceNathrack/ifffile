// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.IffChunkGeneric
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class IffChunkGeneric
  {
    private List<IffChunkGeneric> Children;
    private IffChunkGenericData Data;

    public IffChunkGeneric([MarshalAs(UnmanagedType.U1)] bool isForm, uint id, byte[] data)
    {
      this.Data = new IffChunkGenericData(isForm, id, data);
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public IffChunkGeneric([MarshalAs(UnmanagedType.U1)] bool isForm, uint id)
    {
      this.Data = new IffChunkGenericData(isForm, id);
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public List<IffChunkGeneric> GetChildren() => this.Children;

    public IffChunkGenericData GetData() => this.Data;
  }
}
