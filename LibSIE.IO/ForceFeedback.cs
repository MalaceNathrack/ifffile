// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.ForceFeedback
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO
{
  public class ForceFeedback
  {
    private string mForceFeedbackFilename = "";
    private int mIterations = 1;

    public string forceFeedbackFilename
    {
      get => this.mForceFeedbackFilename;
      set => this.mForceFeedbackFilename = value;
    }

    public int iterations
    {
      get => this.mIterations;
      set => this.mIterations = value;
    }

    public float range { get; set; }
  }
}
