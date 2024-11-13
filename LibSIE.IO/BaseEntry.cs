// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.BaseEntry
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class BaseEntry : BaseACMValue
  {
    public ushort AssetID;
    public string Filename = "";
    public uint FilenameCRC;

    public BaseEntry()
    {
    }

    public BaseEntry(BaseEntry oldBaseEntry) => this.SetBaseEntryValues(oldBaseEntry);

    public void SetBaseEntryValues(ushort assetID, string filename, uint filenameCRC)
    {
      this.AssetID = assetID;
      this.Filename = filename;
      this.FilenameCRC = filenameCRC;
    }

    public void SetBaseEntryValues(BaseEntry oldBaseEntry)
    {
      this.SetBaseACMValues((BaseACMValue) oldBaseEntry);
      this.SetBaseEntryValues(oldBaseEntry.AssetID, oldBaseEntry.Filename, oldBaseEntry.FilenameCRC);
    }
  }
}
