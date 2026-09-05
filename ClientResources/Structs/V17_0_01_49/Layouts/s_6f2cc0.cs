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

[SerializedExtent(88)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_6f2cc0
{
    [FieldOffset(8)] public ResourcePointer @greatnessUnlock;
    [FieldOffset(16)] public TextFileRef @metamorphNameMask;
    [FieldOffset(48)] public ResourcePointer @metamorphUnlock;
    [FieldOffset(56, ArrayStride = 8)] public ResourcePointer[] @promotionUnlocks;
}
