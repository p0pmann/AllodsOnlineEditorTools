// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(224)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1545910
{
    [FieldOffset(8)] public string @chargenAnimationLoop;
    [FieldOffset(32)] public string @chargenAnimationNewEquipment;
    [FieldOffset(56)] public string @chargenAnimationStart;
    [FieldOffset(80, ArrayStride = 24)] public Layouts.@s_c8d420[] @chargenDressedItems;
    [FieldOffset(112, ArrayStride = 48)] public Layouts.@s_1545810[] @chargenEffects;
    [FieldOffset(144)] public int @level;
    [FieldOffset(152)] public Layouts.@s_1545b40 @mount;
}
