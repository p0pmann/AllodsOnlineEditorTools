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
[XdbName("gameMechanics.world.avatar.Character")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Character
{
    [FieldOffset(40)] public ResourcePointer @characterRaceClass;
    [FieldOffset(48)] public ResourcePointer @characterSex;
    [FieldOffset(56)] public ResourcePointer @characterType;
    [FieldOffset(64, ArrayStride = 24)] public Layouts.@s_c8d420[] @dressItems;
    [FieldOffset(96, ArrayStride = 224)] public Layouts.@s_1545910[] @growths;
}
