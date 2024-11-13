// Decompiled with JetBrains decompiler
// Type: LibSWBDotNet.SaveOperation
// Assembly: LibSWBInterop, Version=1.0.6184.236, Culture=neutral, PublicKeyToken=null
// MVID: B8F9312C-845E-42D3-9114-F2250FC92114
// Assembly location: C:\MyStarWarsGalaxies\sytner\LibSWBInterop.dll

using std;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace LibSWBDotNet
{
  public class SaveOperation : IDisposable
  {
    private SaveOperation.ProgressEventDelegate del;
    private GCHandle delH;
    private unsafe CTreeFileWriter* w;
    private unsafe CTreeBuildProcess* buildProcess;
    private Action<float, string> callback;

    public unsafe void InitCallback(string outputPath)
    {
      SaveOperation.ProgressEventDelegate progressEventDelegate = new SaveOperation.ProgressEventDelegate(this.OnProgressChanged);
      this.del = progressEventDelegate;
      this.delH = GCHandle.Alloc((object) progressEventDelegate);
      IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) this.del);
      function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst1;
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D\u003Cvoid\u0020\u0028__cdecl\u002A\u0029\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u002Cvoid\u002Cvoid\u003E(&cdeclFloatCharConst1, (__FnPtr<void (float, sbyte*)>) (IntPtr) pointerForDelegate.ToPointer());
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar;
        \u003CModule\u003E.msclr\u002Einterop\u002Emarshal_as\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(&stdAllocatorChar, &outputPath);
        // ISSUE: fault handler
        try
        {
          function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E cdeclFloatCharConst2;
          function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* pThis = &cdeclFloatCharConst2;
          function\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E* cdeclFloatCharConstPtr = \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bctor\u007D(&cdeclFloatCharConst2, &cdeclFloatCharConst1);
          CTreeFileWriter* w;
          // ISSUE: fault handler
          try
          {
            w = this.w;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) pThis);
          }
          unique_ptr\u003CCTreeBuildProcess\u002Cstd\u003A\u003Adefault_delete\u003CCTreeBuildProcess\u003E\u0020\u003E ctreeBuildProcess;
          \u003CModule\u003E.CTreeFileWriter\u002ESaveToFile(w, &ctreeBuildProcess, &stdAllocatorChar, cdeclFloatCharConstPtr);
          // ISSUE: fault handler
          try
          {
            this.buildProcess = \u003CModule\u003E.std\u002Eunique_ptr\u003CCTreeBuildProcess\u002Cstd\u003A\u003Adefault_delete\u003CCTreeBuildProcess\u003E\u0020\u003E\u002Eget(&ctreeBuildProcess);
            \u003CModule\u003E.std\u002Eunique_ptr\u003CCTreeBuildProcess\u002Cstd\u003A\u003Adefault_delete\u003CCTreeBuildProcess\u003E\u0020\u003E\u002Erelease(&ctreeBuildProcess);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003CCTreeBuildProcess\u002Cstd\u003A\u003Adefault_delete\u003CCTreeBuildProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &ctreeBuildProcess);
          }
          \u003CModule\u003E.std\u002Eunique_ptr\u003CCTreeBuildProcess\u002Cstd\u003A\u003Adefault_delete\u003CCTreeBuildProcess\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&ctreeBuildProcess);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar);
        }
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&stdAllocatorChar);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D), (void*) &cdeclFloatCharConst1);
      }
      \u003CModule\u003E.std\u002Efunction\u003Cvoid\u0020__cdecl\u0028float\u002Cchar\u0020const\u0020\u002A\u0029\u003E\u002E\u007Bdtor\u007D(&cdeclFloatCharConst1);
    }

    public unsafe SaveOperation(
      CTreeFileWriter* writer,
      string outputPath,
      Action<float, string> action)
    {
      this.w = writer;
      this.callback = action;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.InitCallback(outputPath);
    }

    private unsafe void \u007ESaveOperation()
    {
      this.delH.Free();
      \u003CModule\u003E.CTreeBuildProcess\u002EKill(this.buildProcess);
      CTreeBuildProcess* buildProcess = this.buildProcess;
      if ((IntPtr) buildProcess == IntPtr.Zero)
        return;
      \u003CModule\u003E.CTreeBuildProcess\u002E\u007Bdtor\u007D(buildProcess);
      \u003CModule\u003E.delete((void*) buildProcess, 8UL);
    }

    public unsafe void Wait() => \u003CModule\u003E.CTreeBuildProcess\u002EWait(this.buildProcess);

    public unsafe void Kill() => \u003CModule\u003E.CTreeBuildProcess\u002EKill(this.buildProcess);

    private void OnProgressChanged(float percent, string msg)
    {
      if (!((MulticastDelegate) this.callback != (MulticastDelegate) null))
        return;
      this.callback(percent, msg);
    }

    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
    {
      if (A_0)
      {
        this.\u007ESaveOperation();
      }
      else
      {
        // ISSUE: explicit finalizer call
        this.Finalize();
      }
    }

    public virtual void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private delegate void ProgressEventDelegate(float i, string __unnamed001);
  }
}
