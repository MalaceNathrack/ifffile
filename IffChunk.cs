// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.Iff.IffChunk
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

#nullable disable
namespace LibSIE.IO.Iff
{
  public class IffChunk
  {
    public const uint FORM = 1297239878;
    public const uint DATA = 1096040772;

    public IffChunk ParentChunk { get; private set; }

    public uint Tag { get; private set; }

    public uint Size { get; private set; }

    public uint End { get; private set; }

    public bool IsForm { get; private set; }

    public uint BytesRead { get; private set; }

    public IffChunk(uint id, uint size, uint startOffset, bool isForm, IffChunk parentChunk = null)
    {
      this.Tag = id;
      this.Size = size;
      this.End = startOffset + size;
      this.IsForm = isForm;
      this.BytesRead = 0U;
      this.ParentChunk = parentChunk;
    }

    public string TagString() => IffStream.TagString(this.Tag);

    public bool IsFullyRead() => (int) this.BytesRead == (int) this.Size;

    public bool CanRead(uint numBytes) => this.BytesRead + numBytes <= this.Size;

    public void Read(uint numBytes) => this.BytesRead += numBytes;
  }
}
