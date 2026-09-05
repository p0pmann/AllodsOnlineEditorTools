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

[SerializedExtent(117)]
[XdbName("GuildColorsMaskComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildColorsMaskComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public ResourcePointer @maskTexture;
    [FieldOffset(80, ArrayStride = 24)] public string[] @shapeNames;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_19377f0))] public int @usedShapes;
    [FieldOffset(116)] public bool @useGuildTexture;
}
