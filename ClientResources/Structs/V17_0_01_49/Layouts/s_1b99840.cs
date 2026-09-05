// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(225)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1b99840
{
    [FieldOffset(8)] public string @alias;
    [FieldOffset(32)] public Layouts.@s_1b99520 @ambience;
    [FieldOffset(112, ArrayStride = 24)] public Layouts.@s_a97800[] @globalParameters;
    [FieldOffset(144)] public Layouts.@s_1b99600 @music;
    [FieldOffset(224)] public bool @useCameraTransformForListener;
}
