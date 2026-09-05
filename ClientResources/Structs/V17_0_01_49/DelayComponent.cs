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

[SerializedExtent(89)]
[XdbName("DelayComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DelayComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public NullablePointer @component;
    [FieldOffset(80)] public float @timeMax;
    [FieldOffset(84)] public float @timeMin;
    [FieldOffset(88)] public bool @skipLoading;
}
