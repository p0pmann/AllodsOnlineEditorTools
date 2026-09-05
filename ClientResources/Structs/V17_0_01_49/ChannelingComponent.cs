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

[SerializedExtent(186)]
[XdbName("ChannelingComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ChannelingComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public ResourcePointer @channelingFx;
    [FieldOffset(80)] public Layouts.@s_1717ee0 @endPoint;
    [FieldOffset(128)] public float @fxLength;
    [FieldOffset(136)] public Layouts.@s_1717ee0 @startPoint;
    [FieldOffset(184)] public bool @scaleTextureU;
    [FieldOffset(185)] public bool @scaleTextureV;
}
