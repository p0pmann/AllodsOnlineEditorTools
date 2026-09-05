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
[XdbName("DeveloperAddon")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeveloperAddon
{
    [FieldOffset(40)] public ResourcePointer @mobList;
    [FieldOffset(48, ArrayStride = 56)] public Layouts.@s_4dcdc0[] @params;
    [FieldOffset(80)] public ResourcePointer @questList;
    [FieldOffset(88, ArrayStride = 40)] public FileRef[] @scriptFileRefs;
    [FieldOffset(120, ArrayStride = 48)] public Layouts.@s_4dcea0[] @tactics;
    [FieldOffset(152)] public int @timeout;
}
