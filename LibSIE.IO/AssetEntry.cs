// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.AssetEntry
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSWBDotNet;
using System;

#nullable disable
namespace LibSIE.IO
{
  public class AssetEntry : BaseEntry
  {
    public UsageIndexEntry UsageEntry = new UsageIndexEntry();
    public LinkIndexEntry LinkEntry = new LinkIndexEntry();

    public AssetEntry(ushort assetID, string filename, uint filenameCRC)
    {
      this.SetBaseEntryValues(assetID, filename, filenameCRC);
    }

    public AssetEntry(AssetCustomizationManagerBase acm, string filename)
    {
      this.SetBaseEntryValues(this.GetHighestID(acm), filename.Replace('\\', '/'), SwgCrc.Crc32(filename));
    }

    public ushort GetHighestID(AssetCustomizationManagerBase acm)
    {
      ushort val1 = 0;
      foreach (AssetEntry assetEntry in acm.AssetEntries)
        val1 = (ushort) ((uint) Math.Max(val1, assetEntry.AssetID) + 1U);
      return val1;
    }
  }
}
