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

[SerializedExtent(168)]
[XdbName("CreatureFixedPointProjectileAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureFixedPointProjectileAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public ResourcePointer @explosionFx;
    [FieldOffset(80)] public NullablePointer @offendTime;
    [FieldOffset(88)] public float @optionalSpeed;
    [FieldOffset(96)] public NullablePointer @pointOnCaster;
    [FieldOffset(104)] public NullablePointer @pointOnTarget;
    [FieldOffset(112)] public ResourcePointer @projectileFx;
    [FieldOffset(120)] public float @theGe;
    [FieldOffset(124)] public bool @dontFade;
    [FieldOffset(125)] public bool @isInverted;
    [FieldOffset(126)] public bool @isMultyProjectile;
    [FieldOffset(136, ArrayStride = 16)] public Layouts.@s_177bdb0[] @lines;
}
