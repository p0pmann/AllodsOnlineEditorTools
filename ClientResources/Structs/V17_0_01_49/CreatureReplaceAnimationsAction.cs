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

[SerializedExtent(361)]
[XdbName("CreatureReplaceAnimationsAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureReplaceAnimationsAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
    [FieldOffset(72)] public Layouts.@s_172a750 @onBottom;
    [FieldOffset(152)] public Layouts.@s_172a750 @onMount;
    [FieldOffset(232)] public Layouts.@s_172a750 @onTop;
    [FieldOffset(312)] public ResourcePointer @priority;
    [FieldOffset(320)][EnumRef(typeof(Enums.@e_17571f0))] public int @replaceWhen;
    [FieldOffset(328, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @slots;
    [FieldOffset(360)] public bool @restartOnVisualChange;
}
