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

[StructSize(184)]
[XdbName("order.OrderResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @OrderResource
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @enterOrderSpell;
    [FieldOffset(80)] public ResourcePointer @image;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public ResourcePointer @prestigeEvent;
    [FieldOffset(128, ArrayStride = 8)] public ResourcePointer[] @ratingEvents;
    [FieldOffset(160)] public string @sysName;
}
