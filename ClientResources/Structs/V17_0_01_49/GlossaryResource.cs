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

[StructSize(144)]
[XdbName("GlossaryResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GlossaryResource
{
    [FieldOffset(40, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(72)] public TextFileRef @description;
    [FieldOffset(104)] public ResourcePointer @image;
    [FieldOffset(112)] public TextFileRef @name;
}
