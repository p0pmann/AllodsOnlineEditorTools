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

[StructSize(576)]
[XdbName("WidgetBrowser")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WidgetBrowser
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
    [FieldOffset(400)] public TextFileRef @wheelScrollJsCustomTemplate;
    [FieldOffset(432)] public int @wheelScrollJsStep;
    [FieldOffset(436)] public bool @resetOnShow;
    [FieldOffset(437)] public bool @stretchOnResize;
    [FieldOffset(448)] public Layouts.@s_1c4d830 @dataUrlFilteringOptions;
    [FieldOffset(488)] public ResourcePointer @defaultPage;
    [FieldOffset(496)] public ResourcePointer @defaultPageHash;
    [FieldOffset(504)] public ResourcePointer @helperScript;
    [FieldOffset(512)] public ResourcePointer @helperScriptHash;
    [FieldOffset(520)] public Layouts.@s_1c4d830 @pageUrlFilteringOptions;
    [FieldOffset(560)] public bool @allowPageEvents;
    [FieldOffset(561)] public bool @allowPageReactions;
    [FieldOffset(562)] public bool @allowSpecialEvents;
    [FieldOffset(563)] public bool @analyzeHttpCodes;
    [FieldOffset(564)] public bool @clearCookiesOnFinish;
    [FieldOffset(565)] public bool @defaultPageLoadOnStart;
    [FieldOffset(566)] public bool @helperScriptLoadOnStart;
    [FieldOffset(567)] public bool @receiveJsMessages;
    [FieldOffset(568)] public bool @respawnNotifier;
    [FieldOffset(569)] public bool @storeSecureCookies;
    [FieldOffset(570)] public bool @useHttpVfs;
}
