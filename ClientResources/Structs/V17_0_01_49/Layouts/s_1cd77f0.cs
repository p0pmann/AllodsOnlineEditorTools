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

[SerializedExtent(21)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1cd77f0
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_1cd7180))] public int @Align;
    [FieldOffset(8)][EnumRef(typeof(Enums.@e_1cd7ac0))] public int @blendEffect;
    [FieldOffset(12)] public float @lineSpacing;
    [FieldOffset(16)] public bool @ellipsis;
    [FieldOffset(17)] public bool @multiline;
    [FieldOffset(18)] public bool @showClippedLine;
    [FieldOffset(19)] public bool @showClippedSymbol;
    [FieldOffset(20)] public bool @wrapText;
}
