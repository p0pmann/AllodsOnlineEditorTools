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

[StructSize(72)]
[XdbName("SocialMessageLimit")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SocialMessageLimit
{
    [FieldOffset(36)] public int @defaultMaxParameterLength;
    [FieldOffset(40)] public int @maxTotalTextLength;
    [FieldOffset(48)] public string @name;
}
