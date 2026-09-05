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

[SerializedExtent(40)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1532040
{
    [FieldOffset(4)] public int @experienceForLevel;
    [FieldOffset(8)] public int @fairyExperienceForLevel;
    [FieldOffset(12)] public int @level;
    [FieldOffset(16)] public int @rubies;
    [FieldOffset(24)] public NullablePointer @rubiesAdditionalPoints;
    [FieldOffset(32)] public ResourcePointer @unlock;
}
