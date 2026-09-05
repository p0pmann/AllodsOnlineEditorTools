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

[StructSize(104)]
[XdbName("gameMechanics.world.avatar.form.CharacterForm")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterForm
{
    [FieldOffset(40)] public TextFileRef @Name;
    [FieldOffset(72)] public ResourcePointer @image;
    [FieldOffset(80)] public string @sysName;
}
