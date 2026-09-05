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

[SerializedExtent(190)]
[XdbName("CreatureChannelDirectAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureChannelDirectAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public NullablePointer @alternativeEndPoint;
    [FieldOffset(80)] public NullablePointer @alternativeStartPoint;
    [FieldOffset(88)] public ResourcePointer @channelingFx;
    [FieldOffset(96)] public NullablePointer @endPoint;
    [FieldOffset(104)] public int @fadeInTime;
    [FieldOffset(108)] public int @fadeOutTime;
    [FieldOffset(112)] public float @fxLength;
    [FieldOffset(116)][EnumRef(typeof(Enums.@e_1772dc0))] public int @multyTargetMode;
    [FieldOffset(120)] public NullablePointer @offendTime;
    [FieldOffset(128)] public Layouts.@s_173cc60 @secondaryTargetParams;
    [FieldOffset(176)] public NullablePointer @startPoint;
    [FieldOffset(184)] public float @velocity;
    [FieldOffset(188)] public bool @scaleTextureU;
    [FieldOffset(189)] public bool @scaleTextureV;
}
