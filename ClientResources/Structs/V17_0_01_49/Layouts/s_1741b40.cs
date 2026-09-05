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

[SerializedExtent(107)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1741b40
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_103a6e0))] public int @category;
    [FieldOffset(72, ArrayStride = 176)] public Layouts.@s_1713b60[] @visualEffects;
    [FieldOffset(104)] public bool @dontFade;
    [FieldOffset(105)] public bool @restartOnVisCreatureChange;
    [FieldOffset(106)] public bool @stopOnDeath;
}
