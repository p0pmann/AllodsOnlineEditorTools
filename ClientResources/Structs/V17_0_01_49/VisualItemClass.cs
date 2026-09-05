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

[StructSize(336)]
[XdbName("VisualItemClass")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualItemClass
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_ca55d0))] public int @animationsType;
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_ca5200[] @blockSounds;
    [FieldOffset(72, ArrayStride = 48)] public Layouts.@s_ca5190[] @hitSounds;
    [FieldOffset(104)][EnumRef(typeof(Enums.@e_168610))] public int @holdAnimation;
    [FieldOffset(112)] public ResourcePointer @holdController;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_ca52e0))] public int @holdHand;
    [FieldOffset(128)] public Layouts.@s_a96d80 @missSound;
    [FieldOffset(168)] public TextFileRef @name;
    [FieldOffset(200)] public ResourcePointer @replacement;
    [FieldOffset(208)] public string @storeInLocator;
    [FieldOffset(232)] public string @storeInLocatorOffHand;
    [FieldOffset(256)] public Layouts.@s_ca5270 @throwing;
    [FieldOffset(280)] public NullablePointer @visItemEffects;
    [FieldOffset(288)] public Layouts.@s_a96d80 @whooshSound;
    [FieldOffset(328)] public bool @hideIfStored;
    [FieldOffset(329)] public bool @storeAsDualWeapon;
    [FieldOffset(330)] public bool @storeUpToUp;
}
