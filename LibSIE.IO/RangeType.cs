// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.RangeType
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class RangeType
  {
    private AssetCustomizationManagerBase acm;
    public bool IsPalette;
    public int RealID;

    public RangeType(AssetCustomizationManagerBase acmFile, ushort rangeType)
    {
      this.acm = acmFile;
      this.IsPalette = ((uint) rangeType & 32768U) > 0U;
      this.RealID = (int) rangeType & (int) short.MaxValue;
    }

    public RangeType(AssetCustomizationManagerBase acmFile, bool isPalette, int realID)
    {
      this.acm = acmFile;
      this.IsPalette = isPalette;
      this.RealID = realID;
    }

    public RangeType(RangeType oldRangeType)
    {
      this.IsPalette = oldRangeType.IsPalette;
      this.RealID = oldRangeType.RealID;
      this.acm = oldRangeType.acm;
    }

    public string GetValuesAsStringFull()
    {
      return !this.IsPalette ? "Integer Range: " + this.acm.IntegerRangeTable[(ushort) this.RealID].Value.GetValuesAsString() : "Palette: " + this.acm.PaletteNames[(ushort) (this.RealID - 1)].Value;
    }
  }
}
