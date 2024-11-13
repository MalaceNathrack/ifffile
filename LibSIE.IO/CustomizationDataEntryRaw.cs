// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.CustomizationDataEntryRaw
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System;

#nullable disable
namespace LibSIE.IO
{
  public class CustomizationDataEntryRaw : BaseACMValue
  {
    public AssetCustomizationManagerBase acm;
    public byte DefaultValueIndex;
    public byte VariableNameIndex;
    public byte RangeTypeIndex;
    public bool IsPalette;

    public CustomizationDataEntryRaw(AssetCustomizationManagerBase acmFile)
    {
      this.acm = acmFile;
      this.OriginalIndex = this.GetHighestID();
    }

    public CustomizationDataEntryRaw(
      AssetCustomizationManagerBase acmFile,
      byte variableNameIndex,
      byte rangeTypeIndex,
      byte defaultValueIndex)
    {
      this.acm = acmFile;
      this.SetValues(variableNameIndex, rangeTypeIndex, defaultValueIndex);
    }

    public CustomizationDataEntryRaw(
      AssetCustomizationManagerBase acmFile,
      byte variableNameIndex,
      byte rangeTypeIndex,
      byte defaultValueIndex,
      ushort originalIndex)
    {
      this.acm = acmFile;
      this.SetValues(variableNameIndex, rangeTypeIndex, defaultValueIndex, originalIndex);
    }

    public CustomizationDataEntryRaw(CustomizationDataEntryRaw oldEntryRaw)
    {
      this.acm = oldEntryRaw.acm;
      this.SetValues(oldEntryRaw);
    }

    public void SetValues(byte variableNameIndex, byte rangeTypeIndex, byte defaultValueIndex)
    {
      this.VariableNameIndex = variableNameIndex;
      this.RangeTypeIndex = rangeTypeIndex;
      this.DefaultValueIndex = defaultValueIndex;
    }

    public void SetValues(
      byte variableNameIndex,
      byte rangeTypeIndex,
      byte defaultValueIndex,
      ushort originalIndex)
    {
      this.SetValues(variableNameIndex, rangeTypeIndex, defaultValueIndex);
      this.OriginalIndex = originalIndex;
    }

    public void SetValues(CustomizationDataEntryRaw oldEntryRaw)
    {
      this.SetValues(oldEntryRaw.VariableNameIndex, oldEntryRaw.RangeTypeIndex, oldEntryRaw.DefaultValueIndex);
      this.SetBaseACMValues((BaseACMValue) oldEntryRaw);
    }

    public CustomizationDataEntry GetData()
    {
      return this.GetData((ushort) this.VariableNameIndex, (ushort) this.RangeTypeIndex, (ushort) this.DefaultValueIndex);
    }

    public CustomizationDataEntry GetData(
      ushort variableIndex,
      ushort rangeTypeIndex,
      ushort defaultIndex)
    {
      return new CustomizationDataEntry(this);
    }

    public ushort GetHighestID()
    {
      ushort val1 = 0;
      foreach (CustomizationDataEntryRaw customizationDataEntryRaw in this.acm.CustomizationDataRaw)
        val1 = (ushort) ((uint) Math.Max(val1, customizationDataEntryRaw.OriginalIndex) + 1U);
      return val1;
    }

    public string GetVariableName()
    {
      return new ACMValue<string>(this.acm.VariableNames[(ushort) ((uint) this.VariableNameIndex - 1U)].Value, (ushort) ((uint) this.VariableNameIndex - 1U)).Value;
    }

    public string GetDefaultValue()
    {
      return new ACMValue<int>(this.acm.DefaultValues[(ushort) this.DefaultValueIndex].Value, (ushort) this.DefaultValueIndex).Value.ToString();
    }

    public string GetValuesAsStringFull()
    {
      return this.acm.RangeTypeTable[(ushort) this.RangeTypeIndex].Value.GetValuesAsStringFull();
    }
  }
}
