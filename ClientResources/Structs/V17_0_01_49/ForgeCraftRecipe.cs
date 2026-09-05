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

[StructSize(264)]
[XdbName("gameMechanics.elements.skills.forge.ForgeCraftRecipe")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ForgeCraftRecipe
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(72)] public TextFileRef @Name;
    [FieldOffset(104, ArrayStride = 8)] public NullablePointer[] @available;
    [FieldOffset(136)] public Layouts.@s_fdb5b0 @craftComponents;
    [FieldOffset(216, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(248)] public NullablePointer @result;
    [FieldOffset(256)] public NullablePointer @resultQuantityCalcer;
}
