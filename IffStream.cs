// Decompiled with JetBrains decompiler
// Type: LibSIE.IO.Iff.IffStream
// Assembly: LibSIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 429DF372-72BB-4285-8071-DD1B7AC4D1C8
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSIE.dll

using SlimDX;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace LibSIE.IO.Iff
{
  public sealed class IffStream
  {
    public static bool Verbose;
    public const uint FORM = 1297239878;
    public const uint DATA = 1096040772;
    public const uint INFO = 1330007625;
    public const int NULL = 1280070990;
    private readonly byte[] buffer;
    private readonly uint fileLength;
    private uint fileOffset;
    private readonly StringBuilder mStringBuilder = new StringBuilder();

    [DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr MemCopy(IntPtr dest, IntPtr src, UIntPtr count);

    public IffChunk CurrentChunk { get; private set; }

    public string Filename { get; private set; }

    public IffStream(byte[] input)
    {
      this.buffer = input;
      this.fileLength = (uint) input.Length;
      this.fileOffset = 0U;
      this.CurrentChunk = new IffChunk(1280070990U, this.fileLength, 0U, false);
    }

    public IffStream(string filename)
    {
      FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
      this.buffer = new byte[fileStream.Length];
      fileStream.Read(this.buffer, 0, (int) fileStream.Length);
      fileStream.Close();
      this.fileLength = (uint) this.buffer.Length;
      this.fileOffset = 0U;
      this.Filename = filename;
      this.CurrentChunk = new IffChunk(1280070990U, this.fileLength, 0U, false);
    }

    public uint Length => this.fileLength;

    public unsafe bool PeekAndReadIfNull(uint formtype)
    {
      if (this.fileOffset + 12U > this.fileLength)
        return false;
      fixed (byte* numPtr = this.buffer)
      {
        uint num = *(uint*) (numPtr + this.fileOffset + 8);
        if ((int) num == (int) formtype)
          return true;
        if (num != 1280070990U)
          return false;
        this.OpenForm(1280070990U);
        this.CloseForm(1280070990U);
        return false;
      }
    }

    public unsafe IffChunk PeekForm(uint formtype)
    {
      IffChunk iffChunk = (IffChunk) null;
      if (this.fileOffset + 12U <= this.fileLength)
      {
        fixed (byte* numPtr = this.buffer)
        {
          int num1 = (int) *(uint*) (numPtr + this.fileOffset);
          uint id = *(uint*) (numPtr + this.fileOffset + 8);
          if ((int) id == (int) formtype)
          {
            uint num2 = *(uint*) (numPtr + this.fileOffset + 4);
            uint num3 = (uint) ((int) (num2 >> 24) | (int) num2 << 8 & 16711680 | (int) (num2 >> 8) & 65280 | (int) num2 << 24);
            iffChunk = new IffChunk(id, num3 - 4U, this.fileOffset, true, this.CurrentChunk);
          }
        }
      }
      return iffChunk;
    }

    public unsafe IffChunk OpenForm(uint formtype)
    {
      IffChunk iffChunk = (IffChunk) null;
      if (this.fileOffset + 12U <= this.fileLength)
      {
        fixed (byte* numPtr = this.buffer)
        {
          int num1 = (int) *(uint*) (numPtr + this.fileOffset);
          uint id = *(uint*) (numPtr + this.fileOffset + 8);
          if ((int) id == (int) formtype)
          {
            uint num2 = *(uint*) (numPtr + this.fileOffset + 4);
            uint num3 = (uint) ((int) (num2 >> 24) | (int) num2 << 8 & 16711680 | (int) (num2 >> 8) & 65280 | (int) num2 << 24);
            this.fileOffset += 12U;
            iffChunk = new IffChunk(id, num3 - 4U, this.fileOffset, true, this.CurrentChunk);
            this.CurrentChunk = iffChunk;
          }
        }
      }
      return iffChunk;
    }

    public unsafe IffChunk OpenChunk(uint rectype)
    {
      IffChunk iffChunk = (IffChunk) null;
      if (this.fileOffset + 8U <= this.CurrentChunk.End)
      {
        fixed (byte* numPtr = this.buffer)
        {
          uint id = *(uint*) (numPtr + this.fileOffset);
          if ((int) id == (int) rectype)
          {
            uint num = *(uint*) (numPtr + this.fileOffset + 4);
            uint size = (uint) ((int) (num >> 24) | (int) num << 8 & 16711680 | (int) (num >> 8) & 65280 | (int) num << 24);
            this.fileOffset += 8U;
            iffChunk = new IffChunk(id, size, this.fileOffset, false, this.CurrentChunk);
            this.CurrentChunk = iffChunk;
          }
        }
      }
      return iffChunk;
    }

    public bool CloseForm(uint type)
    {
      if (this.CurrentChunk == null)
        return false;
      bool flag = true;
      if (!this.CurrentChunk.IsFullyRead())
      {
        this.fileOffset = this.CurrentChunk.End;
        flag = false;
      }
      if (this.CurrentChunk.ParentChunk != null)
        this.CurrentChunk.ParentChunk.Read(12U + this.CurrentChunk.BytesRead);
      this.CurrentChunk = this.CurrentChunk.ParentChunk;
      return flag;
    }

    public bool CloseChunk(uint type)
    {
      if (this.CurrentChunk == null)
        return false;
      bool flag = true;
      if ((int) this.CurrentChunk.BytesRead != (int) this.CurrentChunk.Size)
      {
        this.fileOffset = this.CurrentChunk.End;
        flag = false;
      }
      if (this.CurrentChunk.ParentChunk != null)
        this.CurrentChunk.ParentChunk.Read(8U + this.CurrentChunk.BytesRead);
      this.CurrentChunk = this.CurrentChunk.ParentChunk;
      return flag;
    }

    public IffChunk OpenData() => this.OpenChunk(1096040772U);

    public bool CloseData() => this.CloseChunk(1096040772U);

    public IffChunk OpenInfo() => this.OpenChunk(1330007625U);

    public bool CloseInfo() => this.CloseChunk(1330007625U);

    public unsafe uint RootType()
    {
      if (this.fileLength < 8U)
        return 0;
      fixed (byte* numPtr = this.buffer)
        return this.fileLength >= 12U && *(uint*) numPtr == 1297239878U ? *(uint*) (numPtr + 8) : *(uint*) numPtr;
    }

    public unsafe uint NextType()
    {
      if (this.fileOffset + 12U <= this.CurrentChunk.End)
      {
        fixed (byte* numPtr = this.buffer)
          return *(uint*) (numPtr + this.fileOffset) == 1297239878U ? *(uint*) (numPtr + this.fileOffset + 8) : *(uint*) (numPtr + this.fileOffset);
      }
      else
      {
        if (this.fileOffset + 8U > this.CurrentChunk.End)
          return 0;
        fixed (byte* numPtr = this.buffer)
          return *(uint*) (numPtr + this.fileOffset);
      }
    }

    public unsafe void SkipNextChunk()
    {
      if (this.fileOffset + 8U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
        this.fileOffset += 8U + IffStream.FlipEndian(*(uint*) (numPtr + this.fileOffset + 4));
    }

    public unsafe uint RemainingSubChunks()
    {
      uint num1 = 0;
      uint num2 = 0;
      if (this.fileOffset < this.CurrentChunk.End)
      {
        fixed (byte* numPtr = this.buffer)
        {
          do
          {
            ++num1;
            num2 = num2 + IffStream.FlipEndian(*(uint*) (numPtr + num2 + this.fileOffset + 4)) + 8U;
          }
          while (num2 + this.fileOffset < this.CurrentChunk.End);
        }
      }
      return num1;
    }

    public void ResetOffset()
    {
      this.fileOffset = 0U;
      this.CurrentChunk = (IffChunk) null;
    }

    public static string TagString(uint tag)
    {
      string upper = Encoding.ASCII.GetString(BitConverter.GetBytes(tag)).ToUpper();
      return !IffStream.IsValidTag(tag) ? "invalid tag" : upper;
    }

    public static bool IsValidTag(uint tag)
    {
      if (((tag & 4278190080U) >> 24 < 65U || (tag & 4278190080U) >> 24 > 90U) && ((tag & 4278190080U) >> 24 < 48U || (tag & 4278190080U) >> 24 > 57U) && (tag & 4278190080U) >> 24 != 32U || ((tag & 16711680U) >> 16 < 65U || (tag & 16711680U) >> 16 > 90U) && ((tag & 16711680U) >> 16 < 48U || (tag & 16711680U) >> 16 > 57U) && (tag & 16711680U) >> 24 != 32U || ((tag & 65280U) >> 8 < 65U || (tag & 65280U) >> 8 > 90U) && ((tag & 65280U) >> 8 < 48U || (tag & 65280U) >> 8 > 57U) && (tag & 65280U) >> 24 != 32U)
        return false;
      return (tag & (uint) byte.MaxValue) >= 65U && (tag & (uint) byte.MaxValue) <= 90U || (tag & (uint) byte.MaxValue) >= 48U && (tag & (uint) byte.MaxValue) <= 57U || (tag & (uint) byte.MaxValue) >> 24 == 32U;
    }

    public unsafe uint PeekUInt32()
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        return 0;
      fixed (byte* numPtr = this.buffer)
        return *(uint*) numPtr;
    }

    public byte GetByte()
    {
      this.CurrentChunk.Read(1U);
      return this.ReadByte();
    }

    public byte[] GetBytes(uint count)
    {
      this.CurrentChunk.Read(count);
      return this.ReadBytes(count);
    }

    public bool GetBoolean()
    {
      this.CurrentChunk.Read(1U);
      return this.ReadBoolean();
    }

    public char GetChar()
    {
      this.CurrentChunk.Read(1U);
      return this.ReadChar();
    }

    public short GetInt16()
    {
      this.CurrentChunk.Read(2U);
      return this.ReadInt16();
    }

    public ushort GetUInt16()
    {
      this.CurrentChunk.Read(2U);
      return this.ReadUInt16();
    }

    public int GetInt32()
    {
      this.CurrentChunk.Read(4U);
      return this.ReadInt32();
    }

    public void GetEnum8<T>(out T value)
    {
      this.CurrentChunk.Read(1U);
      byte num = this.ReadByte();
      value = (T) Enum.Parse(typeof (T), num.ToString());
    }

    public void GetEnum32<T>(out T value)
    {
      this.CurrentChunk.Read(4U);
      int num = this.ReadInt32();
      value = (T) Enum.Parse(typeof (T), num.ToString());
    }

    public uint GetUInt32()
    {
      this.CurrentChunk.Read(4U);
      return this.ReadUInt32();
    }

    public bool GetUInt32AsBool()
    {
      this.CurrentChunk.Read(4U);
      return this.ReadUInt32() > 0U;
    }

    public uint GetBigEndianUInt32()
    {
      this.CurrentChunk.Read(4U);
      return IffStream.FlipEndian(this.ReadUInt32());
    }

    public long GetInt64()
    {
      this.CurrentChunk.Read(8U);
      return this.ReadInt64();
    }

    public ulong GetUInt64()
    {
      this.CurrentChunk.Read(8U);
      return this.ReadUInt64();
    }

    public float GetFloat()
    {
      this.CurrentChunk.Read(4U);
      return this.ReadFloat();
    }

    public double GetDouble()
    {
      this.CurrentChunk.Read(8U);
      return this.ReadDouble();
    }

    public void GetFloat(ref float value)
    {
      this.CurrentChunk.Read(4U);
      this.ReadFloat(ref value);
    }

    public Vector2 GetVector2()
    {
      this.CurrentChunk.Read(8U);
      return this.ReadVector2();
    }

    public Vector3 GetVector3()
    {
      this.CurrentChunk.Read(12U);
      return this.ReadVector3();
    }

    public Vector4 GetVector4()
    {
      this.CurrentChunk.Read(16U);
      return this.ReadVector4();
    }

    public Quaternion GetQuaternion()
    {
      this.CurrentChunk.Read(16U);
      return this.ReadQuaternion();
    }

    public Matrix GetMatrix()
    {
      this.CurrentChunk.Read(48U);
      return this.ReadMatrix();
    }

    public string GetString()
    {
      this.mStringBuilder.Clear();
      char ch;
      while ((ch = this.ReadChar()) != char.MinValue)
        this.mStringBuilder.Append(ch);
      this.CurrentChunk.Read((uint) ((ulong) this.mStringBuilder.Length + 1UL));
      return this.mStringBuilder.ToString();
    }

    public string GetString(uint length)
    {
      this.mStringBuilder.Clear();
      for (int index = 0; (long) index < (long) length; ++index)
        this.mStringBuilder.Append(this.ReadChar());
      this.CurrentChunk.Read(length);
      return this.mStringBuilder.ToString();
    }

    public Color GetRGB8Int()
    {
      this.CurrentChunk.Read(3U);
      return this.ReadRGB8Int();
    }

    public Color GetARGB8Int()
    {
      this.CurrentChunk.Read(3U);
      return this.ReadARGB8Int();
    }

    public Color GetRGBA8Int()
    {
      this.CurrentChunk.Read(4U);
      return this.ReadRGBA8Int();
    }

    public Color3 GetRGB32Float()
    {
      this.CurrentChunk.Read(12U);
      return this.ReadRGB32Float();
    }

    public Color4 GetARGB32Float()
    {
      this.CurrentChunk.Read(16U);
      return this.ReadARGB32Float();
    }

    public Color4 GetRGBA32Float()
    {
      this.CurrentChunk.Read(16U);
      return this.ReadRGBA32Float();
    }

    private unsafe Color ReadRGB8Int()
    {
      if (this.fileOffset + 3U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Color color = Color.FromArgb((int) numPtr[this.fileOffset], (int) (numPtr + this.fileOffset)[1], (int) (numPtr + this.fileOffset)[2]);
        this.fileOffset += 3U;
        return color;
      }
    }

    private unsafe Color ReadARGB8Int()
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Color color = Color.FromArgb((int) numPtr[this.fileOffset], (int) (numPtr + this.fileOffset)[1], (int) (numPtr + this.fileOffset)[2], (int) (numPtr + this.fileOffset)[3]);
        this.fileOffset += 4U;
        return color;
      }
    }

    private unsafe Color ReadRGBA8Int()
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Color color = Color.FromArgb((int) (numPtr + this.fileOffset)[3], (int) (numPtr + this.fileOffset)[2], (int) (numPtr + this.fileOffset)[1], (int) numPtr[this.fileOffset]);
        this.fileOffset += 4U;
        return color;
      }
    }

    private unsafe Color3 ReadRGB32Float()
    {
      if (this.fileOffset + 12U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Color3 color3 = new Color3(*(float*) (numPtr + this.fileOffset), *(float*) (numPtr + this.fileOffset + 4), *(float*) (numPtr + this.fileOffset + 8));
        this.fileOffset += 12U;
        return color3;
      }
    }

    private unsafe Color4 ReadARGB32Float()
    {
      if (this.fileOffset + 16U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Color4 color4 = new Color4(*(float*) (numPtr + this.fileOffset), *(float*) (numPtr + this.fileOffset + 4), *(float*) (numPtr + this.fileOffset + 8), *(float*) (numPtr + this.fileOffset + 12));
        this.fileOffset += 16U;
        return color4;
      }
    }

    private unsafe Color4 ReadRGBA32Float()
    {
      if (this.fileOffset + 16U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Color4 color4 = new Color4(*(float*) (numPtr + this.fileOffset + 12), *(float*) (numPtr + this.fileOffset + 8), *(float*) (numPtr + this.fileOffset + 4), *(float*) (numPtr + this.fileOffset));
        this.fileOffset += 16U;
        return color4;
      }
    }

    private unsafe float ReadFloat()
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        double num = (double) *(float*) (numPtr + this.fileOffset);
        this.fileOffset += 4U;
        return (float) num;
      }
    }

    private unsafe void ReadFloat(ref float value)
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        value = *(float*) (numPtr + this.fileOffset);
        this.fileOffset += 4U;
      }
    }

    private unsafe double ReadDouble()
    {
      if (this.fileOffset + 8U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        double num = *(double*) (numPtr + this.fileOffset);
        this.fileOffset += 8U;
        return num;
      }
    }

    private unsafe Vector2 ReadVector2()
    {
      if (this.fileOffset + 8U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Vector2 vector2 = new Vector2(*(float*) (numPtr + this.fileOffset), *(float*) (numPtr + this.fileOffset + 4));
        this.fileOffset += 8U;
        return vector2;
      }
    }

    private unsafe Vector3 ReadVector3()
    {
      if (this.fileOffset + 12U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Vector3 vector3 = new Vector3(*(float*) (numPtr + this.fileOffset), *(float*) (numPtr + this.fileOffset + 4), *(float*) (numPtr + this.fileOffset + 8));
        this.fileOffset += 12U;
        return vector3;
      }
    }

    private unsafe Vector4 ReadVector4()
    {
      if (this.fileOffset + 16U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Vector4 vector4 = new Vector4(*(float*) (numPtr + this.fileOffset), *(float*) (numPtr + this.fileOffset + 4), *(float*) (numPtr + this.fileOffset + 8), *(float*) (numPtr + this.fileOffset + 12));
        this.fileOffset += 16U;
        return vector4;
      }
    }

    private unsafe Quaternion ReadQuaternion()
    {
      if (this.fileOffset + 16U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Quaternion quaternion = new Quaternion(*(float*) (numPtr + this.fileOffset + 4), *(float*) (numPtr + this.fileOffset + 8), *(float*) (numPtr + this.fileOffset + 12), *(float*) (numPtr + this.fileOffset));
        this.fileOffset += 16U;
        return quaternion;
      }
    }

    private unsafe Matrix ReadMatrix()
    {
      if (this.fileOffset + 48U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        Matrix matrix = new Matrix()
        {
          M11 = *(float*) (numPtr + this.fileOffset),
          M12 = *(float*) (numPtr + this.fileOffset + 4),
          M13 = *(float*) (numPtr + this.fileOffset + 8),
          M41 = *(float*) (numPtr + this.fileOffset + 12),
          M21 = *(float*) (numPtr + this.fileOffset + 16),
          M22 = *(float*) (numPtr + this.fileOffset + 20),
          M23 = *(float*) (numPtr + this.fileOffset + 24),
          M42 = *(float*) (numPtr + this.fileOffset + 28),
          M31 = *(float*) (numPtr + this.fileOffset + 32),
          M32 = *(float*) (numPtr + this.fileOffset + 36),
          M33 = *(float*) (numPtr + this.fileOffset + 40),
          M43 = *(float*) (numPtr + this.fileOffset + 44),
          M44 = 1f
        };
        this.fileOffset += 48U;
        return matrix;
      }
    }

    private unsafe long ReadInt64()
    {
      if (this.fileOffset + 8U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        long num = *(long*) (numPtr + this.fileOffset);
        this.fileOffset += 8U;
        return num;
      }
    }

    private unsafe ulong ReadUInt64()
    {
      if (this.fileOffset + 8U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        long num = *(long*) (numPtr + this.fileOffset);
        this.fileOffset += 8U;
        return (ulong) num;
      }
    }

    private unsafe int ReadInt32()
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = *(int*) (numPtr + this.fileOffset);
        this.fileOffset += 4U;
        return num;
      }
    }

    private unsafe uint ReadUInt32()
    {
      if (this.fileOffset + 4U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = (int) *(uint*) (numPtr + this.fileOffset);
        this.fileOffset += 4U;
        return (uint) num;
      }
    }

    private unsafe short ReadInt16()
    {
      if (this.fileOffset + 2U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = (int) *(short*) (numPtr + this.fileOffset);
        this.fileOffset += 2U;
        return (short) num;
      }
    }

    private unsafe ushort ReadUInt16()
    {
      if (this.fileOffset + 2U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = (int) *(ushort*) (numPtr + this.fileOffset);
        this.fileOffset += 2U;
        return (ushort) num;
      }
    }

    private static uint FlipEndian(uint x)
    {
      return (uint) ((int) (x >> 24) | (int) x << 8 & 16711680 | (int) (x >> 8) & 65280 | (int) x << 24);
    }

    private unsafe byte ReadByte()
    {
      if (this.fileOffset + 1U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = (int) numPtr[this.fileOffset];
        ++this.fileOffset;
        return (byte) num;
      }
    }

    private unsafe bool ReadBoolean()
    {
      if (this.fileOffset + 1U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = (int) numPtr[this.fileOffset];
        ++this.fileOffset;
        return (uint) num > 0U;
      }
    }

    private unsafe char ReadChar()
    {
      if (this.fileOffset + 1U > this.CurrentChunk.End)
        throw new EndOfStreamException("Can not read past end of stream");
      fixed (byte* numPtr = this.buffer)
      {
        int num = (int) numPtr[this.fileOffset];
        ++this.fileOffset;
        return (char) num;
      }
    }

    private unsafe byte[] ReadBytes(uint count)
    {
      byte[] numArray1 = new byte[(int) count];
      fixed (byte* numPtr = this.buffer)
      {
        byte[] numArray2 = numArray1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        fixed (byte* dest = &^(numArray1 == null || numArray2.Length == 0 ? (byte&) IntPtr.Zero : ref numArray2[0]))
        {
          IntPtr src = (IntPtr) (void*) (numPtr + this.fileOffset);
          IffStream.MemCopy((IntPtr) (void*) dest, src, (UIntPtr) count);
          this.fileOffset += count;
        }
      }
      return numArray1;
    }
  }
}
