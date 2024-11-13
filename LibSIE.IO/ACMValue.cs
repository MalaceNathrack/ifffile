// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.ACMValue`1
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class ACMValue<T> : BaseACMValue
  {
    public T Value;

    public ACMValue(T value) => this.Value = value;

    public ACMValue(T value, List<ACMValue<T>> list)
    {
      this.Value = value;
      this.OriginalIndex = this.GetHighestID(list);
    }

    public ACMValue(T value, ushort originalIndex)
    {
      this.Value = value;
      this.OriginalIndex = originalIndex;
    }

    public ACMValue(ACMValue<T> oldACMValue)
    {
      this.Value = oldACMValue.Value;
      this.SetBaseACMValues((BaseACMValue) oldACMValue);
    }

    public ACMValue(ACMValue<T> oldACMValue, ushort originalIndex)
    {
      this.Value = oldACMValue.Value;
      this.SetBaseACMValues((BaseACMValue) oldACMValue, originalIndex);
    }

    public ushort GetHighestID(List<ACMValue<T>> list)
    {
      ushort val1 = 0;
      foreach (ACMValue<T> acmValue in list)
        val1 = (ushort) ((uint) Math.Max(val1, acmValue.OriginalIndex) + 1U);
      return val1;
    }
  }
}
