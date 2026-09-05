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

[StructSize(56)]
[XdbName("mapLoader.MapTemplate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MapTemplate
{
    [FieldOffset(36)] public int @mapSize;
    [FieldOffset(40)] public Layouts.@s_15b37c0 @mechanicsSettings;
    [FieldOffset(48)] public bool @hasPatches;
    [FieldOffset(49)] public bool @isStartInstance;
}
