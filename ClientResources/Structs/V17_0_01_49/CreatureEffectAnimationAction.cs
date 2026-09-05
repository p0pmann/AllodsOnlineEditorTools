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

[SerializedExtent(112)]
[XdbName("CreatureEffectAnimationAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureEffectAnimationAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_168610))] public int @animation;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_c4ebb0))] public int @mode;
    [FieldOffset(76)] public float @speed;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @visObjs;
}
