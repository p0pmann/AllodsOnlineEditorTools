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

[StructSize(288)]
[XdbName("SlonConstants")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SlonConstants
{
    [FieldOffset(36)] public Layouts.@s_1967c00 @deathDesync;
    [FieldOffset(52)] public float @disableProceduralAndColorEffectsSize;
    [FieldOffset(56, ArrayStride = 8)] public Layouts.@s_163a920[] @itemRuneGrades;
    [FieldOffset(88)] public Layouts.@s_196a590 @overkillParams;
    [FieldOffset(192)] public Layouts.@s_1967e40 @soulSparkParams;
    [FieldOffset(256)] public Layouts.@s_1967f20 @threatConstants;
}
