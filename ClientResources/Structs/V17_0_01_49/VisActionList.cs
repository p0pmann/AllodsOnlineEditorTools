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

[SerializedExtent(124)]
[XdbName("VisActionList")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisActionList
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 8)] public NullablePointer[] @elements;
    [FieldOffset(104)][EnumRef(typeof(Enums.@e_177f030))] public int @play;
    [FieldOffset(112)] public NullablePointer @playWhile;
    [FieldOffset(120)] public bool @preconditional;
    [FieldOffset(121)] public bool @restartOnVisualChange;
    [FieldOffset(122)] public bool @stopOnDeath;
    [FieldOffset(123)] public bool @stopWhileWhenElementsEnded;
}
