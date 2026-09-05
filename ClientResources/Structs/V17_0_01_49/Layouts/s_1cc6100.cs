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

[SerializedExtent(113)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1cc6100
{
    [FieldOffset(4)] public Layouts.@s_1cc5bb0 @X;
    [FieldOffset(36)] public Layouts.@s_1cc5bb0 @Y;
    [FieldOffset(72)] public ResourcePointer @sizingWidget;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @sizingWidgets;
    [FieldOffset(112)] public bool @QuantumScale;
}
