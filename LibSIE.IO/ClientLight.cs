// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.ClientLight
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using System.Drawing;

#nullable disable
namespace LibSIE.IO
{
  public class ClientLight
  {
    public Color lightColor { get; set; }

    public float time { get; set; }

    public float range { get; set; }

    public float constantAttenuation { get; set; }

    public float linearAttenuation { get; set; }

    public float quadricAttenuation { get; set; }
  }
}
