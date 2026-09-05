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

[SerializedExtent(56)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c9fa00
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_c65760))] public int @materialFirst;
    [FieldOffset(8)][EnumRef(typeof(Enums.@e_c65760))] public int @materialSecond;
    [FieldOffset(16)] public Layouts.@s_a96d80 @sound;
}
