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

[StructSize(672)]
[XdbName("gameMechanics.constructor.schemes.quest.QuestResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuestResource
{
    [FieldOffset(48)] public NullablePointer @autoNavigationPredicate;
    [FieldOffset(56)] public TextFileRef @checkText;
    [FieldOffset(88)] public NullablePointer @clientParams;
    [FieldOffset(96, ArrayStride = 8)] public NullablePointer[] @counters;
    [FieldOffset(128)] public TextFileRef @finishText;
    [FieldOffset(160, ArrayStride = 80)] public Layouts.@s_156c590[] @finishTextVars;
    [FieldOffset(192)] public NullablePointer @finisher;
    [FieldOffset(200)] public TextFileRef @goal;
    [FieldOffset(232, ArrayStride = 80)] public Layouts.@s_156c590[] @goalVars;
    [FieldOffset(264, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(296)] public ResourcePointer @image;
    [FieldOffset(304)] public WString @internalName;
    [FieldOffset(328)] public TextFileRef @kickText;
    [FieldOffset(360)] public NullablePointer @level;
    [FieldOffset(368, ArrayStride = 24)] public Layouts.@s_11dbd00[] @lootTable;
    [FieldOffset(400)] public TextFileRef @name;
    [FieldOffset(432)] public string @plotline;
    [FieldOffset(456)][EnumRef(typeof(Enums.@e_10ac8b0))] public int @questCategory;
    [FieldOffset(464)] public NullablePointer @repeatPolicy;
    [FieldOffset(472)] public NullablePointer @requiredLevel;
    [FieldOffset(480)] public Layouts.@s_11d2e70 @returnLocation;
    [FieldOffset(528)] public NullablePointer @reward;
    [FieldOffset(536)] public Layouts.@s_15dbe10 @sharing;
    [FieldOffset(544, ArrayStride = 8)] public NullablePointer[] @startConditions;
    [FieldOffset(576)] public TextFileRef @startText;
    [FieldOffset(608, ArrayStride = 80)] public Layouts.@s_156c590[] @startTextVars;
    [FieldOffset(640)][EnumRef(typeof(Enums.@e_1127730))] public int @type;
    [FieldOffset(644)] public int @uiPriority;
    [FieldOffset(648)] public ResourcePointer @zone;
    [FieldOffset(656)] public bool @canBeSkipped;
    [FieldOffset(657)] public bool @canCancel;
    [FieldOffset(658)] public bool @forInstance;
    [FieldOffset(659)] public bool @hideLevel;
    [FieldOffset(660)] public bool @isAutomatic;
    [FieldOffset(661)] public bool @isLocationProgress;
    [FieldOffset(662)] public bool @itemMall;
    [FieldOffset(663)] public bool @lowPriority;
    [FieldOffset(664)] public bool @pvp;
    [FieldOffset(665)] public bool @secretSequence;
    [FieldOffset(666)] public bool @tutorial;
}
