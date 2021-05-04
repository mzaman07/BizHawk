// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace NymaTypes
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct NStatusInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static NStatusInfo GetRootAsNStatusInfo(ByteBuffer _bb) { return GetRootAsNStatusInfo(_bb, new NStatusInfo()); }
  public static NStatusInfo GetRootAsNStatusInfo(ByteBuffer _bb, NStatusInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public NStatusInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public NymaTypes.NStatusState? States(int j) { int o = __p.__offset(4); return o != 0 ? (NymaTypes.NStatusState?)(new NymaTypes.NStatusState()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int StatesLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<NymaTypes.NStatusInfo> CreateNStatusInfo(FlatBufferBuilder builder,
      VectorOffset StatesOffset = default(VectorOffset)) {
    builder.StartTable(1);
    NStatusInfo.AddStates(builder, StatesOffset);
    return NStatusInfo.EndNStatusInfo(builder);
  }

  public static void StartNStatusInfo(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddStates(FlatBufferBuilder builder, VectorOffset StatesOffset) { builder.AddOffset(0, StatesOffset.Value, 0); }
  public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<NymaTypes.NStatusState>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<NymaTypes.NStatusState>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartStatesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<NymaTypes.NStatusInfo> EndNStatusInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<NymaTypes.NStatusInfo>(o);
  }
  public NStatusInfoT UnPack() {
    var _o = new NStatusInfoT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(NStatusInfoT _o) {
    _o.States = new List<NymaTypes.NStatusStateT>();
    for (var _j = 0; _j < this.StatesLength; ++_j) {_o.States.Add(this.States(_j).HasValue ? this.States(_j).Value.UnPack() : null);}
  }
  public static Offset<NymaTypes.NStatusInfo> Pack(FlatBufferBuilder builder, NStatusInfoT _o) {
    if (_o == null) return default(Offset<NymaTypes.NStatusInfo>);
    var _States = default(VectorOffset);
    if (_o.States != null) {
      var __States = new Offset<NymaTypes.NStatusState>[_o.States.Count];
      for (var _j = 0; _j < __States.Length; ++_j) { __States[_j] = NymaTypes.NStatusState.Pack(builder, _o.States[_j]); }
      _States = CreateStatesVector(builder, __States);
    }
    return CreateNStatusInfo(
      builder,
      _States);
  }
};

public class NStatusInfoT
{
  public List<NymaTypes.NStatusStateT> States { get; set; }

  public NStatusInfoT() {
    this.States = null;
  }
}


}