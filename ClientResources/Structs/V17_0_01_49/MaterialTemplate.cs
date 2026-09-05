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

[StructSize(472)]
[XdbName("MaterialTemplate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MaterialTemplate
{
    [FieldOffset(40)] public FileRef @binaryFile;
    [FieldOffset(80)] public ResourcePointer @fallback;
    [FieldOffset(88)] public Layouts.@s_21a340 @pixelShader;
    [FieldOffset(280)] public Layouts.@s_21a340 @vertexShader;
}
