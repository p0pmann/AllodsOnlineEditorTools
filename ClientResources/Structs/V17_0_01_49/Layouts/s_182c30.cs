// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(33)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_182c30
{
    [FieldOffset(4)] public int @decalColor;
    [FieldOffset(8)][EnumRef(typeof(Enums.@e_183270))] public int @decalMirrorMode;
    [FieldOffset(12)] public float @decalRotation;
    [FieldOffset(16)] public float @decalSize;
    [FieldOffset(24)] public ResourcePointer @decalTexture;
    [FieldOffset(32)] public bool @decalInheritRotation;
}
