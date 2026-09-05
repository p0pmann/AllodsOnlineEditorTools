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

[StructSize(88)]
[XdbName("ActionsOnPanelResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ActionsOnPanelResource
{
    [FieldOffset(40, ArrayStride = 24)] public Layouts.@s_f69a70[] @binds;
    [FieldOffset(72)] public ResourcePointer @characterClass;
    [FieldOffset(80)] public ResourcePointer @characterForm;
}
