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

[StructSize(256)]
[XdbName("gameMechanics.world.mob.interaction.Cue")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Cue
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @conditions;
    [FieldOffset(72, ArrayStride = 8)] public NullablePointer[] @data;
    [FieldOffset(104)] public ResourcePointer @image;
    [FieldOffset(112)] public TextFileRef @name;
    [FieldOffset(144, ArrayStride = 8)] public ResourcePointer[] @nextCues;
    [FieldOffset(176)] public TextFileRef @text;
    [FieldOffset(208, ArrayStride = 80)] public Layouts.@s_156c590[] @textVars;
    [FieldOffset(240)] public ResourcePointer @titlePicture;
    [FieldOffset(248)] public bool @isSpecial;
    [FieldOffset(249)] public bool @isVendorTable;
    [FieldOffset(250)] public bool @randomizeNextCues;
}
