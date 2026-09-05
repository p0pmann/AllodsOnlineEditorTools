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

[StructSize(96)]
[XdbName("ServerVariablesRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ServerVariablesRoot
{
    [FieldOffset(40)] public ResourcePointer @artefactsSchedule;
    [FieldOffset(48, ArrayStride = 8)] public long[] @levelMaxValues;
    [FieldOffset(80)] public ResourcePointer @progressResource;
    [FieldOffset(88)] public ResourcePointer @unlockLevelResource;
}
