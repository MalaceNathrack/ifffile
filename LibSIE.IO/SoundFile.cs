// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.SoundFile
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class SoundFile : IIffSerialisable
  {
    public const int SD2D = 1144144979;
    public const int SD3D = 1144210515;
    public bool is3D;
    public List<string> audioFilenames = new List<string>();

    public float startDelayMin { get; set; }

    public float startDelayMax { get; set; }

    public float fadeInMin { get; set; }

    public float fadeInMax { get; set; }

    public int playCountMin { get; set; }

    public int playCountMax { get; set; }

    public float loopDelayMin { get; set; }

    public float loopDelayMax { get; set; }

    public float fadeOutMin { get; set; }

    public float fadeOutMax { get; set; }

    public int soundType { get; set; }

    public int playOrder { get; set; }

    public int playCount { get; set; }

    public int loopDelay { get; set; }

    public int fadeIn { get; set; }

    public int fadeOut { get; set; }

    public int volSampleRateType { get; set; }

    public float volSampleRate { get; set; }

    public float volMin { get; set; }

    public float volMax { get; set; }

    public float volInterpolRate { get; set; }

    public int pitchSampleRateType { get; set; }

    public float pitchSampleRate { get; set; }

    public float pitchMin { get; set; }

    public float pitchMax { get; set; }

    public float pitchInterpolRate { get; set; }

    public int priority { get; set; }

    public float soundstageDistanceMax { get; set; }

    public SoundFile(IffStream iffStream) => this.ReadObject(iffStream);

    public SoundFile()
    {
    }

    public void ReadObject(IffStream iffStream)
    {
      switch (iffStream.RootType())
      {
        case 1144144979:
          this.is3D = false;
          iffStream.OpenForm(1144144979U);
          this.ReadSound(iffStream);
          iffStream.CloseForm(1144144979U);
          break;
        case 1144210515:
          this.is3D = true;
          iffStream.OpenForm(1144210515U);
          iffStream.OpenForm(1144144979U);
          this.ReadSound(iffStream);
          iffStream.CloseForm(1144144979U);
          iffStream.OpenChunk(825241648U);
          iffStream.CloseChunk(825241648U);
          iffStream.CloseForm(1144210515U);
          break;
      }
    }

    public void WriteObject(IffWriter iffWriter)
    {
      if (this.is3D)
      {
        iffWriter.OpenForm(1144210515U);
        iffWriter.OpenForm(1144144979U);
        this.WriteSound(iffWriter);
        iffWriter.CloseForm(1144144979U);
        iffWriter.OpenChunk(825241648U);
        iffWriter.CloseChunk(825241648U);
        iffWriter.CloseForm(1144210515U);
      }
      else
      {
        if (this.is3D)
          return;
        iffWriter.OpenForm(1144144979U);
        this.WriteSound(iffWriter);
        iffWriter.CloseForm(1144144979U);
      }
    }

    private void ReadSound(IffStream iffStream)
    {
      this.audioFilenames.Clear();
      iffStream.OpenChunk(858796080U);
      uint uint32 = iffStream.GetUInt32();
      for (uint index = 0; index < uint32; ++index)
        this.audioFilenames.Add(iffStream.GetString());
      this.startDelayMin = iffStream.GetFloat();
      this.startDelayMax = iffStream.GetFloat();
      this.fadeInMin = iffStream.GetFloat();
      this.fadeInMax = iffStream.GetFloat();
      this.playCountMin = iffStream.GetInt32();
      this.playCountMax = iffStream.GetInt32();
      this.loopDelayMin = iffStream.GetFloat();
      this.loopDelayMax = iffStream.GetFloat();
      this.fadeOutMin = iffStream.GetFloat();
      this.fadeOutMax = iffStream.GetFloat();
      this.soundType = iffStream.GetInt32();
      this.playOrder = iffStream.GetInt32();
      this.playCount = iffStream.GetInt32();
      this.loopDelay = iffStream.GetInt32();
      this.fadeIn = iffStream.GetInt32();
      this.fadeOut = iffStream.GetInt32();
      this.volSampleRateType = iffStream.GetInt32();
      this.volSampleRate = iffStream.GetFloat();
      this.volMin = iffStream.GetFloat();
      this.volMax = iffStream.GetFloat();
      this.volInterpolRate = iffStream.GetFloat();
      this.pitchSampleRateType = iffStream.GetInt32();
      this.pitchSampleRate = iffStream.GetFloat();
      this.pitchMin = iffStream.GetFloat();
      this.pitchMax = iffStream.GetFloat();
      this.pitchInterpolRate = iffStream.GetFloat();
      this.priority = iffStream.GetInt32();
      this.soundstageDistanceMax = iffStream.GetFloat();
      iffStream.CloseChunk(858796080U);
    }

    private void WriteSound(IffWriter iffWriter)
    {
      iffWriter.OpenChunk(858796080U);
      iffWriter.Write(this.audioFilenames.Count);
      foreach (string audioFilename in this.audioFilenames)
        iffWriter.Write(audioFilename);
      iffWriter.Write(this.startDelayMin);
      iffWriter.Write(this.startDelayMax);
      iffWriter.Write(this.fadeInMin);
      iffWriter.Write(this.fadeInMax);
      iffWriter.Write(this.playCountMin);
      iffWriter.Write(this.playCountMax);
      iffWriter.Write(this.loopDelayMin);
      iffWriter.Write(this.loopDelayMax);
      iffWriter.Write(this.fadeOutMin);
      iffWriter.Write(this.fadeOutMax);
      iffWriter.WriteEnum32<int>(this.soundType);
      iffWriter.WriteEnum32<int>(this.playOrder);
      iffWriter.WriteEnum32<int>(this.playCount);
      iffWriter.WriteEnum32<int>(this.loopDelay);
      iffWriter.WriteEnum32<int>(this.fadeIn);
      iffWriter.WriteEnum32<int>(this.fadeOut);
      iffWriter.WriteEnum32<int>(this.volSampleRateType);
      iffWriter.Write(this.volSampleRate);
      iffWriter.Write(this.volMin);
      iffWriter.Write(this.volMax);
      iffWriter.Write(this.volInterpolRate);
      iffWriter.WriteEnum32<int>(this.pitchSampleRateType);
      iffWriter.Write(this.pitchSampleRate);
      iffWriter.Write(this.pitchMin);
      iffWriter.Write(this.pitchMax);
      iffWriter.Write(this.pitchInterpolRate);
      iffWriter.WriteEnum32<int>(this.priority);
      iffWriter.Write(this.soundstageDistanceMax);
      iffWriter.CloseChunk(858796080U);
    }

    public enum SoundType
    {
      Ambience,
      Explosions,
      Item,
      Movement,
      UserInterface,
      Vehicle,
      Vocalisation,
      Weapon,
      BackgroundMusic,
      PlayerMusic,
      Machine,
      Installation,
      CombatMusic,
      Voiceover,
    }

    public enum VolumeType
    {
      FullVolume,
      Once,
      Everytime,
      Seconds,
    }

    public enum PitchType
    {
      BasePitch,
      Once,
      Everytime,
      Seconds,
    }

    public enum PlayOrder
    {
      Random,
      InOrder,
      RandomNoRepeats,
    }

    public enum PlayCount
    {
      OneAtATime,
      AllAtOnce,
    }

    public enum WhenTo
    {
      Never,
      Initial,
      Everytime,
    }

    public enum Priority
    {
      OneHighest,
      Two,
      Three,
      Four,
      Five,
      Six,
      Seven,
      Eight,
      Nine,
      TenLowest,
    }
  }
}
