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

[SerializedExtent(112)]
[XdbName("CustomIdleComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CustomIdleComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @animations;
    [FieldOffset(104)] public float @timeMax;
    [FieldOffset(108)] public float @timeMin;
}
