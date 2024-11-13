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
