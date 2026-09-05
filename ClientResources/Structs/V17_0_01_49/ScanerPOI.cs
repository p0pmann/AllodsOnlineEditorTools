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

[StructSize(128)]
[XdbName("gameMechanics.world.bigAstral.ScanerPOI")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScanerPOI
{
    [FieldOffset(48)] public ResourcePointer @collision;
    [FieldOffset(56)] public TextFileRef @description;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public ResourcePointer @obj;
}
