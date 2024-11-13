// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.Iff.IIffSerialisable
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO.Iff
{
  public interface IIffSerialisable
  {
    void ReadObject(IffStream iffStream);

    void WriteObject(IffWriter iffWriter);
  }
}
