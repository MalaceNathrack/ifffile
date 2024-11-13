// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.Errors
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using System.Runtime.CompilerServices;

#nullable disable
namespace LibSWBDotNet
{
  public sealed class Errors
  {
    public static event Error ErrorEvent;

    [SpecialName]
    protected static void raise_ErrorEvent(int value0, string value1)
    {
      Error backingStoreErrorEvent = Errors.\u003Cbacking_store\u003EErrorEvent;
      if (backingStoreErrorEvent == null)
        return;
      backingStoreErrorEvent(value0, value1);
    }

    public static void SendError(int severity, string message)
    {
      Error backingStoreErrorEvent = Errors.\u003Cbacking_store\u003EErrorEvent;
      if (backingStoreErrorEvent == null)
        return;
      backingStoreErrorEvent(severity, message);
    }
  }
}
