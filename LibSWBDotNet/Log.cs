// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.Log
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;

#nullable disable
namespace LibSWBDotNet
{
  public class Log
  {
    public static unsafe void Write(LogLevel level, string message)
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
      \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &message);
      // ISSUE: fault handler
      try
      {
        switch (level)
        {
          case LogLevel.Critical:
            \u003CModule\u003E.LogCritical2\u003C\u003E(&stdAllocatorChar);
            break;
          case LogLevel.Error:
            \u003CModule\u003E.LogError2\u003C\u003E(&stdAllocatorChar);
            break;
          case LogLevel.Warning:
            \u003CModule\u003E.LogWarning2\u003C\u003E(&stdAllocatorChar);
            break;
          case LogLevel.Info:
            \u003CModule\u003E.LogInfo2\u003C\u003E(&stdAllocatorChar);
            break;
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
    }
  }
}
