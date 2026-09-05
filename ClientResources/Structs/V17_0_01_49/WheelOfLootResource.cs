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

[StructSize(96)]
[XdbName("gameMechanics.constructor.schemes.item.WheelOfLootResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WheelOfLootResource
{
    [FieldOffset(40)] public ResourcePointer @itemPrice;
    [FieldOffset(48)] public long @lifeTime;
    [FieldOffset(56)] public int @maxRollsCount;
    [FieldOffset(60)] public int @startRollPrice;
    [FieldOffset(64)] public string @sysName;
    [FieldOffset(88)] public bool @isLoginEvent;
    [FieldOffset(89)] public bool @isManual;
}
