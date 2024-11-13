// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.Iff.IffObject
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System.IO;

#nullable disable
namespace LibSIE.IO.Iff
{
  public static class IffObject
  {
    public static T Clone<T>(T iff) where T : IIffSerialisable, new()
    {
      IffWriter iffWriter = new IffWriter();
      iff.WriteObject(iffWriter);
      T obj = new T();
      obj.ReadObject(new IffStream(iffWriter.Data()));
      return obj;
    }

    public static void SaveToFile(IIffSerialisable iff, string filename)
    {
      IffWriter iffWriter = new IffWriter();
      iff.WriteObject(iffWriter);
      FileStream fileStream = File.Open(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
      byte[] buffer = iffWriter.Data();
      fileStream.Write(buffer, 0, buffer.Length);
      fileStream.Close();
    }

    public static byte[] Bytes(IIffSerialisable iff)
    {
      IffWriter iffWriter = new IffWriter();
      iff.WriteObject(iffWriter);
      return iffWriter.Data();
    }
  }
}
