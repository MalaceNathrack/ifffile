// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.MachineOptions
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class MachineOptions : IIffSerialisable
  {
    public const int OPTN = 1314148431;
    public List<IIffSerialisable> options = new List<IIffSerialisable>();

    public void ReadObject(IffStream iffStream)
    {
      iffStream.OpenForm(1314148431U);
      iffStream.OpenForm(842018864U);
      uint num = iffStream.RemainingSubChunks();
      for (uint index = 0; index < num; ++index)
      {
        switch (iffStream.NextType())
        {
          case 542395462:
            this.options.Add((IIffSerialisable) new SwgFloatOption(iffStream));
            break;
          case 542395977:
            this.options.Add((IIffSerialisable) new SwgIntOption(iffStream));
            break;
          case 1280266050:
            this.options.Add((IIffSerialisable) new SwgBoolOption(iffStream));
            break;
        }
      }
      iffStream.CloseForm(842018864U);
      iffStream.CloseForm(1314148431U);
    }

    public void WriteObject(IffWriter iffWriter)
    {
      iffWriter.OpenForm(1314148431U);
      iffWriter.OpenForm(858796080U);
      iffWriter.CloseForm(858796080U);
      iffWriter.CloseForm(1314148431U);
    }
  }
}
