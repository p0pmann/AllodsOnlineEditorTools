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

[StructSize(528)]
[XdbName("WidgetButton")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WidgetButton
{
    [FieldOffset(40)] public ResourcePointer @BackLayer;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @Children;
    [FieldOffset(80)] public ResourcePointer @FrontLayer;
    [FieldOffset(88)] public string @Name;
    [FieldOffset(112)] public Layouts.@s_1cc6100 @Placement;
    [FieldOffset(232)] public int @Priority;
    [FieldOffset(236)] public int @TabOrder;
    [FieldOffset(240, ArrayStride = 64)] public Layouts.@s_1c72990[] @bindSections;
    [FieldOffset(272)] public float @fade;
    [FieldOffset(280)] public ResourcePointer @pickMask;
    [FieldOffset(288)] public string @reactionOnPointing;
    [FieldOffset(312)] public string @reactionWheelDown;
    [FieldOffset(336)] public string @reactionWheelUp;
    [FieldOffset(360)] public ResourcePointer @soundHide;
    [FieldOffset(368)] public ResourcePointer @soundShow;
    [FieldOffset(376)] public ResourcePointer @textureMask;
    [FieldOffset(384)] public bool @Enabled;
    [FieldOffset(385)] public bool @IgnoreDblClick;
    [FieldOffset(386)] public bool @PickChildrenOnly;
    [FieldOffset(387)] public bool @TransparentInput;
    [FieldOffset(388)] public bool @Visible;
    [FieldOffset(389)] public bool @clipContent;
    [FieldOffset(390)] public bool @forceWheel;
    [FieldOffset(391)] public bool @isProtected;
    [FieldOffset(396)] public Layouts.@s_1cd77f0 @TextStyle;
    [FieldOffset(424)] public WString @TextTag;
    [FieldOffset(448, ArrayStride = 392)] public Layouts.@s_1c71dc0[] @Variants;
    [FieldOffset(480)] public float @maxWidth;
    [FieldOffset(484)] public float @minWidth;
    [FieldOffset(488, ArrayStride = 64)] public Layouts.@s_1c72990[] @pushingBindSections;
    [FieldOffset(520)] public bool @useDefaultSounds;
}
