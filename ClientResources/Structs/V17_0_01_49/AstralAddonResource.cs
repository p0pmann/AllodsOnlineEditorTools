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
[XdbName("gameMechanics.world.bigAstral.AstralAddonResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralAddonResource
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @key;
    [FieldOffset(80)] public float @levelOffset;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public bool @isSphere;
}
