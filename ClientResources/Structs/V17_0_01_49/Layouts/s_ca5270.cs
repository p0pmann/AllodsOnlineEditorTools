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

[SerializedExtent(20)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_ca5270
{
    [FieldOffset(8)] public ResourcePointer @projectile;
    [FieldOffset(16)][EnumRef(typeof(Enums.@e_168610))] public int @throwAnimation;
}
