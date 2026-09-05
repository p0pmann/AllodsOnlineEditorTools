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

[SerializedExtent(97)]
[XdbName("MuteSoundCategory")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MuteSoundCategory
{
    [FieldOffset(48)] public string @muteCategoryName;
    [FieldOffset(72)] public string @substituteCategoryName;
    [FieldOffset(96)] public bool @isStopCategoryEvents;
}
