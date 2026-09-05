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

[SerializedExtent(96)]
[XdbName("BonesFromParentComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BonesFromParentComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_bbed10))] public int @bonesMode;
    [FieldOffset(72)] public string @ownRootBone;
}
