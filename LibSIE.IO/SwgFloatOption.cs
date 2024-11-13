// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.SwgFloatOption
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System;

#nullable disable
namespace LibSIE.IO
{
  public class SwgFloatOption : IIffSerialisable
  {
    public const int FLT = 542395462;
    public Type type = typeof (float);
    public float value;
    public string className;
    public string variableName;

    public SwgFloatOption(IffStream iffStream) => this.ReadObject(iffStream);

    public SwgFloatOption()
    {
    }

    public void ReadObject(IffStream iffStream)
    {
      iffStream.OpenChunk(542395462U);
      this.value = iffStream.GetFloat();
      this.className = iffStream.GetString();
      this.variableName = iffStream.GetString();
      iffStream.CloseChunk(542395462U);
    }

    public void WriteObject(IffWriter iffWriter)
    {
      iffWriter.OpenChunk(542395462U);
      iffWriter.Write(this.value);
      iffWriter.Write(this.className);
      iffWriter.Write(this.variableName);
      iffWriter.CloseChunk(542395462U);
    }
  }
}
