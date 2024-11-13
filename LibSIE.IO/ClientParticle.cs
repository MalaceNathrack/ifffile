// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.ClientParticle
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class ClientParticle
  {
    private float mScaleMin = 1f;
    private float mScaleMax = 1f;
    private float mPlayRateMin = 1f;
    private float mPlayRateMax = 1f;

    public string particleFilename { get; set; }

    public float time { get; set; }

    public bool softFade { get; set; }

    public float scaleMin
    {
      get => this.mScaleMin;
      set => this.mScaleMin = value;
    }

    public float scaleMax
    {
      get => this.mScaleMax;
      set => this.mScaleMax = value;
    }

    public float playRateMin
    {
      get => this.mPlayRateMin;
      set => this.mPlayRateMin = value;
    }

    public float playRateMax
    {
      get => this.mPlayRateMax;
      set => this.mPlayRateMax = value;
    }
  }
}
