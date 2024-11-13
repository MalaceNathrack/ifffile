// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.PrioritisedFile
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System;

#nullable disable
namespace LibSWBDotNet
{
  public class PrioritisedFile : IComparable
  {
    public string Path;
    public int Priority;

    public unsafe PrioritisedFile(SPrioritisedFile* native)
    {
      this.Path = new string(\u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str((basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) native));
      this.Priority = *(int*) ((IntPtr) native + 32L);
    }

    public PrioritisedFile(string path, int priority)
    {
      this.Path = path;
      this.Priority = priority;
    }

    public virtual int CompareTo(object other)
    {
      PrioritisedFile prioritisedFile = (PrioritisedFile) other;
      int priority1 = this.Priority;
      int priority2 = prioritisedFile.Priority;
      return priority1 <= priority2 ? (priority1 == priority2 ? 0 : 1) : -1;
    }
  }
}
