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

[StructSize(184)]
[XdbName("gameMechanics.constructor.schemes.skill.Recipe")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Recipe
{
    [FieldOffset(40)] public ResourcePointer @afflatusItem;
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80)] public ResourcePointer @image;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public ResourcePointer @nextRecipe;
    [FieldOffset(128)] public int @nextRecipePoints;
    [FieldOffset(136)] public ResourcePointer @nextRecipeResource;
    [FieldOffset(144)] public ResourcePointer @qualificationPoints;
    [FieldOffset(152)] public NullablePointer @recipeInfo;
    [FieldOffset(160)] public NullablePointer @result;
    [FieldOffset(168)] public int @resultQuantity;
    [FieldOffset(172)] public int @skillScore;
    [FieldOffset(176)] public bool @bindResult;
}
