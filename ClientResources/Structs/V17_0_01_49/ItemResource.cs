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

[StructSize(888)]
[XdbName("gameMechanics.constructor.schemes.item.ItemResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemResource
{
    [FieldOffset(48, ArrayStride = 48)] public Layouts.@s_15a1510[] @actionGroupsBonuses;
    [FieldOffset(80)] public Layouts.@s_15a16c0 @actionPreviewInfo;
    [FieldOffset(184)] public ResourcePointer @auctionCategory;
    [FieldOffset(192)] public TextFileRef @bindDescription;
    [FieldOffset(224)][EnumRef(typeof(Enums.@e_153c2e0))] public int @binding;
    [FieldOffset(232, ArrayStride = 40)] public Layouts.@s_1016290[] @calcers;
    [FieldOffset(264)] public ResourcePointer @category;
    [FieldOffset(272)] public NullablePointer @counter;
    [FieldOffset(280, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(312)] public TextFileRef @description;
    [FieldOffset(344, ArrayStride = 8)] public ResourcePointer[] @dressSet;
    [FieldOffset(376, ArrayStride = 48)] public Layouts.@s_15a18f0[] @extraDescParts;
    [FieldOffset(408)] public NullablePointer @functionalPart;
    [FieldOffset(416)] public ResourcePointer @image;
    [FieldOffset(424)] public NullablePointer @interactions;
    [FieldOffset(432)] public ResourcePointer @itemClass;
    [FieldOffset(440)] public TextFileRef @itemMallDescription;
    [FieldOffset(472)] public ResourcePointer @itemMallImage;
    [FieldOffset(480)][EnumRef(typeof(Enums.@e_159e2f0))] public int @itemMallType;
    [FieldOffset(484)] public int @level;
    [FieldOffset(488)] public long @lifeLengthCap;
    [FieldOffset(496, ArrayStride = 8)] public NullablePointer[] @lifestylePredicates;
    [FieldOffset(528)] public TextFileRef @name;
    [FieldOffset(560, ArrayStride = 80)] public Layouts.@s_156c590[] @nameVars;
    [FieldOffset(592, ArrayStride = 40)] public Layouts.@s_15a1960[] @names;
    [FieldOffset(624)] public NullablePointer @onExpire;
    [FieldOffset(632)] public int @ownershipLimit;
    [FieldOffset(640)] public NullablePointer @prices;
    [FieldOffset(648)] public ResourcePointer @quality;
    [FieldOffset(656)] public int @requiredLevel;
    [FieldOffset(660)][EnumRef(typeof(Enums.@e_15e6280))] public int @requiredReputation;
    [FieldOffset(664)][EnumRef(typeof(Enums.@e_15a1e90))] public int @showItemContextAction;
    [FieldOffset(668)][EnumRef(typeof(Enums.@e_c5c6a0))] public int @slot;
    [FieldOffset(672)][EnumRef(typeof(Enums.@e_11d9330))] public int @source;
    [FieldOffset(680)] public ResourcePointer @sourceDescription;
    [FieldOffset(688)] public ResourcePointer @spell;
    [FieldOffset(696)] public int @stackLimit;
    [FieldOffset(704, ArrayStride = 8)] public ResourcePointer[] @statuses;
    [FieldOffset(736)] public string @sysName;
    [FieldOffset(760)] public ResourcePointer @visualElement;
    [FieldOffset(768)] public ResourcePointer @visualElementAlias;
    [FieldOffset(776)] public TextFileRef @worldDropNamePrefix;
    [FieldOffset(808)] public TextFileRef @worldDropNameRoot;
    [FieldOffset(840)] public TextFileRef @worldDropNameSuffix;
    [FieldOffset(872)] public bool @buyConfirmationRequired;
    [FieldOffset(873)] public bool @canBeDeposited;
    [FieldOffset(874)] public bool @clearAllOnTry;
    [FieldOffset(875)] public bool @forceShowLevel;
    [FieldOffset(876)] public bool @forceShowQuality;
    [FieldOffset(877)] public bool @ignoreDressSlotLevel;
    [FieldOffset(878)] public bool @isHideLifestyleWhileNotEquipped;
    [FieldOffset(879)] public bool @isProbe;
    [FieldOffset(880)] public bool @isQuestRelated;
    [FieldOffset(881)] public bool @needCheckPredicates;
    [FieldOffset(882)] public bool @premiumItem;
    [FieldOffset(883)] public bool @ritual;
    [FieldOffset(884)] public bool @showOnlyIconInLink;
}
