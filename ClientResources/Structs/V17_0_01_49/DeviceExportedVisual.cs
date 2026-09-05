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
[XdbName("DeviceExportedVisual")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceExportedVisual
{
    [FieldOffset(40)] public ResourcePointer @brokenObject;
    [FieldOffset(48)] public ResourcePointer @damagedObject;
    [FieldOffset(56)] public ResourcePointer @normalObject;
    [FieldOffset(64, ArrayStride = 32)] public Layouts.@s_19b19a0[] @techLevels;
}
