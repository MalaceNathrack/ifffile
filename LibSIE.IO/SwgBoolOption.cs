// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.SwgBoolOption
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System;

#nullable disable
namespace LibSIE.IO
{
  public class SwgBoolOption : IIffSerialisable
  {
    public const int BOOL = 1280266050;
    public Type type = typeof (bool);
    public bool value;
    public string className;
    public string variableName;

    public SwgBoolOption(IffStream iffStream) => this.ReadObject(iffStream);

    public SwgBoolOption()
    {
    }

    public void ReadObject(IffStream iffStream)
    {
      iffStream.OpenChunk(1280266050U);
      this.value = iffStream.GetBoolean();
      this.className = iffStream.GetString();
      this.variableName = iffStream.GetString();
      iffStream.CloseChunk(1280266050U);
    }

    public void WriteObject(IffWriter iffWriter)
    {
      iffWriter.OpenChunk(1280266050U);
      iffWriter.Write(this.value);
      iffWriter.Write(this.className);
      iffWriter.Write(this.variableName);
      iffWriter.CloseChunk(1280266050U);
    }
  }
}
