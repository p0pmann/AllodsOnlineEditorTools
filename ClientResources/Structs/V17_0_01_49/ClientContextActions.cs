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

[StructSize(104)]
[XdbName("ClientContextActions")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ClientContextActions
{
    [FieldOffset(40)] public ResourcePointer @defaultExploit;
    [FieldOffset(48)] public ResourcePointer @defaultMobVisualExploit;
    [FieldOffset(56, ArrayStride = 40)] public Layouts.@s_953ec0[] @namedActions;
    [FieldOffset(88)] public ResourcePointer @questOperatorAction;
    [FieldOffset(96)] public float @range;
}
