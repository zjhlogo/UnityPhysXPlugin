//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NVIDIA.PhysX {

[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct PxArticulationRootLinkData {

  public PxTransform transform; public PxVec3 worldLinVel,worldAngVel,worldLinAccel,worldAngAccel;

  internal global::System.IntPtr swigCPtr {
    get { unsafe { fixed(PxArticulationRootLinkData* p = &this) return (global::System.IntPtr)p; } }
  }

  internal PxArticulationRootLinkData(global::System.IntPtr ptr, bool unused) {
      //this = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxArticulationRootLinkData>(ptr);
      unsafe { this = *(PxArticulationRootLinkData*)ptr; }
  }
    
}

}