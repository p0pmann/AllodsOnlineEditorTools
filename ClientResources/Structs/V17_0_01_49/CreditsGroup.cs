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

[StructSize(136)]
[XdbName("CreditsGroup")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreditsGroup
{
    [FieldOffset(40)] public TextFileRef @groupHeader;
    [FieldOffset(72)] public TextFileRef @groupSubHeader;
    [FieldOffset(104, ArrayStride = 96)] public Layouts.@s_32d9d0[] @items;
}
