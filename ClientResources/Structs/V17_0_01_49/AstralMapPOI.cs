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

[StructSize(120)]
[XdbName("gameMechanics.world.bigAstral.AstralMapPOI")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralMapPOI
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @image;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public bool @direct;
    [FieldOffset(113)] public bool @hidden;
}
