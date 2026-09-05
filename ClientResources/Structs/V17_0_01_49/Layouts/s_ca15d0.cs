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

[SerializedExtent(96)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_ca15d0
{
    [FieldOffset(8)] public Layouts.@s_a96d80 @hitSound;
    [FieldOffset(48)][EnumRef(typeof(Enums.@e_c65760))] public int @material;
    [FieldOffset(56)] public Layouts.@s_a96d80 @whooshSound;
}
