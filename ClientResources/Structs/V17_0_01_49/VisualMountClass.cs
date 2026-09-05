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

[StructSize(488)]
[XdbName("VisualMountClass")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualMountClass
{
    [FieldOffset(40)] public Layouts.@s_c98530 @animationSettings;
    [FieldOffset(136)] public Layouts.@s_c7fef0 @controlParameters;
    [FieldOffset(180)][EnumRef(typeof(Enums.@e_168610))] public int @dismountAnimation;
    [FieldOffset(184)] public Layouts.@s_c98780 @fxSettings;
    [FieldOffset(224, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @hiddenDressSlots;
    [FieldOffset(256)] public Layouts.@s_c98bb0 @jumpSettings;
    [FieldOffset(280)] public ResourcePointer @levelChangedScript;
    [FieldOffset(288)] public Layouts.@s_c80140 @pitchParameters;
    [FieldOffset(328)] public Layouts.@s_c98930 @reinsSettings;
    [FieldOffset(456)][EnumRef(typeof(Enums.@e_c98cd0))] public int @riderOrientation;
    [FieldOffset(460)][EnumRef(typeof(Enums.@e_168610))] public int @sitAnimation;
    [FieldOffset(464)] public ResourcePointer @skinChangedScript;
    [FieldOffset(472)] public ResourcePointer @summonVisualScript;
    [FieldOffset(480)] public bool @nonDismountable;
    [FieldOffset(481)] public bool @useRiderSpineTurn;
}
