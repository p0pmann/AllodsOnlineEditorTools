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
[XdbName("gameMechanics.constructor.basicInterfaces.ActionGroup")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ActionGroup
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @actions;
    [FieldOffset(72, ArrayStride = 72)] public Layouts.@s_1521700[] @customDescriptions;
    [FieldOffset(104)] public ResourcePointer @image;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_11587c0))] public int @interfaceBuffPriority;
    [FieldOffset(120)] public TextFileRef @name;
    [FieldOffset(152)] public string @sysName;
    [FieldOffset(176)] public bool @genActions;
}
