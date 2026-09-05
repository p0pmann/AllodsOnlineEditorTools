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

[StructSize(96)]
[XdbName("WidgetCss")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WidgetCss
{
    [FieldOffset(40)] public string @Id;
    [FieldOffset(64, ArrayStride = 88)] public Layouts.@s_1ceb630[] @Selectors;
}
