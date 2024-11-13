// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.CustomizationDataEntry
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class CustomizationDataEntry
  {
    public CustomizationDataEntryRaw UCMPData;
    public ACMValue<string> VariableName = new ACMValue<string>("");
    public ACMValue<int> DefaultValue = new ACMValue<int>(0);
    public ACMValue<IntegerRange> IntRange = new ACMValue<IntegerRange>(new IntegerRange());
    public bool IsPalette;
    public ACMValue<string> PaletteFileName = new ACMValue<string>("");

    public CustomizationDataEntry()
    {
    }

    public CustomizationDataEntry(AssetCustomizationManagerBase acm)
    {
      this.UCMPData = new CustomizationDataEntryRaw(acm);
    }

    public CustomizationDataEntry(
      CustomizationDataEntryRaw customizationDataEntryRaw)
    {
      this.SetValues(customizationDataEntryRaw);
    }

    public CustomizationDataEntry(CustomizationDataEntry customizationDataEntry)
    {
      this.SetValues(customizationDataEntry);
    }

    public void SetValues(CustomizationDataEntry customizationDataEntry)
    {
      this.UCMPData = new CustomizationDataEntryRaw(customizationDataEntry.UCMPData);
      this.VariableName = new ACMValue<string>(customizationDataEntry.VariableName);
      this.DefaultValue = new ACMValue<int>(customizationDataEntry.DefaultValue);
      this.IntRange = new ACMValue<IntegerRange>(customizationDataEntry.IntRange);
      this.IsPalette = customizationDataEntry.IsPalette;
      this.PaletteFileName = customizationDataEntry.PaletteFileName;
    }

    public void SetValues(
      CustomizationDataEntryRaw customizationDataEntryRaw)
    {
      this.VariableName = new ACMValue<string>(customizationDataEntryRaw.acm.VariableNames[(ushort) ((uint) customizationDataEntryRaw.VariableNameIndex - 1U)].Value, (ushort) ((uint) customizationDataEntryRaw.VariableNameIndex - 1U));
      this.DefaultValue = new ACMValue<int>(customizationDataEntryRaw.acm.DefaultValues[(ushort) customizationDataEntryRaw.DefaultValueIndex].Value, (ushort) customizationDataEntryRaw.DefaultValueIndex);
      RangeType rangeType = customizationDataEntryRaw.acm.RangeTypeTable[(ushort) customizationDataEntryRaw.RangeTypeIndex].Value;
      this.IsPalette = rangeType.IsPalette;
      if (this.IsPalette)
        this.PaletteFileName = new ACMValue<string>(customizationDataEntryRaw.acm.PaletteNames[(ushort) (rangeType.RealID - 1)].Value, (ushort) (rangeType.RealID - 1));
      else
        this.IntRange = customizationDataEntryRaw.acm.IntegerRangeTable[(ushort) rangeType.RealID];
      this.UCMPData = new CustomizationDataEntryRaw(customizationDataEntryRaw);
    }

    public string GetValues()
    {
      string values;
      if (this.IsPalette)
        values = "Palette: " + this.PaletteFileName.Value + " / Default Value: " + (object) this.DefaultValue.Value;
      else
        values = "Integer Range: " + this.IntRange.Value.GetValuesAsStringFull() + " / Default Value: " + (object) this.DefaultValue.Value;
      return values;
    }
  }
}
