// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.SwgIntOption
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System;

#nullable disable
namespace LibSIE.IO
{
  public class SwgIntOption : IIffSerialisable
  {
    public const int INT = 542395977;
    public Type type = typeof (int);
    public int value;
    public string className;
    public string variableName;

    public SwgIntOption(IffStream iffStream) => this.ReadObject(iffStream);

    public SwgIntOption()
    {
    }

    public void ReadObject(IffStream iffStream)
    {
      iffStream.OpenChunk(542395977U);
      this.value = iffStream.GetInt32();
      this.className = iffStream.GetString();
      this.variableName = iffStream.GetString();
      iffStream.CloseChunk(542395977U);
    }

    public void WriteObject(IffWriter iffWriter)
    {
      iffWriter.OpenChunk(542395977U);
      iffWriter.Write(this.value);
      iffWriter.Write(this.className);
      iffWriter.Write(this.variableName);
      iffWriter.CloseChunk(542395977U);
    }
  }
}
