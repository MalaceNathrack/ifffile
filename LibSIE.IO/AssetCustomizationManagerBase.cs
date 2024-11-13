// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.AssetCustomizationManagerBase
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class AssetCustomizationManagerBase : IIffSerialisable
  {
    public List<AssetEntry> AssetEntries = new List<AssetEntry>();
    public Dictionary<ushort, LinkIndexEntry> AssetLinkIndex = new Dictionary<ushort, LinkIndexEntry>();
    public Dictionary<ushort, UsageIndexEntry> VariableUsageIndex = new Dictionary<ushort, UsageIndexEntry>();
    public Dictionary<ushort, ACMValue<int>> DefaultValues = new Dictionary<ushort, ACMValue<int>>();
    public Dictionary<ushort, ACMValue<IntegerRange>> IntegerRangeTable = new Dictionary<ushort, ACMValue<IntegerRange>>();
    public Dictionary<ushort, ACMValue<RangeType>> RangeTypeTable = new Dictionary<ushort, ACMValue<RangeType>>();
    public Dictionary<ushort, ACMValue<string>> PaletteNames = new Dictionary<ushort, ACMValue<string>>();
    public Dictionary<ushort, ACMValue<string>> VariableNames = new Dictionary<ushort, ACMValue<string>>();
    public List<CustomizationDataEntryRaw> CustomizationDataRaw = new List<CustomizationDataEntryRaw>();

    public virtual void ReadObject(IffStream iffStream)
    {
    }

    public virtual void WriteObject(IffWriter iffWriter)
    {
    }

    public enum ValueTypes
    {
      DefaultValue,
      IntegerRange,
      PalettePath,
      RangeType,
      VariablePath,
    }
  }
}
