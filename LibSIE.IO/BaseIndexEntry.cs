// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.BaseIndexEntry
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class BaseIndexEntry : BaseEntry
  {
    public bool IsUsed;
    public ushort ListStartIndex;
    public byte ListItemCount;

    public void SetBaseIndexValues(ushort assetID, ushort listStartIndex, byte listItemCount)
    {
      this.AssetID = assetID;
      this.ListStartIndex = listStartIndex;
      this.ListItemCount = listItemCount;
    }

    public void SetBaseIndexValues(
      ushort assetID,
      ushort listStartIndex,
      byte listItemCount,
      ushort originalIndex)
    {
      this.SetBaseIndexValues(assetID, listStartIndex, listItemCount);
      this.OriginalIndex = originalIndex;
    }

    public void SetBaseIndexValues(
      ushort assetID,
      string filename,
      uint filenameCRC,
      ushort listStartIndex,
      byte listItemCount)
    {
      this.SetBaseEntryValues(assetID, filename, filenameCRC);
      this.ListStartIndex = listStartIndex;
      this.ListItemCount = listItemCount;
    }

    public void SetBaseIndexValues(BaseIndexEntry oldBaseIndexEntry)
    {
      this.SetBaseIndexValues(oldBaseIndexEntry.AssetID, oldBaseIndexEntry.Filename, oldBaseIndexEntry.FilenameCRC, oldBaseIndexEntry.ListStartIndex, oldBaseIndexEntry.ListItemCount);
    }
  }
}
