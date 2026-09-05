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

[StructSize(104)]
[XdbName("PropertiesOfCreatureAnimations")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PropertiesOfCreatureAnimations
{
    [FieldOffset(40)] public ResourcePointer @breakSheathAnimations;
    [FieldOffset(48, ArrayStride = 40)] public Layouts.@s_17767f0[] @fallbacks;
    [FieldOffset(80)] public ResourcePointer @lookAtTargetAnimations;
    [FieldOffset(88)] public ResourcePointer @meleeAttackAnimations;
    [FieldOffset(96)] public ResourcePointer @visualDismount;
}
