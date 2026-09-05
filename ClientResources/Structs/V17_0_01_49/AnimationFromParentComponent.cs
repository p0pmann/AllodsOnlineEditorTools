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

[SerializedExtent(118)]
[XdbName("AnimationFromParentComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AnimationFromParentComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72, ArrayStride = 48)] public Layouts.@s_d4fd70[] @animationsReplacements;
    [FieldOffset(104)] public ResourcePointer @controller;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_168610))] public int @ifAnimationNotExistsRun;
    [FieldOffset(116)] public bool @skipBlendOptimization;
    [FieldOffset(117)] public bool @synchronizeAnimationPosition;
}
