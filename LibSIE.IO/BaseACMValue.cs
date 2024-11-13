// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.BaseACMValue
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace LibSIE.IO
{
  public class BaseACMValue
  {
    public ushort OriginalIndex;
    public ushort NewIndex;
    public List<ushort> UsedBy = new List<ushort>();
    public List<ushort> UsedByUCMP = new List<ushort>();
    public List<ushort> UsedByAssets = new List<ushort>();

    public List<string> GetUsingAssetsStringList(AssetCustomizationManagerBase acm)
    {
      if (this.UsedBy.Count > 0 && this.UsedByUCMP.Count == 0)
      {
        foreach (ushort num in this.UsedBy)
          this.UsedByUCMP.AddRange((IEnumerable<ushort>) acm.CustomizationDataRaw[(int) num - 1].UsedBy);
      }
      List<string> assetsStringList = new List<string>();
      foreach (ushort key in this.UsedByUCMP)
      {
        UsageIndexEntry usageIndexEntry = acm.VariableUsageIndex[key];
        string str = !(usageIndexEntry.Filename != "") ? "<FILENAME NOT FOUND IN REPO - ASSET ID: " + (object) usageIndexEntry.AssetID + ">" : usageIndexEntry.Filename;
        if (str != null && !assetsStringList.Contains(str))
        {
          assetsStringList.Add(str);
          if (!this.UsedByAssets.Contains(usageIndexEntry.AssetID))
            this.UsedByAssets.Add(usageIndexEntry.AssetID);
        }
      }
      return assetsStringList;
    }

    public string GetUsingAssetsString(AssetCustomizationManagerBase acm)
    {
      return string.Join(Environment.NewLine, (IEnumerable<string>) this.GetUsingAssetsStringList(acm));
    }

    public string GetUsingUsageAssetsString(AssetCustomizationManagerBase acm)
    {
      List<string> values = new List<string>();
      foreach (ushort key in this.UsedBy)
      {
        string filename = acm.VariableUsageIndex[key].Filename;
        if (filename != null && !values.Contains(filename))
          values.Add(filename);
      }
      return string.Join(Environment.NewLine, (IEnumerable<string>) values);
    }

    public void SetBaseACMValues(
      List<ushort> usedBy,
      List<ushort> usedByUCMP,
      List<ushort> usedByAssets)
    {
      this.UsedBy = new List<ushort>((IEnumerable<ushort>) usedBy);
      this.UsedByUCMP = new List<ushort>((IEnumerable<ushort>) usedByUCMP);
      this.UsedByAssets = new List<ushort>((IEnumerable<ushort>) usedByAssets);
    }

    public void SetBaseACMValues(
      List<ushort> usedBy,
      List<ushort> usedByUCMP,
      List<ushort> usedByAssets,
      ushort originalIndex,
      ushort newIndex = 0)
    {
      this.SetBaseACMValues(usedBy, usedByUCMP, usedByAssets);
      this.OriginalIndex = originalIndex;
      this.NewIndex = newIndex;
    }

    public void SetBaseACMValues(BaseACMValue oldBaseAcmValue)
    {
      this.SetBaseACMValues(oldBaseAcmValue.UsedBy.ToList<ushort>(), oldBaseAcmValue.UsedByUCMP.ToList<ushort>(), oldBaseAcmValue.UsedByAssets.ToList<ushort>(), oldBaseAcmValue.OriginalIndex, oldBaseAcmValue.NewIndex);
    }

    public void SetBaseACMValues(BaseACMValue oldBaseAcmValue, ushort index)
    {
      this.SetBaseACMValues(oldBaseAcmValue.UsedBy.ToList<ushort>(), oldBaseAcmValue.UsedByUCMP.ToList<ushort>(), oldBaseAcmValue.UsedByAssets.ToList<ushort>(), index, index);
    }
  }
}
