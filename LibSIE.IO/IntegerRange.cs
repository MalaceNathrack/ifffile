// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.IntegerRange
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class IntegerRange
  {
    public int MinRangeInclusive;
    public int MaxRangeExclusive;

    public IntegerRange()
    {
    }

    public IntegerRange(int minRange, int maxRange)
    {
      this.MinRangeInclusive = minRange;
      this.MaxRangeExclusive = maxRange;
    }

    public IntegerRange(IntegerRange oldIntegerRange)
    {
      this.MinRangeInclusive = oldIntegerRange.MinRangeInclusive;
      this.MaxRangeExclusive = oldIntegerRange.MaxRangeExclusive;
    }

    public string GetValuesAsString()
    {
      return "Min: " + (object) this.MinRangeInclusive + " / Max: " + (object) this.MaxRangeExclusive;
    }

    public string GetValuesAsStringFull()
    {
      return "Range Min: " + (object) this.MinRangeInclusive + " / Range Max: " + (object) this.MaxRangeExclusive;
    }
  }
}
