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

[StructSize(160)]
[XdbName("gameMechanics.constructor.schemes.talent.TalentFieldResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TalentFieldResource
{
    [FieldOffset(40)] public ResourcePointer @image;
    [FieldOffset(48)] public TextFileRef @name;
    [FieldOffset(80, ArrayStride = 40)] public Layouts.@s_16110c0[] @rows;
    [FieldOffset(112)] public TextFileRef @startElementDesc;
    [FieldOffset(144)] public ResourcePointer @startElementImage;
    [FieldOffset(152)] public int @startColumn;
    [FieldOffset(156)] public int @startRow;
}
