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

[StructSize(120)]
[XdbName("ClientPetInfo")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ClientPetInfo
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_168610))] public int @blinkAnim;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_168610))] public int @danceAnim;
    [FieldOffset(48, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @idleAnim;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_168610))] public int @runAnim;
    [FieldOffset(88)] public ResourcePointer @teleportFx;
    [FieldOffset(96)] public float @teleportFxScale;
    [FieldOffset(100)] public float @teleportFxShift;
    [FieldOffset(104)] public ResourcePointer @visObj;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_168610))] public int @walkAnim;
}
