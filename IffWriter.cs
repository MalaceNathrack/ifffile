// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.Iff.IffWriter
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using SlimDX;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

#nullable disable
namespace LibSIE.IO.Iff
{
  public class IffWriter
  {
    private readonly List<byte> data;
    private IffWriter.Chunk currentChunk;

    public void OpenData() => this.OpenChunk(1096040772U);

    public void CloseData() => this.CloseChunk(1096040772U);

    public void OpenInfo() => this.OpenChunk(1096040772U);

    public void CloseInfo() => this.CloseChunk(1096040772U);

    public void OpenChunk(uint tag)
    {
      IffWriter.Chunk chunk = new IffWriter.Chunk(tag, this.data.Count + 4);
      if (this.currentChunk != null)
        chunk.Parent = this.currentChunk;
      this.currentChunk = chunk;
      this.Write(tag);
      this.Write(0U);
    }

    public void OpenForm(uint tag)
    {
      IffWriter.Chunk chunk = new IffWriter.Chunk(tag, this.data.Count + 4);
      if (this.currentChunk != null)
        chunk.Parent = this.currentChunk;
      this.currentChunk = chunk;
      this.Write(1297239878U);
      this.Write(0U);
      this.Write(tag);
    }

    public void CloseChunk(uint tag)
    {
      int tag1 = (int) this.currentChunk.Tag;
      byte[] bytes = BitConverter.GetBytes(this.currentChunk.Length - 8);
      this.data[this.currentChunk.LengthOffset] = bytes[3];
      this.data[this.currentChunk.LengthOffset + 1] = bytes[2];
      this.data[this.currentChunk.LengthOffset + 2] = bytes[1];
      this.data[this.currentChunk.LengthOffset + 3] = bytes[0];
      if (this.currentChunk.Parent != null)
      {
        this.currentChunk.Parent.Length += this.currentChunk.Length;
        this.currentChunk = this.currentChunk.Parent;
      }
      else
        this.currentChunk = (IffWriter.Chunk) null;
    }

    public void CloseForm(uint tag) => this.CloseChunk(tag);

    public IffWriter() => this.data = new List<byte>();

    public byte[] Data() => this.data.ToArray();

    public void Write(byte inval)
    {
      this.data.Add(inval);
      if (this.currentChunk == null)
        return;
      ++this.currentChunk.Length;
    }

    public void Write(byte[] inval)
    {
      this.data.AddRange((IEnumerable<byte>) inval);
      if (this.currentChunk == null)
        return;
      this.currentChunk.Length += inval.Length;
    }

    public void Write(float inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      this.currentChunk.Length += 4;
    }

    public void Write(double inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      this.currentChunk.Length += 8;
    }

    public void Write(Vector2 inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.X));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Y));
      this.currentChunk.Length += 8;
    }

    public void Write(Vector3 inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.X));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Y));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Z));
      this.currentChunk.Length += 12;
    }

    public void Write(Vector4 inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.X));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Y));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Z));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.W));
      this.currentChunk.Length += 16;
    }

    public void Write(Quaternion inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.W));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.X));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Y));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Z));
      this.currentChunk.Length += 16;
    }

    public void Write(Matrix inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M11));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M12));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M13));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M41));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M21));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M22));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M23));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M42));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M31));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M32));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M33));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.M43));
      this.currentChunk.Length += 48;
    }

    public void WriteEnum8<T>(T value) => this.Write((byte) Convert.ToInt32((object) value));

    public void WriteEnum32<T>(T value) => this.Write(Convert.ToInt32((object) value));

    public void WriteRGB8Int(Color inval)
    {
      this.data.Add(inval.R);
      this.data.Add(inval.G);
      this.data.Add(inval.B);
      this.currentChunk.Length += 3;
    }

    public void WriteARGB8Int(Color inval)
    {
      this.data.Add(inval.A);
      this.data.Add(inval.R);
      this.data.Add(inval.G);
      this.data.Add(inval.B);
      this.currentChunk.Length += 4;
    }

    public void WriteRGBA8Int(Color inval)
    {
      this.data.Add(inval.R);
      this.data.Add(inval.G);
      this.data.Add(inval.B);
      this.data.Add(inval.A);
      this.currentChunk.Length += 4;
    }

    public void WriteRGB32Float(Color3 inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Red));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Green));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Blue));
      this.currentChunk.Length += 12;
    }

    public void WriteRGBA32Float(Color4 inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Red));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Green));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Blue));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Alpha));
      this.currentChunk.Length += 16;
    }

    public void WriteARGB32Float(Color4 inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Alpha));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Red));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Green));
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval.Blue));
      this.currentChunk.Length += 16;
    }

    public void Write(int inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      if (this.currentChunk == null)
        return;
      this.currentChunk.Length += 4;
    }

    public void Write(uint inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      if (this.currentChunk == null)
        return;
      this.currentChunk.Length += 4;
    }

    public void Write(long inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      this.currentChunk.Length += 8;
    }

    public void Write(ulong inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      this.currentChunk.Length += 8;
    }

    public void WriteBigEndian(int inval)
    {
      byte[] bytes = BitConverter.GetBytes(inval);
      Array.Reverse((Array) bytes);
      this.data.AddRange((IEnumerable<byte>) bytes);
      this.currentChunk.Length += 4;
    }

    public void WriteBigEndian(uint inval)
    {
      byte[] bytes = BitConverter.GetBytes(inval);
      Array.Reverse((Array) bytes);
      this.data.AddRange((IEnumerable<byte>) bytes);
      this.currentChunk.Length += 4;
    }

    public void Write(bool inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      ++this.currentChunk.Length;
    }

    public void Write(short inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      this.currentChunk.Length += 2;
    }

    public void Write(ushort inval)
    {
      this.data.AddRange((IEnumerable<byte>) BitConverter.GetBytes(inval));
      this.currentChunk.Length += 2;
    }

    public void Write(string inStr)
    {
      this.data.AddRange((IEnumerable<byte>) Encoding.ASCII.GetBytes(inStr));
      this.data.Add((byte) 0);
      this.currentChunk.Length += inStr.Length + 1;
    }

    public void WriteColor(Color inCol)
    {
      this.data.AddRange((IEnumerable<byte>) new byte[3]
      {
        inCol.R,
        inCol.G,
        inCol.B
      });
      this.currentChunk.Length += 3;
    }

    public void WriteIntFromBool(bool value) => this.Write(value ? 1 : 0);

    public void WriteByteFromBool(bool value) => this.Write(value ? (byte) 1 : (byte) 0);

    protected class Chunk
    {
      public IffWriter.Chunk Parent;
      public int Length;
      public int LengthOffset;
      public uint Tag;

      public Chunk(uint tag, int lengthOffset)
      {
        this.Tag = tag;
        this.LengthOffset = lengthOffset;
      }
    }
  }
}
