// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49;

[StructSize(112)]
[XdbName("CreatureIntervalVisScripts")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureIntervalVisScripts
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(72)] public NullablePointer @parameter;
    [FieldOffset(80, ArrayStride = 40)] public Layouts.@s_174d020[] @states;
}
