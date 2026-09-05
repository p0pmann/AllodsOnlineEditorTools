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

[StructSize(112)]
[XdbName("ShadowSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShadowSettings
{
    [FieldOffset(40, ArrayStride = 4)] public int[] @nonCastingModelElememts;
    [FieldOffset(72, ArrayStride = 4)] public int[] @nonReceivingModelElements;
    [FieldOffset(104)] public int @shadowmapID;
    [FieldOffset(108)] public bool @castShadow;
    [FieldOffset(109)] public bool @receiveShadow;
}
