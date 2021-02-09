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

public partial class PxAggregate : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxAggregate(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxAggregate_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxAggregate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxAggregate getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxAggregate)) {
          wrapper = new PxAggregate(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxAggregate;
  }

  public bool addActor(PxActor actor, PxBVHStructure bvhStructure) {
    bool ret = NativePINVOKE.PxAggregate_addActor__SWIG_0(swigCPtr, PxActor.getCPtr(actor), PxBVHStructure.getCPtr(bvhStructure));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool addActor(PxActor actor) {
    bool ret = NativePINVOKE.PxAggregate_addActor__SWIG_1(swigCPtr, PxActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool removeActor(PxActor actor) {
    bool ret = NativePINVOKE.PxAggregate_removeActor(swigCPtr, PxActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool addArticulation(PxArticulationBase articulation) {
    bool ret = NativePINVOKE.PxAggregate_addArticulation(swigCPtr, PxArticulationBase.getCPtr(articulation));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool removeArticulation(PxArticulationBase articulation) {
    bool ret = NativePINVOKE.PxAggregate_removeArticulation(swigCPtr, PxArticulationBase.getCPtr(articulation));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbActors() {
    uint ret = NativePINVOKE.PxAggregate_getNbActors(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getMaxNbActors() {
    uint ret = NativePINVOKE.PxAggregate_getMaxNbActors(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxActor getActor(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxAggregate_getActor(swigCPtr, index);
    PxActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxActor.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxScene getScene() {
    global::System.IntPtr cPtr = NativePINVOKE.PxAggregate_getScene(swigCPtr);
    PxScene ret = (cPtr == global::System.IntPtr.Zero) ? null : PxScene.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getSelfCollision() {
    bool ret = NativePINVOKE.PxAggregate_getSelfCollision(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}