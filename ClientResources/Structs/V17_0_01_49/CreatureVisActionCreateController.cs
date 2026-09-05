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

[SerializedExtent(140)]
[XdbName("CreatureVisActionCreateController")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureVisActionCreateController
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public ResourcePointer @controller;
    [FieldOffset(80)] public string @controllerName;
    [FieldOffset(104)] public Layouts.@s_c4eab0 @parentController;
}
