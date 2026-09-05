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

[StructSize(152)]
[XdbName("Sound2DTassel")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Sound2DTassel
{
    [FieldOffset(40)] public Layouts.@s_a96bc0 @reverbPreset;
    [FieldOffset(80)] public Layouts.@s_a96bc0 @sound;
    [FieldOffset(120, ArrayStride = 24)] public Layouts.@s_a97800[] @soundParameters;
}
