// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.LinkIndexEntry
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class LinkIndexEntry : BaseIndexEntry
  {
    public Dictionary<uint, BaseEntry> UsageChildren = new Dictionary<uint, BaseEntry>();
    public Dictionary<uint, LinkIndexEntry> LinkedChildren = new Dictionary<uint, LinkIndexEntry>();

    public LinkIndexEntry()
    {
    }

    public LinkIndexEntry(AssetEntry assetEntry) => this.SetBaseEntryValues((BaseEntry) assetEntry);

    public LinkIndexEntry(
      ushort assetID,
      ushort listStartIndex,
      byte listItemCount,
      ushort originalIndex)
    {
      this.SetBaseIndexValues(assetID, listStartIndex, listItemCount, originalIndex);
    }

    public LinkIndexEntry(LinkIndexEntry oldLinkIndexEntry)
    {
      foreach (KeyValuePair<uint, BaseEntry> usageChild in oldLinkIndexEntry.UsageChildren)
        this.UsageChildren.Add(usageChild.Key, new BaseEntry(usageChild.Value));
      foreach (KeyValuePair<uint, LinkIndexEntry> linkedChild in oldLinkIndexEntry.LinkedChildren)
        this.LinkedChildren.Add(linkedChild.Key, new LinkIndexEntry(linkedChild.Value));
      this.SetBaseIndexValues((BaseIndexEntry) oldLinkIndexEntry);
    }
  }
}
