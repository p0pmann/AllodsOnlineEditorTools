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

[StructSize(192)]
[XdbName("SpellVisScripts")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SpellVisScripts
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(72)] public NullablePointer @actionBarCancel;
    [FieldOffset(80)] public NullablePointer @actionBarComplite;
    [FieldOffset(88)] public NullablePointer @actionBarStart;
    [FieldOffset(96)][EnumRef(typeof(Enums.@e_c4a6f0))] public int @precastType;
    [FieldOffset(104)] public NullablePointer @wholeCasting;
    [FieldOffset(120)] public NullablePointer @charged;
    [FieldOffset(128)] public NullablePointer @launch;
    [FieldOffset(136)] public Layouts.@s_c5e240 @ownKillingParams;
    [FieldOffset(152)] public Layouts.@s_c66d50 @playOnTargets;
    [FieldOffset(176)] public NullablePointer @preparation;
    [FieldOffset(184)] public bool @useOwnKillingParams;
}
