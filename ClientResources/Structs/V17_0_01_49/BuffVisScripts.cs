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

[StructSize(128)]
[XdbName("BuffVisScripts")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BuffVisScripts
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(72)] public NullablePointer @action;
    [FieldOffset(80)] public NullablePointer @postAction;
    [FieldOffset(88, ArrayStride = 40)] public Layouts.@s_174d020[] @stackCountVisScripts;
    [FieldOffset(120)] public bool @restartOnIncStackCount;
}
