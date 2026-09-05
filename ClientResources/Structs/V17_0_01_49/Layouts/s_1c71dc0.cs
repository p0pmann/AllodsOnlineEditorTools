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

[SerializedExtent(385)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1c71dc0
{
    [FieldOffset(8)] public ResourcePointer @LayerHighlight;
    [FieldOffset(16)] public Vector2 @PushedOffset;
    [FieldOffset(24)] public string @Reaction;
    [FieldOffset(48)] public string @ReactionRightClick;
    [FieldOffset(72)] public Layouts.@s_1c718a0 @StateDisabled;
    [FieldOffset(120)] public Layouts.@s_1c718a0 @StateHighlighted;
    [FieldOffset(168)] public Layouts.@s_1c718a0 @StateNormal;
    [FieldOffset(216)] public Layouts.@s_1c718a0 @StatePushed;
    [FieldOffset(264)] public Layouts.@s_1c718a0 @StatePushedHighlighted;
    [FieldOffset(312)] public TextFileRef @TextFileRef;
    [FieldOffset(344)] public string @reactionDblClick;
    [FieldOffset(368)] public ResourcePointer @soundOver;
    [FieldOffset(376)] public ResourcePointer @soundPress;
    [FieldOffset(384)] public bool @ReactionOnUp;
}
