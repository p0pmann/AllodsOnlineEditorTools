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

[SerializedExtent(105)]
[XdbName("ChainAnimatorComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ChainAnimatorComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72, ArrayStride = 104)] public Layouts.@s_c54560[] @chains;
    [FieldOffset(104)] public bool @ignoreVisObjMotion;
}
