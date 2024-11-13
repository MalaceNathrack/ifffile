// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.UsageIndexEntry
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class UsageIndexEntry : BaseIndexEntry
  {
    public List<ushort> CustomizationDataIndex = new List<ushort>();

    public UsageIndexEntry()
    {
    }

    public UsageIndexEntry(AssetEntry assetEntry)
    {
      this.SetBaseEntryValues((BaseEntry) assetEntry);
    }

    public UsageIndexEntry(ushort assetID, ushort listStartIndex, byte listItemCount)
    {
      this.SetBaseIndexValues(assetID, listStartIndex, listItemCount);
    }

    public UsageIndexEntry(UsageIndexEntry oldUsageIndexEntry)
    {
      foreach (ushort num in oldUsageIndexEntry.CustomizationDataIndex)
        this.CustomizationDataIndex.Add(num);
      this.SetBaseIndexValues((BaseIndexEntry) oldUsageIndexEntry);
    }
  }
}
