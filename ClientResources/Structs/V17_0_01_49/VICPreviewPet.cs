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

[SerializedExtent(72)]
[XdbName("VICPreviewPet")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VICPreviewPet
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_168610))] public int @idleAnim;
    [FieldOffset(48)] public Vector3 @offset;
    [FieldOffset(64)] public ResourcePointer @visObj;
}
