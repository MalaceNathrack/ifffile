// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.ClientEffectFile
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using LibSIE.IO.Iff;
using System.Collections.Generic;

#nullable disable
namespace LibSIE.IO
{
  public class ClientEffectFile : IIffSerialisable
  {
    public const int CLEF = 1178946627;
    private const int CPAP = 1346457667;
    private const int PSND = 1145983824;
    private const int CLGT = 1413958723;
    private const int CAMS = 1397571907;
    private const int FFBK = 1262634566;
    public List<string> clientSoundFilenames = new List<string>();
    public List<ClientParticle> clientParticles = new List<ClientParticle>();
    public ClientLight clientLight = new ClientLight();
    public CameraShake cameraShake = new CameraShake();
    public ForceFeedback forceFeedback = new ForceFeedback();

    public bool hasCPAP { get; set; }

    public bool hasPSND { get; set; }

    public bool hasCLGT { get; set; }

    public bool hasCAMS { get; set; }

    public bool hasFFBK { get; set; }

    public ClientEffectFile(IffStream iffStream) => this.ReadObject(iffStream);

    public ClientEffectFile()
    {
    }

    public void ReadObject(IffStream iffStream)
    {
      iffStream.OpenForm(1178946627U);
      uint num1 = iffStream.NextType();
      iffStream.OpenForm(num1);
      uint num2 = iffStream.RemainingSubChunks();
      for (uint index = 0; index < num2; ++index)
      {
        switch (iffStream.NextType())
        {
          case 1145983824:
            this.hasPSND = true;
            iffStream.OpenChunk(1145983824U);
            this.clientSoundFilenames.Add(iffStream.GetString());
            iffStream.CloseChunk(1145983824U);
            break;
          case 1262634566:
            this.hasFFBK = true;
            iffStream.OpenChunk(1262634566U);
            this.forceFeedback = new ForceFeedback()
            {
              forceFeedbackFilename = iffStream.GetString(),
              iterations = iffStream.GetInt32(),
              range = iffStream.GetFloat()
            };
            iffStream.CloseChunk(1262634566U);
            break;
          case 1346457667:
            this.hasCPAP = true;
            iffStream.OpenChunk(1346457667U);
            ClientParticle clientParticle = new ClientParticle();
            switch (num1)
            {
              case 825241648:
                clientParticle.particleFilename = iffStream.GetString();
                clientParticle.time = iffStream.GetFloat();
                break;
              case 842018864:
                clientParticle.particleFilename = iffStream.GetString();
                clientParticle.time = iffStream.GetFloat();
                clientParticle.softFade = iffStream.GetBoolean();
                break;
              case 858796080:
                clientParticle.particleFilename = iffStream.GetString();
                clientParticle.time = iffStream.GetFloat();
                clientParticle.softFade = iffStream.GetBoolean();
                clientParticle.scaleMin = iffStream.GetFloat();
                clientParticle.scaleMax = iffStream.GetFloat();
                clientParticle.playRateMin = iffStream.GetFloat();
                clientParticle.playRateMax = iffStream.GetFloat();
                break;
            }
            iffStream.CloseChunk(1346457667U);
            this.clientParticles.Add(clientParticle);
            break;
          case 1397571907:
            this.hasCAMS = true;
            iffStream.OpenChunk(1397571907U);
            this.cameraShake = new CameraShake()
            {
              magnitude = iffStream.GetFloat(),
              frequency = iffStream.GetFloat(),
              time = iffStream.GetFloat(),
              falloffRadius = iffStream.GetFloat()
            };
            iffStream.CloseChunk(1397571907U);
            break;
          case 1413958723:
            this.hasCLGT = true;
            iffStream.OpenChunk(1413958723U);
            this.clientLight = new ClientLight()
            {
              lightColor = iffStream.GetRGB8Int(),
              time = iffStream.GetFloat(),
              range = iffStream.GetFloat(),
              constantAttenuation = iffStream.GetFloat(),
              linearAttenuation = iffStream.GetFloat(),
              quadricAttenuation = iffStream.GetFloat()
            };
            iffStream.CloseChunk(1413958723U);
            break;
        }
      }
      iffStream.CloseForm(num1);
      iffStream.CloseForm(1178946627U);
    }

    public void WriteObject(IffWriter iffWriter)
    {
      iffWriter.OpenForm(1178946627U);
      iffWriter.OpenForm(858796080U);
      if (this.hasCPAP)
      {
        foreach (ClientParticle clientParticle in this.clientParticles)
        {
          iffWriter.OpenChunk(1346457667U);
          iffWriter.Write(clientParticle.particleFilename);
          iffWriter.Write(clientParticle.time);
          iffWriter.Write(clientParticle.softFade);
          iffWriter.Write(clientParticle.scaleMin);
          iffWriter.Write(clientParticle.scaleMax);
          iffWriter.Write(clientParticle.playRateMin);
          iffWriter.Write(clientParticle.playRateMax);
          iffWriter.CloseChunk(1346457667U);
        }
      }
      if (this.hasPSND)
      {
        foreach (string clientSoundFilename in this.clientSoundFilenames)
        {
          iffWriter.OpenChunk(1145983824U);
          iffWriter.Write(clientSoundFilename);
          iffWriter.CloseChunk(1145983824U);
        }
      }
      if (this.hasCLGT)
      {
        iffWriter.OpenChunk(1413958723U);
        iffWriter.WriteRGB8Int(this.clientLight.lightColor);
        iffWriter.Write(this.clientLight.time);
        iffWriter.Write(this.clientLight.range);
        iffWriter.Write(this.clientLight.constantAttenuation);
        iffWriter.Write(this.clientLight.linearAttenuation);
        iffWriter.Write(this.clientLight.quadricAttenuation);
        iffWriter.CloseChunk(1413958723U);
      }
      if (this.hasCAMS)
      {
        iffWriter.OpenChunk(1397571907U);
        iffWriter.Write(this.cameraShake.magnitude);
        iffWriter.Write(this.cameraShake.frequency);
        iffWriter.Write(this.cameraShake.time);
        iffWriter.Write(this.cameraShake.falloffRadius);
        iffWriter.CloseChunk(1397571907U);
      }
      if (this.hasFFBK)
      {
        iffWriter.OpenChunk(1262634566U);
        iffWriter.Write(this.forceFeedback.forceFeedbackFilename);
        iffWriter.Write(this.forceFeedback.iterations);
        iffWriter.Write(this.forceFeedback.range);
        iffWriter.CloseChunk(1262634566U);
      }
      iffWriter.CloseForm(858796080U);
      iffWriter.CloseForm(1178946627U);
    }
  }
}
