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

[StructSize(312)]
[XdbName("gameMechanics.constructor.schemes.ability.AbilityResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AbilityResource
{
    [FieldOffset(48, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)] public ResourcePointer @image;
    [FieldOffset(120)] public int @level;
    [FieldOffset(128)] public TextFileRef @name;
    [FieldOffset(160, ArrayStride = 8)] public ResourcePointer[] @ranks;
    [FieldOffset(192)] public Layouts.@s_10a8a40 @relatedResources;
    [FieldOffset(264, ArrayStride = 8)] public ResourcePointer[] @spells;
    [FieldOffset(296)] public NullablePointer @visualScript;
    [FieldOffset(304)] public bool @hideNotification;
    [FieldOffset(305)] public bool @isHidden;
}
