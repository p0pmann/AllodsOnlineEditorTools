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

[StructSize(88)]
[XdbName("AliasCreatureVisActionResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AliasCreatureVisActionResource
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(80)] public ResourcePointer @resource;
}
